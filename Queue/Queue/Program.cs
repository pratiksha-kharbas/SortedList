using System;
using System.Collections;


namespace Queuedemo
{
    class Queuedemo
    {
        static void Main(String[] args)
        {
            Queue<int> A1 = new Queue<int>();
            A1.Enqueue(1);
            A1.Enqueue(2);
            A1.Enqueue(3);
            A1.Enqueue(4);
            Console.WriteLine(A1);
            foreach (int queue in A1)
            {
                Console.WriteLine(queue);
            }
            // queue is first in first our
            int removedItem = A1.Dequeue(); 
            Console.WriteLine($"\nDequeued item: {removedItem}");
            foreach (int queue1 in A1)
            {
                Console.WriteLine(queue1);
            }
        }

    }
}
