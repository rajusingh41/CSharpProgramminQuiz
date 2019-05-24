using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwipeTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // swipe two number without thired variable 
            int n1 , n2 ;
            Console.Write("Enter first number :  ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :  ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Original Number n1= {0} and n2= {1}", n1, n2);

            // swipe number 

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("Swipe Number n1= {0} and n2= {1}", n1, n2);
            Console.Read();
        }
    }
}
