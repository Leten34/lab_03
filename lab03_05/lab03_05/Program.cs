using System;

namespace lab03_05
{
    class Program
    {
        static int Main(string[] args)
        {
            double x;
            double y;
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine(y);
                x = x + 0.01;
            }
            while (x <= x2);
            return 0;
        }
    }
    
}
