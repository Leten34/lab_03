using System;

namespace lab03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            temp = a;
            do
            {
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;

            }
            while (temp <= b);
            Console.Write("НОД ={0} ", b);

        }
    }
}
