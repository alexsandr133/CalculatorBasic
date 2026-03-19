using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    internal class TextBlock
    {
        private string _content = "";

        public string GetName()
        {
            return "текст";
        }
        public void SetContent(string content)
        {
            _content = content;
        }
        public string Render()
        {
            return $"==={_content}===\r\n";
        }

        public void setContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
