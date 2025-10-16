using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MathUtil
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0) 
            { 
                return double.NaN;
            }

            return (double)a / b;
        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            int result = 1; 

            for (int i = 1; i <= n; i++)
            {
                result *= i; 
            }

            return result;
        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        public static int Power(int baseNum, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
                
            return result;
        }

        public static double Average(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return double.NaN;
            }

            double total = 0;

            foreach (double num in numbers)
            {
                total += num;
            }
                
            return total / numbers.Length;
        }
    }
}

