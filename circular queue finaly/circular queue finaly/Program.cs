using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static circular_queue_finaly.circular_queue;

namespace circular_queue_finaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circular_queue x = new circular_queue(3);
            x.EnQueue(1);
            x.EnQueue(2);
            x.EnQueue(3);
            Console.WriteLine("---------------------");
            x.DeQueue();
            x.DeQueue();
            x.DeQueue();
            Console.WriteLine("---------------------");
            x.EnQueue(4);
            x.EnQueue(5);
            x.EnQueue(6);
          


            
            Console.ReadKey();
        }
    }
}
