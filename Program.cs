using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1 ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int num2=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = num1; i <= num2; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    if (i % j == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum =0 ;
                }
                else
                {
                    sum = 0;

                }

            }













        }
    }
}
