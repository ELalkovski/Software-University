using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IGRA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 20;
            Console.BufferHeight = 20;

            Console.WindowWidth = 40;
            Console.BufferWidth = 40;

            Console.CursorVisible = false;

            for (int i = 0; i < 1;)
            {
                int lastLine = 19;
                int lastLineMidCol = (39 / 2) - 1;

                Console.SetCursorPosition(lastLineMidCol, lastLine);
                Console.Write("^");
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();

                    switch (pressedKey.Key)
                    {
                        case ConsoleKey.LeftArrow: lastLineMidCol--; break;
                        case ConsoleKey.RightArrow: lastLineMidCol++; break;
                    }
                }
                
            }
            
            

        }
    }
}
