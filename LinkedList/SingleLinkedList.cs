using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SingleLinkedList
    {
        public Node Head { get; set; }

        public void insertAtHead(Node node)
        {
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }

        }

        public void insertAtTail(Node node)
        {
            Node tail = getTail();
            if(tail == null)
            {
                Head = node;
            }
            else
            {
                tail.Next = node;
            }
        }

        public void insertAfter(Node prev, Node node)
        {
            if(prev != null)
            {
                node.Next = prev.Next;
                prev.Next = node;
            }
        }

        public void deleteAt(int index)
        {
            Node del = getAt(index);

            if (del != null)
            {
                Node node = Head;
                while (node.Next != null)
                {
                    if (node.Next == del)
                    {
                        node.Next = del.Next;
                        del = null;
                        break;
                    }
                    node = node.Next;
                }

            }
        }

        public void deleteKey(int key)
        {

            if (Head != null)
            {
                Node node = Head;
                while (node.Next != null)
                {
                    if (node.Next.Data == key)
                    {
                        node.Next = node.Next.Next;
                        break;
                    }
                    node = node.Next;
                }
                
            }
            

        }

        public void deleteAtHead()
        {
            if ((Head != null) || (Head.Next == null))
            {
                Node temp = Head;
                Head = Head.Next;
                temp = null;
            }
        }

        public void deleteAtTail()
        {
            Node del = getTail();

            if (del != null)
            {
                Node node = Head;
                while (node.Next != null)
                {
                    if (node.Next == del)
                    {
                        node.Next = null;
                        break;
                    }

                    node = node.Next;
                }

            }

        }

        public Node getAt(int index)
        {
            if (Head != null)
            {
                int counter = 0;
                Node node = Head;

                while (node.Next != null)
                {
                    if(counter == index)
                    {
                        return node;
                    }
                    else
                    {
                        node = node.Next;
                        counter++;
                    }
                    
                }

                return null;
                
            }
            else
            {
                return null;
            }
        }

        public Node getTail()
        {
            if(Head != null)
            {
                Node node = Head;
                while(node.Next != null)
                {
                    node = node.Next;
                }
                return node;
            }
            else
            {
                return null;
            }
        }

        public Node searchKey(int key)
        {
            if (Head != null)
            {
                Node node = Head;
                while (node.Next != null)
                {
                    if(node.Data == key)
                    {
                        return node;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public int getMiddle()
        {
            int count = 0;

            Node node = Head;
            while (node.Next != null)
            {
                node = node.Next;
                count++;
            }
            //count++;

            int aver;
            if (count % 2 == 0)
            {
                aver = count / 2;
                count = 0;

                node = Head;
                while (node.Next != null)
                {
                    if (count == aver)
                    {
                        return node.Data;
                    }
                    node = node.Next;
                    count++;
                }
            }
            else
            {
                aver = (int)Math.Floor((double)count / 2);

                count = 0;

                node = Head;
                while (node.Next != null)
                {
                    if (count == aver)
                    {
                        return ((node.Data + node.Next.Data)/2);
                    }
                    node = node.Next;
                    count++;
                }
            }

            return -1;
        }

        public void printList()
        {
            Node node = Head;
            while (node != null)
            {
                Console.Write(node.Data + " --> ");
                node = node.Next;
            }

            Console.ReadLine();
        }
    }
}
