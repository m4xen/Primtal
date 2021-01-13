using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primetalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 1;

            if (IsPrime(inputNum))
            {
                Console.WriteLine(inputNum + " is a prime number");
            }
            else
            {
                Console.WriteLine(inputNum + " is not a prime number");
            }
            
            Console.WriteLine("\n\n Press any key to exit \n");
            Console.ReadKey();
        }

        private static bool IsPrime(int inputNum)
        {
            if (inputNum <= 1) return false;
            if (inputNum == 2) return true;
            if (inputNum % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(inputNum));

            for (int i = 3; i <= boundary; i += 2)
                if (inputNum % i == 0)
                    return false;

            return true;
        }
    }
}
