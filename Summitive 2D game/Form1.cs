using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summitive_2D_game
{
    public partial class Form1 : Form
    {
        public static int player1Score;
        public static int player2Score;
        public static Boolean escapeDown;
        public static Boolean counter;

        public Form1()
        {
            InitializeComponent();



            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((ms.Width - ms.Width) / 2, (ms.Height - ms.Height) / 2);



        }

 
    }
}