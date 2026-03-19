using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public class HeaderBlock: IBlock
    {
        private string _content = "";

        public string GetName()
        {
            return "заголовок";
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
