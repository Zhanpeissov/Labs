using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
        class Program
        {
            static void Main(string[] args)
            {
                Snake snake = new Snake();
                Wall wall = new Wall();
                while (true)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    if (pressedKey.Key == ConsoleKey.UpArrow)
                        snake.move(0, -1);
                    if (pressedKey.Key == ConsoleKey.DownArrow)
                        snake.move(0, 1);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                        snake.move(-1, 0);
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                        snake.move(1, 0);
                snake.Draw();
                }
            }
        }
    
}

