using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomized<int> skiplist = new Randomized<int>(8, -1);
            skiplist.printList();

            skiplist.insert(6, 6);
            skiplist.printList();

            skiplist.insert(8, 8);
            skiplist.printList();

            skiplist.insert(1, 1);
            skiplist.printList();

            skiplist.insert(3, 3);

            skiplist.insert(19, 19);

            skiplist.insert(5, 5);
            skiplist.printList();

            skiplist.insert(11, 11);

            skiplist.insert(9, 9);
            skiplist.printList();

            skiplist.insert(9, 90);
            skiplist.printList();

            Console.WriteLine(skiplist.searchKey(9).Key);

            skiplist.delete(11);
            skiplist.printList();

            skiplist.delete(13);
            skiplist.printList();

            skiplist.delete(3);
            skiplist.printList();

            skiplist.delete(5);
            skiplist.printList();

            skiplist.delete(6);
            skiplist.printList();
        }
    }
}
