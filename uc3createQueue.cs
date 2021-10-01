using System;
using System.Collections.Generic;

namespace day14stackqueue
{


    class Queue
    {
        public static void createqueue()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}


