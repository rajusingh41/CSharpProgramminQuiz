using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, userNumber;
            Console.Write("Please enter number : ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); // print first two number 0, 1 

            for (int i = 2; i < userNumber; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.Read();
        }
    }
}
