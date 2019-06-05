using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    public abstract class SkipList<T>
    {
        public Node<T> Head { get; set; }

        public int MaxLevel { get; set; }

        public abstract void insert(int key, T value);

        public abstract void delete(int key);

        public int Size()
        {
            int total = 1;

            Node<T> node = Head;

            while(node.Forwards[0] != null)
            {
                node = node.Forwards[0];
                total++;
            }

            return total;
        }

        public bool IsEmpty()
        {
            if(Head.Forwards[0] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int getIndex(int key)
        {
            int count = -1;

            if(Head.Key == key)
            {
                return count;
            }

            Node<T> node = Head;

            while (node.Forwards[0] != null)
            {
                if (node.Forwards[0].Key == key)
                {
                    count++;
                    break;
                }
                count++;
                node = node.Forwards[0];
                
            }

           
            return count;
        }

        public Node<T> searchKey(int key)
        {
            Node<T> node = Head;

            for(int i=(MaxLevel-1); i>=0; i--)
            {
                while ((node.Forwards[i] != null) && (node.Forwards[i].Key < key))
                {
                    node = node.Forwards[i];
                }
            }

            if((node.Forwards[0] != null) && (node.Forwards[0].Key == key))
            {
                return node.Forwards[0];
            }
            else
            {
                return null;
            }
        }

        public void printList()
        {

            for (int i = MaxLevel-1; i>=0; i--)
            {
                Node<T> node = Head;

                Console.Write("Level " + (i + 1) + ": ");
                Console.Write(Head.Key + "---->");

                if (node.Forwards.Length > i)
                {
                    while (node.Forwards[i] != null)
                    {
                        Console.Write(node.Forwards[i].Key + "---->");
                        node = node.Forwards[i];
                    }
                }
                
                Console.Write("NULL");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        
    }
}
