using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node Next { get; set; }

        public Node Previous { get; set; }

        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
        
    }
}
