using System;

namespace lab03_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.Write("Введите k:");
            double k = double.Parse(Console.ReadLine());
            Console.Write("Введите m:");
            double m = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                 s = s + i;
            }
            Console.WriteLine("Сумма: {0}", s);
        }
    }
}
