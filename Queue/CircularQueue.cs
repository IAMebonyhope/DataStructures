using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CircularQueue
    {
        private int rear;
        private int front;
        private int size;
        private int[] queue;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public CircularQueue(int k)
        {
            queue = new int[k];
            front = rear = -1;
            size = k;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if(IsFull() == true)
            {
                return false;
            }

            if(front == -1)
            {
                front = rear = 0;
                queue[rear] = value;
            }

            else if((rear == (size-1)) && (front != 0))
            {
                rear = 0;
                queue[rear] = value;
            }

            else
            {
                rear++;
                queue[rear] = value;
            }

            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if(IsEmpty() == true)
            {
                return false;
            }

            if(front == rear)
            {
                front = rear = -1;
            }

            else if(front == (size - 1))
            {
                front = 0;
            }

            else
            {
                front++;
            }

            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if(IsEmpty() == true)
            {
                return -1;
            }

            return queue[front];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty() == true)
            {
                return -1;
            }
            return queue[rear];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            if(front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            if(((front == 0) && (rear == (size - 1))) || (front == (rear + 1)))
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
