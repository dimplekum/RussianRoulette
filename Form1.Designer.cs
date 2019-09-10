namespace RussianRoulette
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fire = new System.Windows.Forms.Button();
            this.reloadRevolver = new System.Windows.Forms.Button();
            this.spinClamber = new System.Windows.Forms.Button();
            this.resetGame = new System.Windows.Forms.Button();
            this.quitGame = new System.Windows.Forms.Button();
            this.shootAway = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.victoryIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 656);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Fire
            // 
            this.Fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.Location = new System.Drawing.Point(874, 174);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(377, 72);
            this.Fire.TabIndex = 1;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // reloadRevolver
            // 
            this.reloadRevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadRevolver.Location = new System.Drawing.Point(874, 330);
            this.reloadRevolver.Name = "reloadRevolver";
            this.reloadRevolver.Size = new System.Drawing.Size(377, 72);
            this.reloadRevolver.TabIndex = 2;
            this.reloadRevolver.Text = "Reload";
            this.reloadRevolver.UseVisualStyleBackColor = true;
            this.reloadRevolver.Click += new System.EventHandler(this.ReloadRevolver_Click);
            // 
            // spinClamber
            // 
            this.spinClamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinClamber.Location = new System.Drawing.Point(874, 408);
            this.spinClamber.Name = "spinClamber";
            this.spinClamber.Size = new System.Drawing.Size(377, 72);
            this.spinClamber.TabIndex = 3;
            this.spinClamber.Text = "Spin";
            this.spinClamber.UseVisualStyleBackColor = true;
            this.spinClamber.Click += new System.EventHandler(this.SpinClamber_Click);
            // 
            // resetGame
            // 
            this.resetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGame.Location = new System.Drawing.Point(874, 486);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(377, 72);
            this.resetGame.TabIndex = 4;
            this.resetGame.Text = "Reset";
            this.resetGame.UseVisualStyleBackColor = true;
            this.resetGame.Click += new System.EventHandler(this.ResetGame_Click);
            // 
            // quitGame
            // 
            this.quitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGame.Location = new System.Drawing.Point(874, 564);
            this.quitGame.Name = "quitGame";
            this.quitGame.Size = new System.Drawing.Size(377, 72);
            this.quitGame.TabIndex = 5;
            this.quitGame.Text = "Quit Game";
            this.quitGame.UseVisualStyleBackColor = true;
            this.quitGame.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // shootAway
            // 
            this.shootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootAway.Location = new System.Drawing.Point(874, 252);
            this.shootAway.Name = "shootAway";
            this.shootAway.Size = new System.Drawing.Size(377, 72);
            this.shootAway.TabIndex = 6;
            this.shootAway.Text = "Shoot Away";
            this.shootAway.UseVisualStyleBackColor = true;
            this.shootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Russian Roulette";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(877, 68);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(92, 25);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score: 0";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(874, 651);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(50, 18);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Error: ";
            // 
            // victoryIndicator
            // 
            this.victoryIndicator.AutoSize = true;
            this.victoryIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryIndicator.Location = new System.Drawing.Point(874, 105);
            this.victoryIndicator.Name = "victoryIndicator";
            this.victoryIndicator.Size = new System.Drawing.Size(250, 55);
            this.victoryIndicator.TabIndex = 10;
            this.victoryIndicator.Text = "VICTORY!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.victoryIndicator);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shootAway);
            this.Controls.Add(this.quitGame);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.spinClamber);
            this.Controls.Add(this.reloadRevolver);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button reloadRevolver;
        private System.Windows.Forms.Button spinClamber;
        private System.Windows.Forms.Button resetGame;
        private System.Windows.Forms.Button quitGame;
        private System.Windows.Forms.Button shootAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label victoryIndicator;
    }
}

