using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Summitive_2D_game
{
    public partial class DifficultyScreen : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.SelectSound);

        public DifficultyScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            //Change the difficulty variable and bring up the game screen
            player.Play();

            Form1.difficulty = 11;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            //Change the difficulty variable and bring up the game screen
            player.Play();

            Form1.difficulty = 7;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //Change the difficulty variable and bring up the game screen
            player.Play();

            Form1.difficulty = 5;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void impossibleButton_Click(object sender, EventArgs e)
        {
            //Change the difficulty variable and bring up the game screen
            player.Play();

            Form1.difficulty = 2;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //Return back to the main screen
            player.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            ms.Focus();
        }
    }
}
