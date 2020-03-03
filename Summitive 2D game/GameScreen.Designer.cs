namespace Summitive_2D_game
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.player1PointsLabel = new System.Windows.Forms.Label();
            this.player2PointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // player1PointsLabel
            // 
            this.player1PointsLabel.AutoSize = true;
            this.player1PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1PointsLabel.ForeColor = System.Drawing.Color.White;
            this.player1PointsLabel.Location = new System.Drawing.Point(1, 601);
            this.player1PointsLabel.Name = "player1PointsLabel";
            this.player1PointsLabel.Size = new System.Drawing.Size(42, 46);
            this.player1PointsLabel.TabIndex = 0;
            this.player1PointsLabel.Text = "0";
            // 
            // player2PointsLabel
            // 
            this.player2PointsLabel.AutoSize = true;
            this.player2PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2PointsLabel.ForeColor = System.Drawing.Color.White;
            this.player2PointsLabel.Location = new System.Drawing.Point(1142, 601);
            this.player2PointsLabel.Name = "player2PointsLabel";
            this.player2PointsLabel.Size = new System.Drawing.Size(42, 46);
            this.player2PointsLabel.TabIndex = 1;
            this.player2PointsLabel.Text = "0";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.player2PointsLabel);
            this.Controls.Add(this.player1PointsLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1225, 719);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label player1PointsLabel;
        private System.Windows.Forms.Label player2PointsLabel;
    }
}
