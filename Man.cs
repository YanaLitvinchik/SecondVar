using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToList
{
    class Man
    {
        public Man() { }
        public Man(string str)
        {
            Name = str;
        }
        public Man(string str, int iNum)
        {
            Name = str;
            Id = iNum;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        
        public override string ToString()
        {
            return $"Man Name:{Name} Id:{Id}";
        }
        
    }
}
