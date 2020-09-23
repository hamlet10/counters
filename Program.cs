using System;
using System.Collections.Generic;

namespace Counters
{
    class Program
    {
        static void Main(string[] args)
        {


            var naturalsCounter = BuildNaturalsCounter();
            Console.WriteLine("Naturals ...");
            Console.WriteLine(naturalsCounter());

            Console.WriteLine(naturalsCounter());

            Console.WriteLine(naturalsCounter());

            var fiboCounter = BuildFiboCounter();
            Console.WriteLine("\nFibo ...");
            foreach (int item in fiboCounter)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine("\n Contador primo");
            var primeCounter = PrimeCounter();
            foreach (var item in primeCounter)
            {
                Console.WriteLine(item);
            }

        }

        private static Func<int> BuildNaturalsCounter()
        {
            int i = 1;

            return () => i++;
        }

        private static IEnumerable<int> BuildFiboCounter()
        {

            // int temp;
            int a = 1;
            int b = 0, c = 0;
            for (int i = 0; i < 10; i++)
            {


                c = a;
                a = b;
                b = c + a;
                yield return a;
            }
            

        }
        static IEnumerable<int> PrimeCounter()
        {
            for ( int i = 2; i < 20; i++)
            {
                if( i == 2)
                {
                    yield return i;
                }
                if( i % 2 != 0)
                {
                    yield return i;
                }
            }
        }


    }
}
