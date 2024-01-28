using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using PaintDrying.Scenes;

namespace PaintDrying
{
    class Game
    {
        public Player MyPlayer;

        public TitleScene MyTitleScene;
        public CreditsScene MyCreditsScene;
        public NavigationScene MyNavigationScene;
        public GarageScene MyGarageScene;
        public RoomScene MyRoomScene;
        public TabletScene MyTabletScene;

        public Game()
        {
            MyPlayer = new Player();
            MyTitleScene = new TitleScene(this);
            MyCreditsScene = new CreditsScene(this);
            MyNavigationScene = new NavigationScene(this);
            MyGarageScene = new GarageScene(this);
            MyRoomScene = new RoomScene(this);
            MyTabletScene = new TabletScene(this);
        }

        public void Start()
        {
            // Scene.Run
            MyTitleScene.Run();
        }
    }
}
