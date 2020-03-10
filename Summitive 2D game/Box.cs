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

        public PointF[] playerPoints = new PointF[3];

        public Box (SolidBrush _boxBrush, int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            boxBrush = _boxBrush;

            playerPoints[0] = new PointF(10 + x, 0 + y);
            playerPoints[1] = new PointF(0 + x, 20 + y);
            playerPoints[2] = new PointF(20 + x, 20 + y);
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
            //Movement of the players depending what button is pressed
            if (direction == "Up")
            {
                y = y - 3;
                //Form1.Y = Form1.Y - 3;
            }

            if (direction == "Down")
            {
                y = y + 3;
            }

            playerPoints[0] = new PointF(10 + x, 0 + y);
            playerPoints[1] = new PointF(0 + x, 20 + y);
            playerPoints[2] = new PointF(20 + x, 20 + y);
        }

        //Need a method for collision between the players and the enemies
        public Boolean Collision1(Box player1)
        {
            Rectangle player1Rec = new Rectangle(player1.x, player1.y, player1.sizeX, player1.sizeY);
            Rectangle enemyRec = new Rectangle(x, y, sizeX, sizeY);

            if (player1Rec.IntersectsWith(enemyRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Collision2(Box player2)
        {
            Rectangle player2Rec = new Rectangle(player2.x, player2.y, player2.sizeX, player2.sizeY);
            Rectangle enemyRec = new Rectangle(x, y, sizeX, sizeY);

            if (player2Rec.IntersectsWith(enemyRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
