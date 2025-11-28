namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Sokoban";
            Console.CursorVisible = false;
            Console.Clear();
        }
    }
}
