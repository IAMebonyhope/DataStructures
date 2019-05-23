using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Vertix<V>
    {

        public V Name { get; }

        public bool Visited { get; set; }

        public int Distance { get; set; }

        public Vertix<V> Previous { get; set; }

        public Vertix(V name)
        {
            Name = name;
            Visited = false;
            Distance = 0;
            Previous = null;
        }

        
    }
}
