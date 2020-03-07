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
    public partial class ControlScreen : UserControl
    {
        public ControlScreen()
        {
            InitializeComponent();
            discriptionLabel.Text = "Score the most points within the time limit by making it \n across " +
                "the field of flying bullets ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.SelectSound);
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
