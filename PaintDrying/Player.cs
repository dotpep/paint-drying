using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintDrying
{
    class Player
    {
        public bool HasFlashlight { get; set; }
        public bool HasPaint { get; private set; }
        public ConsoleColor PaintColor { get; private set; }

        public Player()
        {
            HasFlashlight = false;
            HasPaint = false;
        }

        public void PickUpPaint(ConsoleColor color)
        {
            HasPaint = true;
            PaintColor = color;
        }
    }
}
