using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circular_queue_finaly
{
    internal class circular_queue
    {
        int rear = -1;
        int front = -1;
        int[] circulararray;
        public circular_queue(int length)
        {
            circulararray = new int[length];
        }
        public bool isfull()
        {
            if ((front == 0 && rear == circulararray.Length-1) || front == rear + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isempty()
        {
            if (front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void EnQueue(int value)
        {
            if (!isfull())
            {
                if (front == -1)
                {
                    front = 0;
                }
                rear = (rear+1) % circulararray.Length;
                circulararray[rear] = value;
            }
            else
            {
                Console.WriteLine("array is full");
            }


        }
        public void DeQueue()
        {
            if (!isempty())
            {
                Console.WriteLine(circulararray[front]);
                if (rear == front)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front+1) % circulararray.Length;
                }


            }
            else
            {
                Console.WriteLine("array is empty");
            }


        }
        public void printarray()
        {
            if (!isempty())
            {
                for (int i = front; i != rear;i= (i + 1) % circulararray.Length)
                {
                    Console.WriteLine(circulararray[i]);
                }

            }
            else
            {
                Console.WriteLine("array is empty");
            }

        }






    }
}
