using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using SharpKit.Qooxdoo.Generator.Metadata;
using SharpKit.Qooxdoo.Generator.Json;
using SharpKit.Qooxdoo.Generator.Templates;
using System.Diagnostics;

namespace SharpKit.Qooxdoo.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capitalize names by default
            Settings.CapitalizeNames = true;

            if (!Debugger.IsAttached)
            {
                if (args.Length == 0)
                {
                    // Instructions
                    Console.WriteLine("Usage: {0} <path_to_api_json> [-nc]", AppDomain.CurrentDomain.FriendlyName);
                    Console.WriteLine("Parameters:");
                    Console.WriteLine("\t path_to_api_json: path to the the generated API JSON");
                    Console.WriteLine("\t nc: (optional) don't capitalize type names");
                }
                else
                {
                    // Generate with parameters
                    var apiPath = args[0];
                    if (args.Length > 1 && args[1] == "-nc")
                        Settings.CapitalizeNames = false;
                    Generate(apiPath);
                }
            }
            else
            {
                // Test
                Generate(@"..\..\ApiDocs");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void Generate(string apiPath)
        {
            try
            {
                // Enumerate through all *.json files in the provided path and generate classes
                if (Directory.Exists(apiPath))
                {
                    Log("Scanning {0}...", apiPath);
                    var jsonFiles = Directory.EnumerateFiles(apiPath, "*.json").ToList();
                    Log("Found {0} objects.", jsonFiles.Count);

                    if (jsonFiles.Count > 0)
                    {
                        // Parse JSON into metadata classes
                        var generatedPath = Path.Combine(apiPath, "generated");
                        if (!Directory.Exists(generatedPath)) Directory.CreateDirectory(generatedPath);

                        Log("Parsing JSON files...");
                        var metaClasses = new List<MetaClass>();
                        foreach (var jsonFile in jsonFiles)
                        {
                            Log("Parsing {0}...", Path.GetFileName(jsonFile));
                            var node = JsonConvert.DeserializeObject<Node>(File.ReadAllText(jsonFile));
                            if (node.Attributes != null)
                            {
                                var metaClass = new MetaClass(node);
                                if (!String.IsNullOrWhiteSpace(metaClass.Name))
                                {
                                    metaClasses.Add(metaClass);
                                }
                            }
                        }

                        // Generate classes from the metadata
                        Log("Generating classes...");
                        foreach (var metaClass in metaClasses)
                        {
                            Log("Generating {0}...", metaClass.FullName);
                            // Add properties from mixins to the classes
                            metaClass.AddMixins(metaClasses);
                            // Add class interfaces
                            metaClass.AddInterfaces(metaClasses);
                            
                            // Generate class/interface from T4 template
                            string content = null;
                            if (!metaClass.IsInterface)
                            {
                                var template = new ClassTemplate { Session = new Dictionary<string, object> { { "Model", metaClass } } };
                                content = template.TransformText();
                            }
                            else if (metaClass.IsInterface)
                            {
                                var template = new InterfaceTemplate { Session = new Dictionary<string, object> { { "Model", metaClass } } };
                                content = template.TransformText();
                            }

                            // Write output class to .cs file
                            if (content != null)
                            {
                                var relOutputFile = metaClass.OriginalFullName.Replace(".", @"\") + ".cs";
                                if (!relOutputFile.StartsWith(@"qx\")) relOutputFile = @"qx\" + relOutputFile;
                                var outputFile = Path.Combine(generatedPath, relOutputFile);
                                var outputPath = Path.GetDirectoryName(outputFile);
                                if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                                File.WriteAllText(outputFile, content);
                            }
                        }
                    }
                    Log("Generation completed.");
                }
                else
                {
                    Log("Path not found: " + apiPath);
                }
            }
            catch (Exception e)
            {
                Log(e);
            }
        }

        static void Log(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + exception.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Log(string entry, params object[] parameters)
        {
            Console.WriteLine(entry, parameters);
        }
    }
}
