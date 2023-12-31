using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Section() { }

        public Section(int id, string name) { Id = id; Name = name; }

        override public string ToString()
        {
            return $"Id: {Id}\nName: {Name}\n";
        }

    }
}
