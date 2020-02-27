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


        //TODO - Create a counter variable

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }


        public void OnStart()
        {
            //TODO - Get game start values

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


            //TODO - Draw Player1 to the screen


            //TODO - Draw Player2 to the screen

        }
    }
}
