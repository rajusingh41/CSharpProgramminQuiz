using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, reverseNumber=0,reminder;
            Console.Write("Enter number which you want to revers : ");
             number = Convert.ToInt32(Console.ReadLine());

            while(number>0)
            {
                 reminder = number % 10;
                reverseNumber = (reverseNumber * 10) + reminder;
                number /= 10;
            }
            Console.Write("Reverse number : {0}", reverseNumber);

            Console.Read();

        }
    }
}
