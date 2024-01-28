using static System.Console;

namespace PaintDrying
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Paint Drying";
            CursorVisible = false;
            try
            {
                WindowWidth = 130;
                WindowHeight = 35;
            }
            catch
            {
                WriteLine("Cannot create a big enough console window.");
                ConsoleUtils.WaitForKeyPress();
            }

            Game myGame = new Game();
            myGame.Start();
        }
    }
}