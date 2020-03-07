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
    public partial class MainScreen : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.SelectSound);
        
        
        public MainScreen()
        {
            InitializeComponent();
            
        }
       
        private void playButton_Click(object sender, EventArgs e)
        {
            //Begin the GameScreen
            player.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            DifficultyScreen ds = new DifficultyScreen();
            f.Controls.Add(ds);
            ds.Location = new Point((f.Width - ds.Width) / 2, (f.Height - ds.Height) / 2);
            ds.Focus();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            //Add a controls screen 
            player.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            ControlScreen cs = new ControlScreen();
            f.Controls.Add(cs);
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);
            cs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //End the application
            Application.Exit();
        }
    }
}
