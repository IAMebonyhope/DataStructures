using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue circularQueue = new CircularQueue(3); // set the size to be 3
            Console.WriteLine(circularQueue.EnQueue(1));  // return true
            Console.WriteLine(circularQueue.EnQueue(2));  // return true
            Console.WriteLine(circularQueue.EnQueue(3));  // return true
            Console.WriteLine(circularQueue.EnQueue(4));  // return false, the queue is full
            Console.WriteLine(circularQueue.Rear());  // return 3
            Console.WriteLine(circularQueue.IsFull());  // return true
            Console.WriteLine(circularQueue.DeQueue());  // return true
            Console.WriteLine(circularQueue.EnQueue(4));  // return true
            Console.WriteLine(circularQueue.Rear());  // return 4
            Console.ReadLine();
        }
    }
}
