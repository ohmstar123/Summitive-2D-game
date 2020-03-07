namespace Summitive_2D_game
{
    partial class DifficultyScreen
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
            this.mediumButton = new System.Windows.Forms.Button();
            this.Button = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.impossibleButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(502, 277);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(211, 69);
            this.mediumButton.TabIndex = 6;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // Button
            // 
            this.Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.ForeColor = System.Drawing.Color.White;
            this.Button.Location = new System.Drawing.Point(502, 383);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(211, 69);
            this.Button.TabIndex = 7;
            this.Button.Text = "Hard";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(502, 171);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(211, 69);
            this.easyButton.TabIndex = 5;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(410, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(402, 79);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Difficulty";
            // 
            // impossibleButton
            // 
            this.impossibleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.impossibleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.impossibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impossibleButton.ForeColor = System.Drawing.Color.White;
            this.impossibleButton.Location = new System.Drawing.Point(502, 489);
            this.impossibleButton.Name = "impossibleButton";
            this.impossibleButton.Size = new System.Drawing.Size(211, 69);
            this.impossibleButton.TabIndex = 8;
            this.impossibleButton.Text = "Impossible";
            this.impossibleButton.UseVisualStyleBackColor = true;
            this.impossibleButton.Click += new System.EventHandler(this.impossibleButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.mainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.mainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuButton.ForeColor = System.Drawing.Color.White;
            this.mainMenuButton.Location = new System.Drawing.Point(502, 595);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(211, 69);
            this.mainMenuButton.TabIndex = 9;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // DifficultyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.impossibleButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "DifficultyScreen";
            this.Size = new System.Drawing.Size(1225, 719);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button impossibleButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}
