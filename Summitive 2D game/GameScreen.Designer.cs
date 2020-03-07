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
            this.exitButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.pauseBackGround = new System.Windows.Forms.Label();
            this.player1ShowLabel = new System.Windows.Forms.Label();
            this.player2ShowLabel = new System.Windows.Forms.Label();
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
            // exitButton
            // 
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(507, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(211, 69);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(507, 261);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(211, 69);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // pauseBackGround
            // 
            this.pauseBackGround.BackColor = System.Drawing.Color.Black;
            this.pauseBackGround.Location = new System.Drawing.Point(475, 212);
            this.pauseBackGround.Name = "pauseBackGround";
            this.pauseBackGround.Size = new System.Drawing.Size(277, 296);
            this.pauseBackGround.TabIndex = 4;
            this.pauseBackGround.Visible = false;
            // 
            // player1ShowLabel
            // 
            this.player1ShowLabel.AutoSize = true;
            this.player1ShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ShowLabel.ForeColor = System.Drawing.Color.White;
            this.player1ShowLabel.Location = new System.Drawing.Point(3, 0);
            this.player1ShowLabel.Name = "player1ShowLabel";
            this.player1ShowLabel.Size = new System.Drawing.Size(100, 29);
            this.player1ShowLabel.TabIndex = 5;
            this.player1ShowLabel.Text = "Player 1";
            // 
            // player2ShowLabel
            // 
            this.player2ShowLabel.AutoSize = true;
            this.player2ShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ShowLabel.ForeColor = System.Drawing.Color.White;
            this.player2ShowLabel.Location = new System.Drawing.Point(1122, 0);
            this.player2ShowLabel.Name = "player2ShowLabel";
            this.player2ShowLabel.Size = new System.Drawing.Size(100, 29);
            this.player2ShowLabel.TabIndex = 6;
            this.player2ShowLabel.Text = "Player 2";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.player2ShowLabel);
            this.Controls.Add(this.player1ShowLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.player2PointsLabel);
            this.Controls.Add(this.player1PointsLabel);
            this.Controls.Add(this.pauseBackGround);
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label pauseBackGround;
        private System.Windows.Forms.Label player1ShowLabel;
        private System.Windows.Forms.Label player2ShowLabel;
    }
}
