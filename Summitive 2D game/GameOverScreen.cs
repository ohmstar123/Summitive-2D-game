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
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();

            if (Form1.player1Score > Form1.player2Score)
            {
                winnerLabel.Text = "Player1 Wins";
            }
            else if (Form1.player1Score < Form1.player2Score)
            {
                winnerLabel.Text = "Player2 Wins";
            }
            else
            {
                winnerLabel.Text = "       It's A Tie";
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Begin the game again and reset the variables
            Form1.player1Score = 0;
            Form1.player2Score = 0;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Go back to the main screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
