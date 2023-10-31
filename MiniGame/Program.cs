using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    internal class Program
    {
        static int y = 10;
        static int x = 10;
        static bool gameOver = false;

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("@");
        }

        static void PlayerUpdate()
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
                if (x > 50) x = 50;
                Console.Clear();
            }
            else if (input.Key == ConsoleKey.S)
            {
                y++;
                if (y > 50) y = 50;
                Console.Clear();
            }
            else if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("MiniGame");
            Console.WriteLine();
            
            while (!gameOver)
            {
                PlayerDraw(x, y);
                PlayerUpdate();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
