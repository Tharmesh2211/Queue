using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class QueueMain
    {
        Queue queue = null;
        public QueueMain() 
        {
            if(queue == null)
            {
                queue = new Queue();
            }
        }
        public bool Check(Queue queue)
        {
            if (queue != null && queue.Count != 0)
                return true;
            return false;
        }
        public Queue Enqueue()
        {
            queue.Enqueue(100);
            queue.Enqueue("Tharmesh");
            queue.Enqueue('A');
            queue.Enqueue(0987654321);
            queue.Enqueue("Anna Nagar");
            Console.WriteLine("Element Enqueued Successfully !\n");
            return queue;
        }
        public void Dequeue(Queue queue)
        {
            queue.Dequeue();
            Console.WriteLine("Element Dequeued Successfully !\n");
            Display(queue);
        }

        public void Peek(Queue queue)
        {
            if(Check(queue))
            {
                Console.WriteLine("\nPeek Element in the Queue : "+queue.Peek());
            }
            else
            {
                Console.WriteLine("Queue is Empty !\n");
            }
        }
        public bool Contains(Queue queue)
        {
            if (Check(queue))
            {
                return queue.Contains(1);
            }
            return false;
        }

        public void Clear(Queue queue)
        {
            if (Check(queue))
            {
                queue.Clear();
                Console.WriteLine("\nQueue Cleared Successfully !\n");
            }
            else
            {
                Console.WriteLine("Queue Is Empty !\n");
            }
        }

        public void Count(Queue queue)
        {
            if (Check(queue))
            {
                Console.WriteLine("\nTotal Element in the Queue "+queue.Count);
            }
            else
            {
                Console.WriteLine("Queue is Empty !\n");
            }
        }
        public void Display(Queue queue)
        {
            int x = 0;
            if(Check(queue))
            {
                foreach (var item in queue)
                {
                    Console.WriteLine("Element {0} in Queue is {1}", ++x, item);
                }
            }
            else
            {
                Console.WriteLine("Queue is Empty !\n");
            }
            Console.WriteLine();
        }
    }
}
