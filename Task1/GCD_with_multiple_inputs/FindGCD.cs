using System;
using System.Diagnostics;
using System.Timers;

namespace GCD_with_multiple_inputs
{
    public class FindGCD
    {
        delegate int GCD(params int[] a);

        public static int binary_gcd(int a, int b)
        {
            if (a == 0) 
                return b;
            if (b == 0) 
                return a;
            if (a == 1 || b == 1) 
                return 1;
            if (a == b) 
                return a;
            if (a % 2 == 0 && b % 2 == 0) 
                return 2*binary_gcd(a / 2, b / 2);
            if (a % 2 == 0)
                return binary_gcd(a / 2, b); 
            if (b % 2 == 0)
                return binary_gcd(a, b / 2); 
            if (a > b)
                return binary_gcd((a - b) / 2, b); 
            if (a < b)
                return binary_gcd((b - a) / 2, a); 
            return -1; 
        }

        public static int MyBinaryGCD(params int[] a)
        {

            int temp = a[0]; 

            for (int i = 1; i < a.Length; i++) 
            {
                temp = binary_gcd(temp, a[i]); 
            }

            return temp; 
        }

        public static int gcd(int a, int b) 
        {
            return (b == 0) ? Math.Abs(a) : gcd(b, a % b); 
        }

        public static int MyGCD(params int[] a)
        {

            int temp = a[0];

            for (int i=1; i<a.Length; i++)
            {
                temp = gcd(temp, a[i]);
            }
            
            return temp;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Inputs are: 100, 50, 150");
            Stopwatch sw = Stopwatch.StartNew();
            GCD currentGCD = MyGCD;
            Console.Write("multiple input GCD: {0}\t\t", currentGCD(100, 50, 150));
            sw.Stop();
            Console.WriteLine(" Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
            sw = Stopwatch.StartNew();
            currentGCD = MyBinaryGCD;
            Console.Write("multiple input binary GCD: {0}\t\t", currentGCD(100, 50, 150));
            sw.Stop();
            Console.WriteLine(" Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);

        }
    }
}
