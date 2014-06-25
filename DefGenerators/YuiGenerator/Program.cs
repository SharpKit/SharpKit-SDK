using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections;

namespace YuiGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.IsNullOrEmpty() || args.Length!=2)
                    Console.WriteLine("Syntax: YuiGenerator.exe [dataJsonFilename] [outputDir]");
                YuiDataJsonToSharpKitCsFiles(args[0], args[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void YuiDataJsonToSharpKitCsFiles(string dataJsonFilename, string outputDir)
        {
            //var api = File.ReadAllText("api.js");
            var data = File.ReadAllText(dataJsonFilename);

            var ser = new JavaScriptSerializer { MaxJsonLength = int.MaxValue };
            var json = ser.Deserialize(data, null);

            var gen = new YuiCodeGenerator
            {
                DataJson=json,
            };
            gen.Generate();
            gen.Finalize2();
            gen.Save(outputDir);
        }
    }


}
