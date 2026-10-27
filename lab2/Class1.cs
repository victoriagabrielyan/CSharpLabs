using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    internal class Class1
    {
        public static int ToMultiplicate(int x, int N = 2)
        {
            return x * N;
        }

        public static double ToMultiplicate(double x, int N = 2)
        {
            return x * N;
        }

        public static string ToMultiplicate(string x, int N = 2)
        {
            string result = "";
            for (int i = 0; i < N; i++)
            {
                result += x;
            }
            return result;
        }
    }
}
