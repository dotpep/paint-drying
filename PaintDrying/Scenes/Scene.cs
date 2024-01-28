using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintDrying.Scenes
{
    class Scene
    {
        protected Game MyGame;

        public Scene(Game myGame)
        {
            MyGame = myGame;
        }

        virtual public void Run()
        {

        }
    }
}
