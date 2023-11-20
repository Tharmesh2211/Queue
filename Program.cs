using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QueueMain queuemain = new QueueMain();
            
            Queue queue = queuemain.Enqueue();
            queuemain.Display(queue);
            queuemain.Dequeue(queue);
            queuemain.Peek(queue);
            if (queuemain.Contains(queue))
            {
                Console.WriteLine("\nElement Present");
            }
            else
            {
                Console.WriteLine("\nElement Not Present");
            }
            queuemain.Count(queue);
            queuemain.Clear(queue);
            queuemain.Display(queue);
        }
    }
}
