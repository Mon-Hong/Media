using System;

namespace Heaven_stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, high, step, x, num = 0, width1 = 0;
            char letter;
            Console.Write(" input letter :");
            letter = char.Parse(Console.ReadLine());

            Console.Write(" input width :");
            width = int.Parse(Console.ReadLine());
            Console.Write(" input high :");
            high = int.Parse(Console.ReadLine());
            Console.Write(" input step :");
            step = int.Parse(Console.ReadLine());

            width1 = width;
            do
            {
                num++;
                for (int i = 1; i <= high; i++)
                {
                    for (int j = 1; j <= width; j++)
                    {

                        Console.Write(letter);

                    }

                    Console.WriteLine();
                }

                width = width1 + width;

            } while (num < step);

            Console.ReadLine();

        }
    }
}
