using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying.Scenes
{
    class CreditsScene : Scene
    {
        public CreditsScene(Game myGame) : base(myGame)
        {
        }

        public override void Run()
        {
            WriteLine("Credits scene is running!");
            ConsoleUtils.WaitForKeyPress();
        }
    }
}
