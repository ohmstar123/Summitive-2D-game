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
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Go back to the main screen and reset score variables
            Form1.player1Score = 0;
            Form1.player2Score = 0;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Focus();
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
        }
    }
}
