using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Fibonacci Series 

            //int n1 = 0, n2 = 1, n3, userNumber;
            //Console.Write("Please enter number : ");
            //userNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write(n1 + " " + n2 + " "); // print first two number 0, 1 

            //for(int i=2;i<userNumber;i++)
            //{
            //    n3 = n1 + n2;
            //    Console.Write(n3 + " ");
            //    n1 = n2;
            //    n2 = n3;
            //}
            #endregion

            #region 2. Swipe Two Number 
            // swipe two number without thired variable 
            int n1 = 10, n2 = 20;

            Console.WriteLine("Original Number n1= {0} and n2= {1}", n1, n2);

            // swipe number 

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("Swipe Number n1= {0} and n2= {1}", n1, n2);
            #endregion 



            Console.Read();
        }
    }
}
