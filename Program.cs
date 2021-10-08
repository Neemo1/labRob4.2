using System;

namespace labRob4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
        m1: Console.WriteLine("Введите для точки М" + " координату по Х = ");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine("Введите для точки М" + " координату по Y = ");
            float y = float.Parse((Console.ReadLine()));

            if (y < 0)
            {
                if (y + x * x < 2)
                {
                    if (x >= 0) N = 2;
                    else N = 1;
                }
                else {
                    if (x >= 0) N = 4;
                    else N = 3;
                }
            }
            else {
                if (x >= 0) N = 3;
                else N = 2;
            
            }
            Console.WriteLine('\t' + "      РЕЗУЛЬТАТ:");
            Console.WriteLine("    Точка М(" + x + ";" + y + ")" + " Лежит в области с N = " + N);
            Console.WriteLine('\n' + "Для повторного ввода" + "набрать любую клавишу." + '\n' + "Для завершения програмы нажмите Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m1;

        }
    }
}
