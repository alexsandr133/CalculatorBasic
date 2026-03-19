using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    internal class DocumentBuilder
    {
        private List<IBlock> _blocks = new List<IBlock>();
        //добавляем блок
        public void addBlock(IBlock block)
        {
            _blocks.Add(block);
        }
        //удаляем блок по индексу
        public void removeBlock(int index)
        {
            if (index >= 0 && index < _blocks.Count)
                _blocks.RemoveAt(index);
        }
        //собираем итоговый документ
        public  string Build()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var block  in _blocks)
            {
                sb.Append(block.Render());
               
            }
            return sb.ToString();
        }   
    
      }
}
