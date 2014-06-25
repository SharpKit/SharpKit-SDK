using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

using TinyMCEApiGenerator;

namespace SharpKit.TinyMCE
{
    class Program
    {
        static void Main()
        {

            string pathToXml = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\model.xml";

            string outputDir = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\SharpKit.TinyMCE\\";

            string strXml = File.ReadAllText(pathToXml);

            XmlDocument d = new XmlDocument();
            d.LoadXml(strXml);

            var gen = new TinyMCECodeGenerator
            {
                DataXml = d,
                Logger = new TinyMCECodeGenerator.LogDelegate(DoLog)
            };
            gen.Generate();
            gen.Finalize2();
            gen.Save(outputDir, false);

        }


        static void DoLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}