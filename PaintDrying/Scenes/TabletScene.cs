using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying.Scenes
{
    class TabletScene : Scene
    {
        public TabletScene(Game myGame) : 
            base(myGame)
        {
        }
        public override void Run()
        {
            string prompt = "What color paint would you like to watch dry?";
            string[] options = { "Red", "Green", "Blue", "Yellow", "Exit" };

            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            BackgroundColor = ConsoleColor.White;
            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nHere is some riveting red paint drying for you...");
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nHere is some riveting green paint drying for you...");
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\nHere is some riveting blue paint drying for you...");
                    break;
                case 3:
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\nHere is some riveting yellow paint drying for you...");
                    break;
                case 4:
                    ResetColor();

                    MyGame.MyNavigationScene.Run();
                    break;
            }
            ResetColor();

            WriteLine("Press any key to keep Paint Text Color.");
            ReadKey(true);
            Run();
        }
    }
}
