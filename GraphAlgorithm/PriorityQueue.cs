using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class PriorityQueue<V>
    {
        private List<Vertix<V>> vertices;

        public PriorityQueue(List<Vertix<V>> vertices)
        {
            this.vertices = vertices;
        }

        public List<Vertix<V>> Vertices { get { return vertices; } }

        public Vertix<V> MinimumDistance()
        {
            vertices = vertices.OrderBy(x => x.Distance).ToList();
            var vertix = vertices.First();

            return vertix;
        }

        public void RemoveVertex(Vertix<V> vertix)
        {
            vertices.Remove(vertix);
        }

        public void AddVertex(Vertix<V> vertix)
        {
            vertices.Add(vertix);
        }

        public int CountVertices()
        {
            return vertices.Count;
        }

        public bool IsNull()
        {
            if (vertices == null || (vertices.Count < 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
