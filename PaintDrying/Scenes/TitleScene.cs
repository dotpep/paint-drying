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
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("someting about About Game information.");

            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            Run();

            //MyGame.Start();
            //ConsoleUtils.ExitToGivenScene(TitleScene);
        }
    }
}
