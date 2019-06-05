using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows;
            Console.Write("Enter number that you want to generate rows :");
            numberOfRows = Convert.ToInt32(Console.ReadLine());

            char alphabet = 'A';

            for (int i=0;i<=numberOfRows;i++)
            {

                for(int j=numberOfRows;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write(alphabet++);
                    
                }
                alphabet--;
                for (int l = 1; l < i;l++)
                {
                    Console.Write(--alphabet);

                }
                Console.Write("\n");
                alphabet = 'A';
            }


            Console.Read();

        }
    }
}
