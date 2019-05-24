using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Given a number x, determine whether the given number is Armstrong number or not. A positive integer of n digits is called an Armstrong number of order n (order is number of digits) if.

             abcd... = pow(a,n) + pow(b,n) + pow(c,n) + pow(d,n) + .... 
             */

            int userNumber, tempNumber, numberDigits=0, numberSum=0, reminder=0;
            Console.Write("Enter number which you want to check is  Armstrong number :");
            userNumber = Convert.ToInt32(Console.ReadLine());
            tempNumber = userNumber;
            
            while(tempNumber>0)
            {
                numberDigits++;
                tempNumber /= 10;
            }

            tempNumber = userNumber;

            while(userNumber>0)
            {
                reminder = userNumber % 10;
                numberSum = numberSum + Convert.ToInt32(Math.Pow(reminder, numberDigits));
                userNumber /= 10;

            }

            if(tempNumber==numberSum)
            {
                Console.Write("given number is Armstrong number");
            }
            else
            {
                Console.Write("given number is not Armstrong number");
            }

            Console.Read();


        }

    }
}
