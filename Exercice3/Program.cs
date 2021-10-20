using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.1
            Console.Write("Введите радиус: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите длину: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write($"Площадь конуса = {Math.Round((Math.PI * r * (r + l)),3)}");
            Console.WriteLine();

            //Задание 1.2
            int x = 14, y = 1, z = 5;
            Console.WriteLine(x += y - x++ * z);
            Console.WriteLine(z = --x - y * 5);
            Console.WriteLine(y /= x + 5 % z);
            Console.WriteLine(z = x++ + y * 5);
            Console.WriteLine(x = y - x++ * z);

        }
    }
}
