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
        public RoomScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            WriteLine("Room scene is running!");
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
