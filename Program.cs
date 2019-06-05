using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            foreach (var i in GetFibonacci().Take(20))
            {
                Console.WriteLine(i);   
            }
        }

        private static IEnumerable<int> GetFibonacci()
        {
            int current = 1, next = 1;

            while(true)
            {
                yield return current;
                next = current + (current = next);
            }
        }
    }
}
