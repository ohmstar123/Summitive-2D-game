using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summitive_2D_game
{
    public partial class GameScreen : UserControl
    {
        //Player2 controls 
        Boolean upArrowDown, downArrowDown;

        //Player1 controls
        Boolean wKeyDown, sKeyDown;

        //TODO - Set up the random number generator for locations of enemies later on
        Random randgen = new Random();

        //Brushes to draw with
        SolidBrush whiteBrush = new SolidBrush(Color.White);


        //Create two lists for enemies coming from the right and the left
        List<Box> enemyLeft = new List<Box>();
        List<Box> enemyRight = new List<Box>();

        //TODO - Variables used to draw the enemies
        int randomYLeft;
        int randomYRight;

        //Player 1 values
        Box player1;


        //Player 2 values
        Box player2;

        //Create a counter variable
        int counter;
        

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }


        public void OnStart()
        {
            //Get game start values
            randomYRight = randgen.Next(1, 391);
            randomYLeft = randgen.Next(1, 391);

            Box one = new Box(whiteBrush, 4, randomYLeft, 10, 2);
            enemyLeft.Add(one);

            Box two = new Box(whiteBrush, this.Width, randomYRight, 10, 2);
            enemyRight.Add(two);

            player1 = new Box(whiteBrush, 200, 400, 4, 10);
            player2 = new Box(whiteBrush, 600, 400, 4, 10);

       

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //Create a random y value for the enemies
            randomYLeft = randgen.Next(1, 391);
            randomYRight = randgen.Next(1, 391);

            //update location of all boxes (Left list goes right & Right list goes left)
            foreach (Box left in enemyLeft)
            {
                left.FallRight();
            }

            foreach (Box right in enemyRight)
            {
                right.FallLeft();
            }


            //remove box if it has gone of screen (Either off the right side or the left side)
            if (enemyRight[0].x < -enemyRight[0].sizeX)
            {
                enemyRight.RemoveAt(0);
            }

            if (enemyLeft[0].x > this.Width)
            {
                enemyLeft.RemoveAt(0);
            }

            //add new box if it is time
            counter++;
            if (counter == 5)
            {


                Box Left = new Box(whiteBrush, 4, randomYLeft, 10, 2);
                enemyLeft.Add(Left);

                Box Right = new Box(whiteBrush, this.Width, randomYRight, 10, 2);
                enemyRight.Add(Right);

                counter = 0;
            }

            //Move player1 Up and Down
            if (upArrowDown)
            {
                player2.Move("Up");
            }

            if (downArrowDown)
            {
                player2.Move("Down");
            }

            //Move player2 Up and Down
            if (wKeyDown)
            {
                player1.Move("Up");
            }

            if (sKeyDown)
            {
                player1.Move("Down");
            }


            //Check for collision between player1 and enemies
            foreach (Box enemy1 in enemyLeft.Union(enemyRight))
            {
                if (enemy1.Collision1(player1))
                {
                    player1 = new Box(whiteBrush, 200, 400, 4, 10);
                }
            }


            //Check for collision between player2 and enemies
            foreach (Box enemy2 in enemyRight.Union(enemyLeft))
            {
                if (enemy2.Collision2(player2))
                {
                    player2 = new Box(whiteBrush, 600, 400, 4, 10);
                }
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Draw Enemies on the screen
            foreach (Box l in enemyLeft)
            {
                e.Graphics.FillRectangle(l.boxBrush, l.x, l.y, l.sizeX, l.sizeY);
            }

            foreach (Box r in enemyRight)
            {
                e.Graphics.FillRectangle(r.boxBrush, r.x, r.y, r.sizeX, r.sizeY);
            }

            //Draw Player1 to the screen
            
            e.Graphics.FillRectangle(player1.boxBrush, player1.x, player1.y, player1.sizeX, player1.sizeY);
                
            
            //Draw Player2 to the screen
            e.Graphics.FillRectangle(player2.boxBrush, player2.x, player2.y, player2.sizeX, player2.sizeY);
        }
    }
}
