using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    //Даны два угла треугольника.Является ли треугольник равнобедренным?
    class Program
    {
        static void Main(string[] args)
        {
            SByte value;
            value = -5;
            Console.WriteLine(Math.Abs(value));

            SByte a1 = 3, a2 = 1;
            Console.WriteLine(Math.Max(a1, a2));

            double n = 49;
            Console.WriteLine(Math.Sqrt(n));

            Decimal floatNumber;
            floatNumber = 11.234M;
            Console.WriteLine(Math.Truncate(floatNumber));

            int radius;
            Console.WriteLine("Введите радиус круга");
            radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(radius,2));

        }
    }
}