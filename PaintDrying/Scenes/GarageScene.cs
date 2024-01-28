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
        public GarageScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            WriteLine("Garage scene is running!");
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
