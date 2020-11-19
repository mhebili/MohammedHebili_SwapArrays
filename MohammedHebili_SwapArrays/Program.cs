using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammedHebili_SwapArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 4, 5, 6 });
            Console.Write("swap this array into opposite ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static int[] test(int[] numbers)
        {
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = first;

            return numbers;
        }
    }
}
