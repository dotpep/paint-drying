using System;
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
            WriteLine("Navigation scene is running!");
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
