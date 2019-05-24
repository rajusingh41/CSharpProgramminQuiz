using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNunber, sum = 0, reminder = 0,tempNumber;
            Console.Write("Enter number which you want to some :");
            userNunber = Convert.ToInt32(Console.ReadLine());
            tempNumber = userNunber;
            while (userNunber>0)
            {
                reminder = userNunber % 10;
                sum = sum + reminder;
                userNunber /= 10;
            }
            Console.WriteLine("Sum of given number ({0}) is {1}", tempNumber, sum);
            Console.Read();
        }
    }
}
