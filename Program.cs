using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionTest
{
    class TriangleSquare
    {
        static void Main(string[] args)
        {
            double a, b=0; // катеты прямоугольного треугольника для вычисления площади
            double s=0; // вычисленная площадь треугольника
            bool flag = false; // флаг для определения варианта завершения программы
            Console.WriteLine("Программа для вычисления площади прямоугольного треугольника. \n Пожалуйста, введите значения сторон.");
            Console.Write("a= ");
            if ((!double.TryParse(Console.ReadLine(), out a)) || (a <= 0))
            {
                Console.WriteLine("Введенное значение для стороны a некорректно! Значение должно быть числом и больше нуля.");
                flag = true;
            }
            if (!flag)
            {
                Console.Write("b= ");
                if ((!double.TryParse(Console.ReadLine(), out b)) || (b <= 0)) // парсим значение, если хотя бы одно из условий не выполняется, выставляем флаг для завершения программы
                {
                    Console.WriteLine("Введенное значение для стороны b некорректно!");
                    flag = true;
                }
                s = 0.5*a*b; // вычисляем значение площади
            }
            if (flag)
                Console.WriteLine("Невозможно вычислить площадь треугольника с введенными значениями сторон. Значение должно быть числом и быть больше нуля.");
            else
                Console.WriteLine("Площадь треугольника со сторонами a= {0} и b= {1} равна {2} .",a,b,s);
            
            Console.ReadKey();
        }
    }
}
