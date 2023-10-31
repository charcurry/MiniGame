using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MiniGame");
            Console.WriteLine();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int y = 10;
            int x = 10;
            bool gameOver = false;
            while (!gameOver)
            {
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.W)
                {
                    y--;
                    if (y < 0) y = 0;
                    Console.Clear();
                }
                else if (input.Key == ConsoleKey.A) 
                { 
                    x--;
                    if (x < 0) x = 0;
                    Console.Clear();
                }
                else if (input.Key == ConsoleKey.D)
                {
                    x++;
                    Console.Clear();
                }
                else if (input.Key == ConsoleKey.S)
                {
                    y++;
                    if (y > 100) y = 100;
                    Console.Clear();
                }

                Console.SetCursorPosition(x, y);
                // ..
                // ..
                Console.WriteLine("@");
                // ..
                // ..
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
