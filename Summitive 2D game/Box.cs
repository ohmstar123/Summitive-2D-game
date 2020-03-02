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
        public SolidBrush boxBrush = new SolidBrush(Color.White);
        public int x, y, sizeX, sizeY;

        public Box (SolidBrush _boxBrush, int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            boxBrush = _boxBrush;
        }

        public void FallRight()
        {
            //Make the enemies fall right
            x = x + 3;

        }

        public void FallLeft()
        {
            //Make the enemies fall left
            x = x - 3;
        }

        public void Move(string direction)
        {
            //TODO - Movement of the players depending what button is pressed
        }

        //TODO - Need a method for collision between the players and the enemies




    }
}
