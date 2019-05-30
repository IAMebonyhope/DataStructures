using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SkipList
{
    public class Randomized<T> : SkipList<T>
    {
        public Randomized(int maxLevel, T sentinel)
        {
            MaxLevel = maxLevel;

            Head = new Node<T>(-1, sentinel, MaxLevel);

            for(int i=0; i<MaxLevel; i++)
            {
                Head.Forwards[i] = null;
            }
        }

        public override void insert(int key, T value)
        {
            int x = getLevel();
            Node<T> newNode = new Node<T>(key, value, x);
            Node<T>[] updates = new Node<T>[MaxLevel];

            Node<T> node = Head;
            for (int i = (MaxLevel - 1); i >= 0; i--)
            {
                while ((node.Forwards[i] != null) && (node.Forwards[i].Key < key))
                {
                    node = node.Forwards[i];
                }

                updates[i] = node;
            }

            for (int i = 0; i < x; i++)
            { 
                newNode.Forwards[i] = updates[i].Forwards[i];
                updates[i].Forwards[i] = newNode; 
            }
        }

        public override void delete(int key)
        {

            Node<T> delNode = searchKey(key);

            if((delNode == null) || (delNode.Key != key))
            {
                return;
            }

            Node<T>[] updates = new Node<T>[MaxLevel];

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

            int x = delNode.Forwards.Length;
            for (int i = 0; i < x; i++)
            {
                updates[i].Forwards[i] = delNode.Forwards[i];
            }


        }

        private int getLevel()
        {
            
            Random rand = new Random();
            double x = rand.NextDouble();
            int level = 1;

            while((x > 0.5) && (level < MaxLevel))
            {
                Thread.Sleep(5000);
                x = rand.NextDouble();
                level++;
            }

            return level;
        }
    }
}
