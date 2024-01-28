using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying.Scenes
{
    class GarageScene : Scene
    {
        private string GarageArt = @"+-----------------------------------------------------------+
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                       Garage Scene                        |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
+-----------------------------------------------------------+
";

        public GarageScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            string prompt = $@"{GarageArt} 
Garage Scene is activated?";
            string[] options = { "Garage1", "Garage2" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine("Garage 1 action runned...");
                    ConsoleUtils.WaitForKeyPress();
                    break;
                case 1:
                    WriteLine("Garage 2 action runned...");
                    ConsoleUtils.WaitForKeyPress();
                    break;
            }

        }
    }
}
