using System;


namespace ConsoleApplication1
{
    public class FibonacciExample
    {
        public FibonacciExample()
        {
            
            for (int i = -8; i <= 8; i++)
            {
                int result = FibonacciRecursive(i);
                Console.Write(result + " ");
            }
            Console.WriteLine();
            
            for (int i = -8; i <= 8; i++)
            {
                int resultn = Fibonacci(i);
                Console.Write(resultn + " ");
            }
            //int resultn = Fibonaccix(-3);
        }
        //-8, -7, -6,-5, -4,-3, -2,-1, 0, 1, 2, 3, 4, 5, 6,7, 8
        //-21,13, −8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8,13,21

        public int Fibonacci(int n)
        {
            int current = 0;
            int previous = 1;

            int sign = 1;
            if (n < 0)
            {
                sign = (int)Math.Pow(-1, (n + 1));
            }

            n = Math.Abs(n);

            for (int k = 0; k < n; k++)
            {
                current = current + previous;//take the current subtract the previous
                previous = current - previous;//maintain previous number by subtracting previous from new current
            }

            return current * sign;
        }

        public int Fibonaccix(int n)
        {
            int current = 1;
            int previous = 0;

            int sign = 1;
            if (n < 0)
            {
                sign = (int)Math.Pow(-1, (n + 1));
            }

            n = Math.Abs(n);

            for (int k = 2; k <= n; k++)
            {
                current = current + previous;
                previous = current - previous;
            }


            return current * sign;
        }

        public int FibonacciRecursive(int n)
        {
            //base case we start with 0 and 1 then added up
            if (n == 0 || n == 1)
            {
                return n;
            }

            if (n >= 0)
            {
                // Positive Fn = Fn − 1 + Fn − 2
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
            else
            {
                //Negative Fn − 2 = Fn − Fn − 1 -> f(-n) = (-1)^(n+1) * f(n)
                return (int)Math.Pow(-1,(n + 1)) * FibonacciRecursive(Math.Abs(n));
            }
        }





    }
}
