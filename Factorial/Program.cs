using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber, factorialNumber = 1;
            Console.Write("Enter your number :");
            userNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= userNumber; i++)
            {
                factorialNumber = factorialNumber * i;
            }

            Console.WriteLine("Factorial of {0} is {1}", userNumber, factorialNumber);

            Console.Read();

        }
    }
}
