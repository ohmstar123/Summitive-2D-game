﻿using System;
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
    public partial class MainScreen : UserControl
    {
        
        public MainScreen()
        {
            InitializeComponent();
            this.Location = new Point((this.Width - this.Width) / 2, (this.Height - this.Height) / 2);
        }
       
        private void playButton_Click(object sender, EventArgs e)
        {
            //Begin the GameScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - f.Width) / 2, (f.Height - f.Height) / 2);
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            //TODO - Add a controls screen 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //End the application
            Application.Exit();
        }
    }
}
