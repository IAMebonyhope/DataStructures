using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    public class Perfect<T>: SkipList<T>
    {
        public Perfect(T sentinel)
        {
            MaxLevel = 1;

            Head = new Node<T>(-1, sentinel, MaxLevel);

            for (int i = 0; i < MaxLevel; i++)
            {
                Head.Forwards[i] = null;
            }
        }

        public override void insert(int key, T value)
        {
            
            List<Node<T>> updates = new List<Node<T>>();

            Node<T> node = Head;

            for (int i = (MaxLevel - 1); i >= 0; i--)
            {
                while ((node.Forwards[i] != null) && (node.Forwards[i].Key < key))
                {
                    node = node.Forwards[i];
                }

                updates.Add(node);
            }

            int index = getIndex(node.Key) + 1;

            int x = getLevel(index);
            updateLevel(x);
            Node<T> newNode = new Node<T>(key, value, x);

            for (int i = 0; i < x; i++)
            {
                if(i >= updates.Count)
                {
                    newNode.Forwards[i] = null;
                    updates.Add(newNode);
                }
                else
                {
                    newNode.Forwards[i] = updates[i].Forwards[i];
                    updates[i].Forwards[i] = newNode;
                }
                
            }

            updateNodes(updates, newNode, index);
        }

        public override void delete(int key)
        {

            Node<T> delNode = searchKey(key);

            if ((delNode == null) || (delNode.Key != key))
            {
                return;
            }

            int x = delNode.Forwards.Length;
            Node<T>[] updates = new Node<T>[x];

            Node<T> node = Head;
            for (int i = (MaxLevel - 1); i >= 0; i--)
            {
                while ((node.Forwards[i] != null) && (node.Forwards[i].Key < key))
                {
                    node = node.Forwards[i];
                }

                updates[i] = node;
            }

            node = node.Forwards[0];

            for (int i = 0; i < x; i++)
            {

                updates[i].Forwards[i] = delNode.Forwards[i];
            }


        }

        private int getLevel(int index)
        {
            double x = Math.Log((index + 1), 2);

            if ((x*10)%10 != 0)
            {
                return 1;
            }
            else
            {
                return (int)(x + 1);
            }
        }

        private void updateLevel(int newLevel)
        {
            if(newLevel > MaxLevel)
            {
                Node<T> newHead = new Node<T>(Head.Key, Head.Value, newLevel);

                for (int i = 0; i < MaxLevel; i++)
                {
                    newHead.Forwards[i] = Head.Forwards[i];
                }
                for (int i=MaxLevel; i<newLevel; i++)
                {
                    newHead.Forwards[i] = null;
                }
                Head = newHead;
                MaxLevel = newLevel;
            }
        }

        private void updateNodes(List<Node<T>> updates, Node<T> node, int index)
        {
            while(node.Forwards[0] != null)
            {
                

                int x = getLevel(index);
                updateLevel(x);
                Node<T> newNode = new Node<T>(node.Key, node.Value, x);

                for (int i = 0; i < x; i++)
                {
                    if (i >= updates.Count)
                    {
                        newNode.Forwards[i] = null;
                        updates.Add(newNode);
                    }
                    else
                    {
                        newNode.Forwards[i] = updates[i].Forwards[i];
                        updates[i].Forwards[i] = newNode;
                        updates[i] = newNode;
                    }

                    
                }

                node = newNode;
                index++;
            }

            
            
        }
    }
}
