using System;
using System.Globalization;

namespace ReduceToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a number greater than 0: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Reduce(input));
            
        }

        public static int Reduce(int input)
        {
            int steps = 0;
            if (input < 0)
            {
                Console.WriteLine($"{input} is less than zero");
            }

            for (int i = 1; i < Math.Pow(10, 6); i++)
            {
                if (input % 2 == 0)
                {
                    input /= 2;
                }
                else
                {
                    input -= 1;
                }

                steps = i;

                if (input == 0)
                {
                    return steps;
                }
            }

            return steps;

        }
    }
}

//