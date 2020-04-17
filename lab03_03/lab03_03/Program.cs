using System;

namespace lab03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год a:");
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
                if (a % 100 == 0)
                    if (a % 400 == 0)
                        Console.WriteLine("Да");
                    else
                        Console.WriteLine("Нет");
                else
                    Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

        }
    }
}
