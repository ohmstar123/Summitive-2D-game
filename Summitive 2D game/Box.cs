using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Summitive_2D_game
{
    class Box
    {
        public SolidBrush boxBrush;
        public int x, y, sizeX, sizeY;

        public Box (SolidBrush _boxBrush, int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            boxBrush = _boxBrush;
        }

        public void Fall()
        {
            //TODO - Make the enemies fall either right or left

        }

        public void Move(string direction)
        {
            //TODO - Movement of the players depending what button is pressed
        }

        //TODO - Need a method for collision between the players and the enemies




    }
}
