
/*******************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

namespace WebIDLParser
{

    public class Program
    {

        //Path to the existing project SharpKit.Html project
        public static string csOutDirectory = @"D:\dotnet\sharpkit\sdk\sharpkit\SharpKit.Html\generated\";

        //Path to the WebKit(--> WebCore) sources. ( http://trac.webkit.org/browser/trunk/Source/WebCore/ )
        public static string idlInDirectory = @"D:\dotnet\webkit\Source\WebCore\";

        //An temporary directory, where the preprocessed IDL files will be stored.
        public static string idlOutTempDirectory = @"D:\IdlCs\idl\";

        //Needs to be true. Set only to false, when you already have the preprocessed IDL files in the idlOutTempDirectory.
        public static bool runPreprocessor = false;

        //Path to a c/c++ compiler, used for preprocessing the files.
        public static string preprocessorExe = @"C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\bin\amd64\cl.exe";

        public static void Main(string[] args)
        {
            setTransformations();
            Generator.start();
        }

        private static void setTransformations()
        {
            //In c#-bindinds, types beginning with "HTML" will be renamed to "Html".
            //THe output generetes still the "HTML" version, for example
            //c#: el is HtmlImageElement
            //js: el instanceof HTMLImageElement
            Transformations.renameCsTypePrefix("HTML", "Html");
            Transformations.renameCsTypePrefix("SVG", "Svg");
            Transformations.renameCsTypePrefix("CSS", "Css");

            //---
            Transformations.moveToRootNamespace("css");
            Transformations.moveToRootNamespace("dom");
            Transformations.moveToRootNamespace("html");
            Transformations.moveToRootNamespace("html.canvas");
            Transformations.moveToRootNamespace("websockets");
            Transformations.moveToRootNamespace("page");
            Transformations.moveToRootNamespace("xml");

            Transformations.generateElementConstructorForType("Html", "Element"); //This will extract "hr" from HtmlHrElement and generates document.createElement('hr')
            Transformations.generateElementConstructorForType("Svg", "Element");

            //Extracting the tagName will sometimes not get the correct tagname. Here they can specified more detailed.
            Transformations.generateElementConstructorCorrectTagName("HtmlImageElement", "img");
            Transformations.generateElementConstructorCorrectTagName("HtmlAnchorElement", "a");
            Transformations.generateElementConstructorCorrectTagName("HtmlTableCaptionElement", "caption");
            Transformations.generateElementConstructorCorrectTagName("HtmlTableCellElement", "td");
            Transformations.generateElementConstructorCorrectTagName("HtmlTableColElement", "col");
            Transformations.generateElementConstructorCorrectTagName("HtmlTableRowElement", "tr");
            Transformations.generateElementConstructorCorrectTagName("HtmlTableSectionElement", "tbody"); //TODO: It can be thead or tfoot, too!
            Transformations.generateElementConstructorCorrectTagName("HtmlDListElement", "dl");
            Transformations.generateElementConstructorCorrectTagName("HtmlOListElement", "ol");
            Transformations.generateElementConstructorCorrectTagName("HtmlUListElement", "ul");
            Transformations.generateElementConstructorCorrectTagName("HtmlDictionaryElement", "d");
            Transformations.generateElementConstructorCorrectTagName("HtmlParagraphElement", "p");
            Transformations.generateElementConstructorCorrectTagName("HtmlModElement", "tbody"); // TODO: Could be del or ins, but not mod. mod is an interface.

            //The Webkit IDL files have sometimes another return type for internal use. Here they can be corrected.
            Transformations.changeDelegateResultType("PositionCallback", "void");
            Transformations.changeDelegateResultType("PositionErrorCallback", "void");


            Transformations.renameType("DOMWindow", "Window");
        }

    }

}

