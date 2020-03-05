namespace Ampel
{
    partial class RYG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RYG));
            this.Red = new System.Windows.Forms.PictureBox();
            this.Green = new System.Windows.Forms.PictureBox();
            this.Yellow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.RedMan = new System.Windows.Forms.PictureBox();
            this.GreenMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Transparent;
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.Location = new System.Drawing.Point(268, 88);
            this.Red.Margin = new System.Windows.Forms.Padding(0);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(32, 36);
            this.Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red.TabIndex = 0;
            this.Red.TabStop = false;
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Transparent;
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.Location = new System.Drawing.Point(348, 92);
            this.Green.Margin = new System.Windows.Forms.Padding(0);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(34, 38);
            this.Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green.TabIndex = 1;
            this.Green.TabStop = false;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Transparent;
            this.Yellow.Image = ((System.Drawing.Image)(resources.GetObject("Yellow.Image")));
            this.Yellow.Location = new System.Drawing.Point(309, 88);
            this.Yellow.Margin = new System.Windows.Forms.Padding(0);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(29, 36);
            this.Yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Yellow.TabIndex = 2;
            this.Yellow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Yellow;
            this.StopButton.Location = new System.Drawing.Point(577, 449);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(19, 77);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RedMan
            // 
            this.RedMan.BackColor = System.Drawing.Color.Transparent;
            this.RedMan.Image = ((System.Drawing.Image)(resources.GetObject("RedMan.Image")));
            this.RedMan.Location = new System.Drawing.Point(547, 379);
            this.RedMan.Name = "RedMan";
            this.RedMan.Size = new System.Drawing.Size(71, 58);
            this.RedMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedMan.TabIndex = 4;
            this.RedMan.TabStop = false;
            // 
            // GreenMan
            // 
            this.GreenMan.BackColor = System.Drawing.Color.Transparent;
            this.GreenMan.Image = ((System.Drawing.Image)(resources.GetObject("GreenMan.Image")));
            this.GreenMan.Location = new System.Drawing.Point(564, 386);
            this.GreenMan.Name = "GreenMan";
            this.GreenMan.Size = new System.Drawing.Size(32, 51);
            this.GreenMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenMan.TabIndex = 5;
            this.GreenMan.TabStop = false;
            // 
            // RYG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(791, 771);
            this.Controls.Add(this.GreenMan);
            this.Controls.Add(this.RedMan);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(799, 801);
            this.MinimumSize = new System.Drawing.Size(799, 801);
            this.Name = "RYG";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(799, 801);
            this.Text = "RYG";
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.PictureBox Yellow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.PictureBox RedMan;
        private System.Windows.Forms.PictureBox GreenMan;
    }
}