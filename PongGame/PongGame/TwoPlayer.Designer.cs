namespace PongGame
{
    partial class TwoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoPlayer));
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picDivider = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbTPpause = new System.Windows.Forms.PictureBox();
            this.pbTPplay = new System.Windows.Forms.PictureBox();
            this.pbTPback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPback)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.Navy;
            this.picPlayer1.Location = new System.Drawing.Point(31, 195);
            this.picPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(21, 128);
            this.picPlayer1.TabIndex = 4;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picPlayer2.Location = new System.Drawing.Point(984, 195);
            this.picPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(21, 128);
            this.picPlayer2.TabIndex = 5;
            this.picPlayer2.TabStop = false;
            // 
            // picDivider
            // 
            this.picDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.picDivider.Location = new System.Drawing.Point(521, 134);
            this.picDivider.Margin = new System.Windows.Forms.Padding(4);
            this.picDivider.Name = "picDivider";
            this.picDivider.Size = new System.Drawing.Size(24, 287);
            this.picDivider.TabIndex = 6;
            this.picDivider.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(426, 160);
            this.picBall.Margin = new System.Windows.Forms.Padding(4);
            this.picBall.MaximumSize = new System.Drawing.Size(40, 40);
            this.picBall.MinimumSize = new System.Drawing.Size(40, 40);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(40, 40);
            this.picBall.TabIndex = 7;
            this.picBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbTPpause
            // 
            this.pbTPpause.BackColor = System.Drawing.Color.Transparent;
            this.pbTPpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTPpause.Image = ((System.Drawing.Image)(resources.GetObject("pbTPpause.Image")));
            this.pbTPpause.Location = new System.Drawing.Point(1000, 15);
            this.pbTPpause.Name = "pbTPpause";
            this.pbTPpause.Size = new System.Drawing.Size(50, 50);
            this.pbTPpause.TabIndex = 8;
            this.pbTPpause.TabStop = false;
            this.pbTPpause.Click += new System.EventHandler(this.pbTPpause_Click);
            // 
            // pbTPplay
            // 
            this.pbTPplay.BackColor = System.Drawing.Color.Transparent;
            this.pbTPplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTPplay.Image = ((System.Drawing.Image)(resources.GetObject("pbTPplay.Image")));
            this.pbTPplay.Location = new System.Drawing.Point(1000, 15);
            this.pbTPplay.Name = "pbTPplay";
            this.pbTPplay.Size = new System.Drawing.Size(50, 50);
            this.pbTPplay.TabIndex = 9;
            this.pbTPplay.TabStop = false;
            this.pbTPplay.Visible = false;
            this.pbTPplay.Click += new System.EventHandler(this.pbTPplay_Click);
            // 
            // pbTPback
            // 
            this.pbTPback.BackColor = System.Drawing.Color.Transparent;
            this.pbTPback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTPback.Image = ((System.Drawing.Image)(resources.GetObject("pbTPback.Image")));
            this.pbTPback.Location = new System.Drawing.Point(23, 15);
            this.pbTPback.Name = "pbTPback";
            this.pbTPback.Size = new System.Drawing.Size(50, 50);
            this.pbTPback.TabIndex = 10;
            this.pbTPback.TabStop = false;
            this.pbTPback.Click += new System.EventHandler(this.pbTPback_Click);
            // 
            // TwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picDivider);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.pbTPback);
            this.Controls.Add(this.pbTPpause);
            this.Controls.Add(this.pbTPplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwoPlayer";
            this.Text = "TwoPlayer";
            this.Load += new System.EventHandler(this.TwoPlayer_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TwoPlayer_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picDivider;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbTPpause;
        private System.Windows.Forms.PictureBox pbTPplay;
        private System.Windows.Forms.PictureBox pbTPback;
    }
}