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
            if (!MyGame.MyPlayer.HasFlashlight)
            {
                Clear();
                WriteLine("You enter your garage... but you can't see anything. There's nothing to do here yet/");
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyNavigationScene.Run();
            }
            else
            {
                Clear();

                string prompt = $@"{GarageArt} 
You pull out your flashlight and enter your garage. You find a couple paint options.";
                string[] options = { "Red", "Green", "Blue" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You pick up the red paint");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkRed);
                        break;
                    case 1:
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkGreen);
                        WriteLine("You pick up the green paint");
                        break;
                    case 2:
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkBlue);
                        WriteLine("You pick up the blue paint");
                        break;
                }
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyNavigationScene.Run();
            }
        }
    }
}
