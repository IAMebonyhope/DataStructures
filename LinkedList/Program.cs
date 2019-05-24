using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList llist = new SingleLinkedList();

            llist.insertAtHead(new Node(3));

            llist.insertAtHead(new Node(2));

            llist.insertAtHead(new Node(1));

            llist.insertAtTail(new Node(4));

            llist.insertAtTail(new Node(5));

            Node nodeA = new Node(6);
            llist.insertAtTail(nodeA);

            llist.insertAtTail(new Node(8));

            llist.insertAfter(nodeA, new Node(7));
            llist.printList();

            llist.deleteAtHead();
            llist.printList();

            llist.deleteAtTail();
            llist.printList();

            llist.deleteAt(4);
            llist.printList();

            llist.deleteKey(4);
            llist.printList();
        }
    }
}
