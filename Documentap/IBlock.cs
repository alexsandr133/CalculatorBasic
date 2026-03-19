using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public interface IBlock
    {
        object SetContent(string content);

        string GetName();

        void setContent(string content);

        string Render();
    }
}
