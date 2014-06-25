using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Majestic12;

namespace SharpKit.ExtJs4.Generator
{
    public class HtmlParser : IDisposable
    {
        public HTMLparser Parser { get; private set; }
        public HtmlParser(HTMLparser parser)
        {
            Parser = parser;
        }
        public string InnerText()
        {
            return NextTexts().Select(t => t.oHTML).StringConcat("");
        }
        public IEnumerable<HTMLchunk> NextTexts()
        {
            return NextChunks().Where(t => t.oType == HTMLchunkType.Text);
        }

        public IEnumerable<HTMLchunk> NextChunks()
        {
            while (true)
            {
                var chunk = Parser.ParseNext();
                if (chunk == null)
                    yield break;
                yield return chunk;
            }
        }
        public IEnumerable<HTMLchunk> NextTags()
        {
            while (true)
            {
                var chunk = Parser.ParseNextTag();
                if (chunk == null)
                    yield break;
                yield return chunk;
            }
        }

        public void Dispose()
        {
            Parser.Dispose();
        }
    }
}
