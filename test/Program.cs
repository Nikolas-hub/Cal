using System;

namespace test
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Коля писюн");
                Console.WriteLine("Выберите операцию:\n1. Сложение\n2. Вычитание\n3. Деление\n4. Выход");
                string number = Console.ReadLine();
                Console.Clear();

                if (number == "1")
                {
                    try
                    {
                        Console.WriteLine("Введите число а:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Введите число b:");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine($"Ответ: {a + b}");
                        Console.ReadKey();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Вводите только число!\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                }
                else if (number == "2")
                {
                    try
                    {
                        Console.WriteLine("Введите число а:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Введите число b:");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine($"Ответ: {a - b}");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Вводите только число!\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                }
                else if (number == "3")
                {
                    try
                    {
                        Console.WriteLine("Введите число а:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Введите число b:");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine($"Ответ: {Math.Round(a / b, 3)}");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Вводите только число!\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                    }
                }
                else if (number == "4") break;
                else
                {
                    Console.WriteLine("Выберите существующую операцию!\nНажмите любую клавишу для продолжения");
                    Console.ReadKey();
                }
            }

        }
    }

}