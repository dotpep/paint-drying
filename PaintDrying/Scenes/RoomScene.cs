using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying.Scenes
{
    class RoomScene : Scene
    {
        private string RoomArt = @"+-----------------------------------------------------------+
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                       Room Scene                          |
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

        public RoomScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            string prompt = $@"{RoomArt} 
Room Scene is activated?";
            string[] options = { "Room1", "Room2" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine("Room 1 action runned...");
                    ConsoleUtils.WaitForKeyPress();
                    break;
                case 1:
                    WriteLine("Room 2 action runned...");
                    ConsoleUtils.WaitForKeyPress();
                    break;
            }

        }
    }
}
