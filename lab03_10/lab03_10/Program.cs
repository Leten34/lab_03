using System;

namespace lab03_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество выстрелов a:");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.Write("Введите координату x выстрела:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите координату y выстрела:");
                int y = int.Parse(Console.ReadLine());
                if ((x * x + y * y) <= 1)
                    b = b + 10;
                else if ((x * x + y * y) > 1 && (x * x + y * y) <= 4)
                    b = b + 5;
                else if ((x * x + y * y) > 4 && (x * x + y * y) <= 9)
                    b = b + 1;
                else
                    b = b + 0;
            }
            int c = 10 * a;
            double z = (double)b / (double)c;
            if (z > 0.9)
                Console.WriteLine("уровень: Снайпер.Очков: {0}", b);
            else if (z > 0.6 && z <= 0.9)
                Console.WriteLine("уровень: Просто стрелок. Очков: {0}", b);
            else if (z <= 0.6)
                Console.WriteLine("уровень: Мазила. Очков: {0}", b);
        }
    }
}
