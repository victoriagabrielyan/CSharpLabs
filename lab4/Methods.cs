using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    internal class Methods
    {
        public static void A(in int x)
        {
            Console.WriteLine($"A(in): x = {x}");
        }

        public static void B(out int x)
        {
            x = 222;
            Console.WriteLine($"B(out): x = {x}");
        }
        public static void C(ref int x)
        {
            Console.WriteLine($"C(ref): initial x = {x}");
            x = x * 2;
        }

        public static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
