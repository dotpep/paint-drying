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
        public CreditsScene(Game myGame) : 
            base(myGame)
        {
        }

        public override void Run()
        {
            string prompt = @"There is some prompts about Credits.
=== Credits ===
> nothing added yet.

Would you like to play again?";

            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.Start();
                    break;
                case 1:
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }
    }
}
