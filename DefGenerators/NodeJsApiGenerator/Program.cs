using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.IO;

namespace NodeJsApiGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                args = new[] { "..\\..\\all.json", "..\\..\\..\\SharpKit.NodeJs\\" };
                if (args.IsNullOrEmpty() || args.Length != 2)
                    Console.WriteLine("Syntax: NodeJsApiGenerator.exe [dataJsonFilename] [outputDir]");

                YuiDataJsonToSharpKitCsFiles(args[0], args[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void YuiDataJsonToSharpKitCsFiles(string dataJsonFilename, string outputDir)
        {
            var data = File.ReadAllText(dataJsonFilename);

            var ser = new JavaScriptSerializer { MaxJsonLength = int.MaxValue };
            var json = ser.Deserialize(data, null);

            var gen = new YuiCodeGenerator
            {
                DataJson = json,
            };
            gen.Generate();
            gen.Finalize2();
            gen.Save(outputDir);
        }

    }
}
