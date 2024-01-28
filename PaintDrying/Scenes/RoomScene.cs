using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
Well, here's your room. The walll is pretty boring. What do tou want to do?";
            string[] options = { "Go Someplace Else", "Look Under the Desk", "Paint the Wall"};
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    InteractWithDesk();
                    break;
                case 2:
                    InteractWithWall();
                    break;
            }

        }

        private void InteractWithDesk()
        {
            if (!MyGame.MyPlayer.HasFlashlight)
            {
                WriteLine("Ahh, my flashlight. This could be handy. I'll take it with me.");
                MyGame.MyPlayer.HasFlashlight = true;
            }
            else
            {
                WriteLine("It's empty.");
            }
            ConsoleUtils.WaitForKeyPress();
            Run();
        }

        private void InteractWithWall()
        {
            if (!MyGame.MyPlayer.HasPaint)
            {
                WriteLine("I don't have the paint yet. I can't paint without paint, right?");
                ConsoleUtils.WaitForKeyPress();
                Run();
            }
            else
            {
                Clear();
                BackgroundColor = MyGame.MyPlayer.PaintColor;
                ForegroundColor = ConsoleColor.White;
                WriteLine(RoomArt);
                ResetColor();
                WriteLine("Beautiful!");
                WriteLine("Chores done, back to playing minesweeper...");
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();
            }
        }
    }
}
