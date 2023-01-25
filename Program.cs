using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d, sum;
            double sum1;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine()); //лишнее
            Console.WriteLine("Введите d");
            d = Convert.ToDouble(Console.ReadLine());
            sum = Math.Sqrt(Math.Pow(a - b, 2));
            sum1 = Math.Sqrt(Math.Pow(c - d, 2));
            Console.WriteLine("расстояние между точками а и b=" + " " + sum);
            Console.WriteLine("расстояние между точками c и d=" + " " + sum1);
        }
    }
}
