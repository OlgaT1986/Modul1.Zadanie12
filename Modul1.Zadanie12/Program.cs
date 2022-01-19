using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод радиуса, вывод длины окр и площади
            Console.Write("Введите радиус окружности r=");
            double r = Convert.ToDouble(Console.ReadLine());
            double lenght = Circle.Getlenght(r);
            double square = Circle.GetSquare(r);
            Console.WriteLine($"Длина окружности Р ={lenght:0.00} \nПлощадь круга S ={square:0.00}");
            Console.WriteLine();
            // ввод координат центра окр
            Console.WriteLine("Введите координаты центра окружности x0, y0");
            Console.Write("Введите координату x0= ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y0= ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            // ввод координат любой точки
            Console.WriteLine("Введите координаты точки x, y ");
            Console.Write("Введите координату x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y= ");
            double y = Convert.ToDouble(Console.ReadLine());
            string GetAffiliation = Circle.GetAffiliation(x, y, x0, y0, r);
            // вывод данных о принадлежности введенной точки
            Console.WriteLine($"{GetAffiliation}");
            Console.ReadKey();
        }
    }
}

