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
        public TitleScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            WriteLine("Title scene is running!");
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
