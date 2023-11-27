//Тихоненко Сергей 20КИП2 лаб 3  вар 6
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void first()
        {
            const double p = 3.14;
            double x = 0, y = 0;
            double hMin = -4, hMax = 4, h = p / 3, hCur = hMin;

            while (hCur < hMax)
            {
                x = hCur;
                y = Math.Sin(x) * x + Math.Pow(Math.Cos(x), 2);
                Console.WriteLine("x = " + String.Format("{0:F2}", x) + "\ny = " + String.Format("{0:F2}", y) + "\n\n");
                hCur += h;
            }
        }

        static void second()
        {
            double y, x, xn, xk, h;

            Console.WriteLine("Введите xn  НАЧАЛО:");
            while (!double.TryParse(Console.ReadLine(), out xn)) ;

            Console.WriteLine("Введите xk  КОНЕЦ:");
            while (!double.TryParse(Console.ReadLine(), out xk) || xk < xn) ;

            Console.WriteLine("Введите h  ШАГ:");
            while (!double.TryParse(Console.ReadLine(), out h)) ;

            x = xn;
            while (x < xk)
            {
                y = Math.Pow(Math.Exp(-1), Math.Pow(-x, 2));
                Console.WriteLine(String.Format("{0:F2}", y));
                x += h;
            }
        }
        static void Main(string[] args)
        {

            while (true)
            {
                int a;
                Console.Write("\n\nВыберите пункт:\n1-А\n2-Б\n");
                while (!int.TryParse(Console.ReadLine(), out a)) ;

                switch (a)
                {
                    case 1:
                        {
                            first();
                            break;
                        }
                    case 2:
                        {
                            second();
                            break;
                        }
                }
            }
        }
    }
}