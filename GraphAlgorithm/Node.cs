using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Node<V>
    {
        public Vertix<V> Vertix { get; } //adjacent vertix

        public int Weight { get; } // weight of the edge connecting them

        public Node(Vertix<V> vertix, int weight)
        {
            Vertix = vertix;
            Weight = weight;
        }


        public override string ToString()
        { 
            return Vertix.Name + ":" + Weight;
        }
    }

}
