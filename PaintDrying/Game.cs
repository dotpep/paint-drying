using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;


namespace PaintDrying
{
    internal class Game
    {
        public void Start()
        {
            //WriteLine("The game is starting.");
            //ConsoleKeyInfo keyPressed = ReadKey();
            //if (keyPressed.Key == ConsoleKey.Enter)
            //{
            //    WriteLine("Enter pressed");
            //}
            //else if (keyPressed.Key == ConsoleKey.UpArrow)
            //{
            //    WriteLine("UpArrow pressed");
            //}
            //else
            //{
            //    WriteLine("Not enter");
            //}

            string prompt = "Welcome to the Pait Drying Simulator. What would you like to do?";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
