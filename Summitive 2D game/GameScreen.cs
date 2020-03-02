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
        //Player1 controls 
        Boolean upArrowDown, downArrowDown;

        //Player2 controls
        Boolean wKeyDown, sKeyDown;

        //TODO - Set up the random number generator for locations of enemies later on


        //Brushes to draw with
        SolidBrush whiteBrush = new SolidBrush(Color.White);


        //Create two lists for enemies coming from the right and the left
        List<Box> enemyLeft = new List<Box>();
        List<Box> enemyRight = new List<Box>();

        //TODO - Variables used to draw the enemies


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
            //TODO - Get game start values
            Box one = new Box(whiteBrush, 4, 100, 10, 2);
            enemyLeft.Add(one);

            Box two = new Box(whiteBrush, 500, 100, 10, 2);
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
            //TODO - update location of all boxes (Left list goes right & Right list goes left)
            foreach (Box left in enemyLeft)
            {
                left.FallRight();
            }

            foreach (Box right in enemyRight)
            {
                right.FallLeft();
            }


            //TODO - remove box if it has gone of screen (Either off the right side or the left side)


            //TODO - add new box if it is time


            //TODO - Move player1 Up and Down


            //TODO - Move player1 Up and Down


            //TODO - Check for collision between player1 and enemies


            //TODO - Check for collision between player2 and enemies


            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //TODO - Draw Enemies on the screen
            foreach (Box l in enemyLeft)
            {
                e.Graphics.FillRectangle(l.boxBrush, l.x, l.y, l.sizeX, l.sizeY);
            }

            foreach (Box r in enemyRight)
            {
                e.Graphics.FillRectangle(r.boxBrush, r.x, r.y, r.sizeX, r.sizeY);
            }

            //TODO - Draw Player1 to the screen
            e.Graphics.FillRectangle(player1.boxBrush, player1.x, player1.y, player1.sizeX, player1.sizeY);

            //TODO - Draw Player2 to the screen
            e.Graphics.FillRectangle(player2.boxBrush, player2.x, player2.y, player2.sizeX, player2.sizeY);
        }
    }
}
