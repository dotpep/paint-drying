using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using PaintDrying.Scenes;

namespace PaintDrying
{
    class Game
    {
        public Player MyPlayer;

        public TitleScene MyTitleScene;
        public CreditsScene MyCreditsScene;
        public NavigationScene MyNavigationScene;
        public GarageScene MyGarageScene;
        public RoomScene MyRoomScene;

        public Game()
        {
            MyPlayer = new Player();
            MyTitleScene = new TitleScene(this);
            MyCreditsScene = new CreditsScene(this);
            MyNavigationScene = new NavigationScene(this);
            MyGarageScene = new GarageScene(this);
            MyRoomScene = new RoomScene(this);
        }

        public void Start()
        {
            // Scene.Run
            MyTitleScene.Run();
        }

        public void SubStart()
        {
            Title = "Paint Drying - The Game!";
            RunMainMenu();

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }

        private void RunMainMenu()
        {
            string prompt = @"
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
Welcome to the Pait Drying Simulator. What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Play", "Paint Color", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoise();
                    break;
                case 1:
                    PaintColoredText();
                    break;
                case 2:
                    DisplayAboutInfo();
                    break;
                case 3:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("someting about About Game information.");

            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void RunFirstChoise()
        {
            WriteLine("Running First Choise!");

            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void PaintColoredText()
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
                    RunMainMenu();
                    break;
            }
            ResetColor();

            WriteLine("Press any key to keep Paint Text Color.");
            ReadKey(true);
            PaintColoredText();
        }
    }
}
