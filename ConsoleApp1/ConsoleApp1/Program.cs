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
            //게임 데이터 초기화
            int Map = 0;
            int MapMinx = 0;
            int MapMaxx = 15;
            int MapMiny = 0;
            int MapMaxy = 15;
                      
            //플레이어 초기위치
            int Px = 5;
            int Py = 10;
            Console.SetCursorPosition(Px, Py);
            Console.Write("P");

            //벽위치
            int wallx = 10;
            int wally = 10;
            char w = '@';
            Console.SetCursorPosition(wallx, wally);
            Console.Write(w);

            //박스위치
            int boxx = 10;
            int boxy = 5;
            char b = '#';
            Console.SetCursorPosition(boxx, boxy);
            Console.Write(b);
            //박스2 위치
            int boxx2 = 10;
            int boxy2 = 7;
            char b2 = '#';
            Console.SetCursorPosition(boxx2, boxy2);
            Console.Write(b2);

            //골인지점
            int goalx = 5;
            int goaly = 5;
            char g = '$';
            Console.SetCursorPosition(goalx, goaly);
            Console.Write(g);
            //골인지점2
            int goalx2 = 5;
            int goaly2 = 7;
            char g2 = '$';
            Console.SetCursorPosition(goalx2, goaly2);
            Console.Write(g2);

            //플레이어 이동
            while (true)
            {   
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    Px = Math.Max(MapMinx, Px - 1);
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    Py = Math.Max(MapMiny, Py - 1);
                }
                else if (input.Key == ConsoleKey.RightArrow)
                {
                    Px = Math.Min(MapMaxx, Px + 1);
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    Py = Math.Min(MapMaxy, Py + 1);
                }
                Console.Clear();

                //벽충돌 확인
                bool isSamePx = Px == wallx;
                bool isSamePy = Py == wally;
                bool isColl = isSamePx && isSamePy;

                //벽충돌 구현
                if (isColl)
                {
                    Console.SetCursorPosition(20, 20);
                    Console.Write("충돌함");
                }
                if (isColl && input.Key == ConsoleKey.LeftArrow)
                {
                    ++Px;
                }
                else if (isColl && input.Key == ConsoleKey.UpArrow)
                {
                    ++Py;
                }
                else if (isColl && input.Key == ConsoleKey.RightArrow)
                {
                    --Px;
                }
                else if (isColl && input.Key == ConsoleKey.DownArrow)
                {
                    --Py;
                }
                
                //박스충돌 확인
                bool isSameboxx = Px == boxx;
                bool isSameboxy = Py == boxy;
                bool isCollbox = isSameboxx && isSameboxy;
                //박스2충돌 확인
                bool isSameboxx2 = Px == boxx2;
                bool isSameboxy2 = Py == boxy2;
                bool isCollbox2 = isSameboxx2 && isSameboxy2;
                //박스간 충돌 확인
                bool isSameboxx3 = boxx == boxx2;
                bool isSameboxy3 = boxy == boxy2;
                bool isCollbox3 = isSameboxx3 && isSameboxy3;

                //박스충돌 구현    
                if (isCollbox && input.Key == ConsoleKey.LeftArrow)
                {
                    --boxx;
                }
                else if (isCollbox && input.Key == ConsoleKey.UpArrow)
                {
                    --boxy;
                }
                else if (isCollbox && input.Key == ConsoleKey.RightArrow)
                {
                    ++boxx;
                }
                else if (isCollbox && input.Key == ConsoleKey.DownArrow)
                {
                    ++boxy;
                }
                //박스2충돌 구현
                if (isCollbox2 && input.Key == ConsoleKey.LeftArrow)
                {
                    --boxx2;
                }
                else if (isCollbox2 && input.Key == ConsoleKey.UpArrow)
                {
                    --boxy2;
                }
                else if (isCollbox2 && input.Key == ConsoleKey.RightArrow)
                {
                    ++boxx2;
                }
                else if (isCollbox2 && input.Key == ConsoleKey.DownArrow)
                {
                    ++boxy2;
                }

                //박스간 충돌 구현
                if (isCollbox3 && input.Key == ConsoleKey.LeftArrow)
                {
                    --boxx2;
                }
                else if (isCollbox3 && input.Key == ConsoleKey.UpArrow)
                {
                    --boxy2;
                }
                else if (isCollbox3 && input.Key == ConsoleKey.RightArrow)
                {
                    ++boxx2;
                }
                else if (isCollbox3 && input.Key == ConsoleKey.DownArrow)
                {
                    ++boxy2;
                }

                //클리어 확인
                bool isSamegoalx = ((goalx == boxx) && (goalx2 == boxx2)) || ((goalx2 == boxx) && (goalx == boxx2));
                bool isSamegoaly = ((goaly == boxy) && (goalx2 == boxx2)) || ((goalx2 == boxx) && (goalx == boxx2)); 
                bool isCollgoal = isSamegoalx && isSamegoaly;

                //클리어 구현
                if(isCollgoal)
                {
                    Console.SetCursorPosition(25, 25);
                    Console.Write("게임을 클리어 했습니다.");
                }
                Console.SetCursorPosition(Px, Py);
                Console.Write("P");
                Console.SetCursorPosition(wallx, wally);
                Console.Write(w);
                Console.SetCursorPosition(boxx, boxy);
                Console.Write(b);
                Console.SetCursorPosition(boxx2, boxy2);
                Console.Write(b2);
                Console.SetCursorPosition(goalx, goaly);
                Console.Write(g);
                Console.SetCursorPosition(goalx2, goaly2);
                Console.Write(g2);
            }
        }
    }
}

