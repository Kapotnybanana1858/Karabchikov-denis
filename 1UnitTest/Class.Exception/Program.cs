using System;

namespace Exception
{
    class Program
    {

            static void Main(string[] args)
            {
                double a, b;
                try
                {
                    Console.WriteLine("Число 1: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Число 2: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (b == 0)
                        Console.WriteLine("Вы не можете делить на ноль ");
                    else
                        Console.WriteLine("Результат :" + " " + a / b);

                }
                catch
                {
                    Console.WriteLine("Неправильный ввод");
                }
                Console.WriteLine("Размер типа Integer:" + " " + sizeof(int));
                Console.WriteLine("Размер типо Float:" + " " + sizeof(float));
            }
        }
    }


