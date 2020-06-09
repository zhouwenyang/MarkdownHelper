using System;
using Markdig;

namespace MarkdownHelper
{
    public class Markdown
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToHTML(string markdown)
        {
            return Markdig.Markdown.ToHtml(markdown);
        }
    }
}
