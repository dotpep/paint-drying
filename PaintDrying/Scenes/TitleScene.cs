using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying.Scenes
{
    class TitleScene : Scene
    {
        private string TitleArt = @"
 ██▓███   ▄▄▄       ██▓ ███▄    █ ▄▄▄█████▓   ▓█████▄  ██▀███ ▓██   ██▓ ██▓ ███▄    █   ▄████ 
▓██░  ██▒▒████▄    ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒   ▒██▀ ██▌▓██ ▒ ██▒▒██  ██▒▓██▒ ██ ▀█   █  ██▒ ▀█▒
▓██░ ██▓▒▒██  ▀█▄  ▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░   ░██   █▌▓██ ░▄█ ▒ ▒██ ██░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░
▒██▄█▓▒ ▒░██▄▄▄▄██ ░██░▓██▒  ▐▌██▒░ ▓██▓ ░    ░▓█▄   ▌▒██▀▀█▄   ░ ▐██▓░░██░▓██▒  ▐▌██▒░▓█  ██▓
▒██▒ ░  ░ ▓█   ▓██▒░██░▒██░   ▓██░  ▒██▒ ░    ░▒████▓ ░██▓ ▒██▒ ░ ██▒▓░░██░▒██░   ▓██░░▒▓███▀▒
▒▓▒░ ░  ░ ▒▒   ▓▒█░░▓  ░ ▒░   ▒ ▒   ▒ ░░       ▒▒▓  ▒ ░ ▒▓ ░▒▓░  ██▒▒▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒ 
░▒ ░       ▒   ▒▒ ░ ▒ ░░ ░░   ░ ▒░    ░        ░ ▒  ▒   ░▒ ░ ▒░▓██ ░▒░  ▒ ░░ ░░   ░ ▒░  ░   ░ 
░░         ░   ▒    ▒ ░   ░   ░ ░   ░          ░ ░  ░   ░░   ░ ▒ ▒ ░░   ▒ ░   ░   ░ ░ ░ ░   ░ 
               ░  ░ ░           ░                ░       ░     ░ ░      ░           ░       ░ 
                                               ░               ░ ░                            
        ";

        public TitleScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            string prompt = $@"{TitleArt}
Welcome to the Pait Drying Simulator. What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Play", "Paint Color", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    PaintColorText();
                    break;
                case 2:
                    DisplayAboutInfo();
                    break;
                case 3:
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }

        private void RunFirstChoise()
        {
            WriteLine("Running First Choise!");

            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            Run();
        }


        private void PaintColorText()
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

                    WriteLine("Press any key to return to the menu.");
                    ReadKey(true);
                    Run();
                    break;
            }
            ResetColor();

            WriteLine("Press any key to keep Paint Text Color.");
            ReadKey(true);
            PaintColorText();
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("someting about About Game information.");

            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            Run();
        }
    }
}
