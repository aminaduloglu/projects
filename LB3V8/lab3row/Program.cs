using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3row
{
    //Вычислить H для n элементов ряда:
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {


            Console.WriteLine("введите 2 числа: a, y");
            double a = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите длину ряда");
            double n = Convert.ToDouble(Console.ReadLine());

            double h = 0;

           
            
            for (int i = 1; i <= n; i++)
            {
                h += y * (i - (i * 0.5)) + Math.Pow(Math.Cos(a), i) / Math.Sin(Factorial(i + 1));
            
            }

            Console.WriteLine("H :");
            Console.WriteLine(Math.Round(h, 2));

        }
    }
}
