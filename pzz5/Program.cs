using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Запрашиваем номер задания
                Console.WriteLine("Выберете номер задания [1-5]");
                string exercise = Console.ReadLine();

                // чистим консоль для лучшей ориентации
                Console.Clear();

                // выполняем код, в зависимости от выбора задания
                switch (exercise)
                {
                    case "1":
                        Console.WriteLine("Задание №1");
                        for (int i = 20; i <= 80; i += 5)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Задание №2");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(Convert.ToChar('G' + i));
                        }
                        break;

                    case "3":
                        Console.WriteLine("Задание №3");
                        for (int m = 0; m < 6; m++)
                        {
                            for (int n = 0; n < 5; n++)
                            {
                                Console.Write('#');
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Задание №4");
                        for (int i = 6; i <= 100; i += 6)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Задание №5");
                        for (int i = 4, j = 40; j - i != 10; i++, j--)
                        {
                            Console.WriteLine($"i = {i}\tj = {j}");
                        }
                        break;

                    default:
                        Console.WriteLine("Некорректное значение"); //сообщаем об ошибке ввода
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}