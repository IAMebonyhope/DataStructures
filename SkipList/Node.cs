using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    public class Node<T>
    {
        public int Key { get; set; }

        public T Value { get; set; }

        public Node<T>[] Forwards { get; set; }

        public Node(int key, T value, int level)
        {
            Key = key;
            Value = value;
            Forwards = new Node<T>[level];
        }
    }
}
