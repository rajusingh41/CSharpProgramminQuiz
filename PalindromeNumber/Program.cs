using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A palindrome number is a number that is same after reverse. For example 121, 34543, 343, 131, 48984 are the palindrome numbers.
             */
            int userNumber, reverseNumber=0,reminder, tempNumber;

            Console.Write("Enter number which you want to check is palindrome :");

            userNumber = Convert.ToInt32(Console.ReadLine());
            tempNumber = userNumber; // temprory save userNumber;

            // reverse userNumber 
            while(userNumber>0)
            {

                reminder = userNumber % 10;
                reverseNumber = (reverseNumber * 10) + reminder;
                userNumber /= 10;
            }

            // check userNumber and reverse Number are same or not if same than this is palindrome 
            if(tempNumber == reverseNumber)
            {
                Console.WriteLine("Your number is palindrome");
            }
            else
            {
                Console.WriteLine("Your number is not palindrome");
            }

            Console.Read();

        }
    }
}
