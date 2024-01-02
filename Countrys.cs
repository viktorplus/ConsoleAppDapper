using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    internal class Countrys
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Countrys() { }

        public Countrys(int id, string name) { Id = id; Name = name; }

        override public string ToString()
        {
            return $"Id: {Id}\nName: {Name}\n";
        }
    }
}
