using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //콘솔창 초기화
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Sokoban";
            Console.CursorVisible = false;
            Console.Clear();

            //플레이어 초기위치
            int x = 5;
            int y = 10;
            Console.SetCursorPosition(x, y);
            Console.Write("P");

            //플레이어 이동
            while (true)
            {   //키보드 입력
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    --x;
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    --y;
                }
                else if (input.Key == ConsoleKey.RightArrow)
                {
                    ++x;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    ++y;
                }
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("P");
                Thread.Sleep(1);

            }
        }
    }
}
