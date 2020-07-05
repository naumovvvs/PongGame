namespace PongGame
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.pbTPback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTPback)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTPback
            // 
            this.pbTPback.BackColor = System.Drawing.Color.Transparent;
            this.pbTPback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTPback.BackgroundImage")));
            this.pbTPback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTPback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTPback.Location = new System.Drawing.Point(23, 9);
            this.pbTPback.Name = "pbTPback";
            this.pbTPback.Size = new System.Drawing.Size(32, 30);
            this.pbTPback.TabIndex = 11;
            this.pbTPback.TabStop = false;
            this.pbTPback.Click += new System.EventHandler(this.pbTPback_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 424);
            this.Controls.Add(this.pbTPback);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 471);
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pbTPback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTPback;
    }
}