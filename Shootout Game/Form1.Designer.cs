namespace Shootout_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtAmmo = new Label();
            txtScore = new Label();
            label1 = new Label();
            healthBar = new ProgressBar();
            player = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmmo.ForeColor = Color.White;
            txtAmmo.Location = new Point(12, 9);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(93, 24);
            txtAmmo.TabIndex = 0;
            txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(371, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(71, 24);
            txtScore.TabIndex = 1;
            txtScore.Text = "Kills: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(661, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 2;
            label1.Text = "Health:";
            // 
            // healthBar
            // 
            healthBar.Location = new Point(743, 10);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(169, 23);
            healthBar.TabIndex = 3;
            healthBar.Value = 100;
            // 
            // player
            // 
            player.Image = Properties.Resources.up;
            player.Location = new Point(371, 464);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(924, 661);
            Controls.Add(player);
            Controls.Add(healthBar);
            Controls.Add(label1);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Name = "Form1";
            Text = "Zombie Shootout Game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAmmo;
        private Label txtScore;
        private Label label1;
        private ProgressBar healthBar;
        private PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}