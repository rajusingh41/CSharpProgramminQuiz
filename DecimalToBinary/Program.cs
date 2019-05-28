using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber, i;
            int[] arr = new int[10];

            Console.Write("Enter number which you want to convert to binary:");

            userNumber = Convert.ToInt32(Console.ReadLine());
             for(i=0;userNumber>0;i++)
            {
                arr[i] = userNumber % 2;
                userNumber /= 2;
            }
            // wirte binary 

            Console.Write("Binary Number is :");


            for(i=i-1;i>= 0;i--)
            {
                Console.Write(arr[i]);
            }
            Console.Read();
        }
    }
}
