using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int Begning, End, n, i, sum;



            Console.WriteLine("Please enter The Begning : ");

            Begning = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the End: ");

            End = int.Parse(Console.ReadLine());

            Console.WriteLine("The Perfect numbers within the given range : ");

            for (n = Begning; n <= End; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            Console.WriteLine("  ");
        }
    }
}
