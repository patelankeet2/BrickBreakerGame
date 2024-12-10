namespace BrickBreakerGame
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
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxwin = new System.Windows.Forms.PictureBox();
            this.pictureBoxloser = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.BAT = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Silver;
            this.txtScore.Location = new System.Drawing.Point(13, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(127, 32);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 25;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // pictureBoxwin
            // 
            this.pictureBoxwin.Image = global::BrickBreakerGame.Properties.Resources.winner;
            this.pictureBoxwin.Location = new System.Drawing.Point(12, 48);
            this.pictureBoxwin.Name = "pictureBoxwin";
            this.pictureBoxwin.Size = new System.Drawing.Size(1043, 600);
            this.pictureBoxwin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxwin.TabIndex = 5;
            this.pictureBoxwin.TabStop = false;
            this.pictureBoxwin.Visible = false;
            // 
            // pictureBoxloser
            // 
            this.pictureBoxloser.Image = global::BrickBreakerGame.Properties.Resources.loser;
            this.pictureBoxloser.Location = new System.Drawing.Point(12, 48);
            this.pictureBoxloser.Name = "pictureBoxloser";
            this.pictureBoxloser.Size = new System.Drawing.Size(1043, 600);
            this.pictureBoxloser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxloser.TabIndex = 4;
            this.pictureBoxloser.TabStop = false;
            this.pictureBoxloser.Visible = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ball.Image = global::BrickBreakerGame.Properties.Resources.OIP;
            this.Ball.Location = new System.Drawing.Point(503, 366);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(33, 28);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // BAT
            // 
            this.BAT.BackColor = System.Drawing.Color.White;
            this.BAT.Location = new System.Drawing.Point(463, 606);
            this.BAT.Name = "BAT";
            this.BAT.Size = new System.Drawing.Size(133, 39);
            this.BAT.TabIndex = 1;
            this.BAT.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(899, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Press \'e\' to Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxwin);
            this.Controls.Add(this.pictureBoxloser);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.BAT);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrickBreakerGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox BAT;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBoxloser;
        private System.Windows.Forms.PictureBox pictureBoxwin;
        private System.Windows.Forms.Label label1;
    }
}

