﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying.Scenes
{
    class NavigationScene : Scene
    {
        public NavigationScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            string prompt = "You've got the exciting responsibilit of painting your room today. Where would you like to start?";
            string[] options = { "Garage", "Room" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    // Run the garage
                    //WriteLine("TODO: Move on to the garage...");
                    //ConsoleUtils.WaitForKeyPress();
                    MyGame.MyGarageScene.Run();
                    break;
                case 1:
                    // Run the room
                    //WriteLine("TODO: Move on to the room...");
                    //ConsoleUtils.WaitForKeyPress();
                    MyGame.MyRoomScene.Run();
                    break;
            }

        }
    }
}