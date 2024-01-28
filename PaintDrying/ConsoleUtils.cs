using PaintDrying.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PaintDrying
{
    public static class ConsoleUtils
    {
        public static void WaitForKeyPress()
        {
            WriteLine("(Press any key to continue.)");
            ReadKey(true);
        }
        public static void QuitConsole()
        {
            WriteLine("(Press any key to exit.)");
            ReadKey(true);
            Environment.Exit(0);
        }
        //public static void ExitToGivenScene(Scene scene)
        //{
        //    WriteLine($"(Press any key to return to the {scene.GetType().Name}.)");
        //    ReadKey(true);
        //    scene.Run();
        //}

        // TODO: make it all independency Scene classes public to access it
        //public static void ExitToGivenScene(Scene targetScene)
        //{
        //    targetScene.Run();
        //}
    }
}

