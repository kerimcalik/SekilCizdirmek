using System;
using System.Threading;

namespace SekilCizdirmek
{
    class Program
    {
        static void Cati()
        {
            Console.SetCursorPosition(50, 5);

            for (int i = 50; i <= 150; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(i, 5);
                //Thread.Sleep(20);
            }

            int top = 5;
            for (int i = 50; i >= 40; i--)
            {
                top++;
                Console.Write("*");
                Console.SetCursorPosition(i, top);
                //Thread.Sleep(20);
            }

            top = 5;
            for (int i = 150; i <= 160; i++)
            {
                top++;
                Console.Write("*");
                Console.SetCursorPosition(i, top);
                //Thread.Sleep(20);
            }

            top++;
            for (int i = 40; i <= 160; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(i, top);
            }
        }

        static void Bina()
        {
            for (int i = 17; i <= 46; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(60, i);
            }

            for (int i = 17; i <= 46; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(140, i);
            }

            for (int i = 60; i <= 140; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(i, 46);
            }
        }

        static void Kapi()
        {
            for (int i = 95; i <= 105; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(i, 36);
            }

            int[] leftPositionArr = new int[] { 95, 105 };

            foreach (var item in leftPositionArr)
            {
                for (int i = 36; i <= 46; i++)
                {
                    Console.Write("*");
                    Console.SetCursorPosition(item, i);
                }
            }
        }

        static void Main(string[] args)
        {
            Cati();
            Bina();
            Kapi();

            Console.SetCursorPosition(0, 0);
            Console.Read();
        }
    }
}
