namespace PongGame
{
    partial class SinglePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinglePlayer));
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picDivider = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbSPback = new System.Windows.Forms.PictureBox();
            this.pbSPplay = new System.Windows.Forms.PictureBox();
            this.pbSPpause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPpause)).BeginInit();
            this.SuspendLayout();
            // 
            // picComputer
            // 
            this.picComputer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picComputer.Location = new System.Drawing.Point(860, 192);
            this.picComputer.Margin = new System.Windows.Forms.Padding(4);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(21, 128);
            this.picComputer.TabIndex = 0;
            this.picComputer.TabStop = false;
            // 
            // picDivider
            // 
            this.picDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.picDivider.Location = new System.Drawing.Point(531, 145);
            this.picDivider.Margin = new System.Windows.Forms.Padding(4);
            this.picDivider.Name = "picDivider";
            this.picDivider.Size = new System.Drawing.Size(24, 287);
            this.picDivider.TabIndex = 1;
            this.picDivider.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Navy;
            this.picPlayer.Location = new System.Drawing.Point(37, 192);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(21, 128);
            this.picPlayer.TabIndex = 3;
            this.picPlayer.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(404, 192);
            this.picBall.Margin = new System.Windows.Forms.Padding(4);
            this.picBall.MaximumSize = new System.Drawing.Size(40, 40);
            this.picBall.MinimumSize = new System.Drawing.Size(40, 40);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(40, 40);
            this.picBall.TabIndex = 4;
            this.picBall.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbSPback
            // 
            this.pbSPback.BackColor = System.Drawing.Color.Transparent;
            this.pbSPback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSPback.Image = ((System.Drawing.Image)(resources.GetObject("pbSPback.Image")));
            this.pbSPback.Location = new System.Drawing.Point(23, 15);
            this.pbSPback.Name = "pbSPback";
            this.pbSPback.Size = new System.Drawing.Size(50, 50);
            this.pbSPback.TabIndex = 11;
            this.pbSPback.TabStop = false;
            this.pbSPback.Click += new System.EventHandler(this.pbSPback_Click);
            // 
            // pbSPplay
            // 
            this.pbSPplay.BackColor = System.Drawing.Color.Transparent;
            this.pbSPplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSPplay.Image = ((System.Drawing.Image)(resources.GetObject("pbSPplay.Image")));
            this.pbSPplay.Location = new System.Drawing.Point(1000, 15);
            this.pbSPplay.Name = "pbSPplay";
            this.pbSPplay.Size = new System.Drawing.Size(50, 50);
            this.pbSPplay.TabIndex = 12;
            this.pbSPplay.TabStop = false;
            this.pbSPplay.Visible = false;
            this.pbSPplay.Click += new System.EventHandler(this.pbSPplay_Click);
            // 
            // pbSPpause
            // 
            this.pbSPpause.BackColor = System.Drawing.Color.Transparent;
            this.pbSPpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSPpause.Image = ((System.Drawing.Image)(resources.GetObject("pbSPpause.Image")));
            this.pbSPpause.Location = new System.Drawing.Point(1000, 15);
            this.pbSPpause.Name = "pbSPpause";
            this.pbSPpause.Size = new System.Drawing.Size(50, 50);
            this.pbSPpause.TabIndex = 13;
            this.pbSPpause.TabStop = false;
            this.pbSPpause.Click += new System.EventHandler(this.pbSPpause_Click);
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picDivider);
            this.Controls.Add(this.pbSPback);
            this.Controls.Add(this.pbSPplay);
            this.Controls.Add(this.pbSPpause);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinglePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SinglePlayer_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SinglePlayer_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPpause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picDivider;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbSPback;
        private System.Windows.Forms.PictureBox pbSPplay;
        private System.Windows.Forms.PictureBox pbSPpause;
    }
}

