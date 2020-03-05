namespace Ampel
{
   partial class TrafficLight
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficLight));
         this.LightTimer = new System.Windows.Forms.Timer(this.components);
         this.StopButton = new System.Windows.Forms.Button();
         this.GreenLight = new System.Windows.Forms.PictureBox();
         this.YellowLight = new System.Windows.Forms.PictureBox();
         this.RedLight = new System.Windows.Forms.PictureBox();
         this.AmpelBox = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.AmpelBox)).BeginInit();
         this.SuspendLayout();
         // 
         // LightTimer
         // 
         this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
         // 
         // StopButton
         // 
         this.StopButton.BackColor = System.Drawing.Color.Yellow;
         this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.StopButton.Location = new System.Drawing.Point(432, 388);
         this.StopButton.Name = "StopButton";
         this.StopButton.Size = new System.Drawing.Size(26, 123);
         this.StopButton.TabIndex = 7;
         this.StopButton.Text = "Stop";
         this.StopButton.UseVisualStyleBackColor = false;
         this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
         // 
         // GreenLight
         // 
         this.GreenLight.BackColor = System.Drawing.Color.Black;
         this.GreenLight.Image = ((System.Drawing.Image)(resources.GetObject("GreenLight.Image")));
         this.GreenLight.Location = new System.Drawing.Point(405, 256);
         this.GreenLight.Name = "GreenLight";
         this.GreenLight.Size = new System.Drawing.Size(81, 73);
         this.GreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.GreenLight.TabIndex = 2;
         this.GreenLight.TabStop = false;
         // 
         // YellowLight
         // 
         this.YellowLight.BackColor = System.Drawing.Color.Black;
         this.YellowLight.Location = new System.Drawing.Point(405, 177);
         this.YellowLight.Name = "YellowLight";
         this.YellowLight.Size = new System.Drawing.Size(81, 73);
         this.YellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.YellowLight.TabIndex = 5;
         this.YellowLight.TabStop = false;
         // 
         // RedLight
         // 
         this.RedLight.BackColor = System.Drawing.Color.Black;
         this.RedLight.Location = new System.Drawing.Point(405, 98);
         this.RedLight.Name = "RedLight";
         this.RedLight.Size = new System.Drawing.Size(81, 73);
         this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.RedLight.TabIndex = 0;
         this.RedLight.TabStop = false;
         // 
         // AmpelBox
         // 
         this.AmpelBox.BackColor = System.Drawing.Color.Black;
         this.AmpelBox.Location = new System.Drawing.Point(392, 84);
         this.AmpelBox.Name = "AmpelBox";
         this.AmpelBox.Size = new System.Drawing.Size(108, 264);
         this.AmpelBox.TabIndex = 6;
         this.AmpelBox.TabStop = false;
         // 
         // TrafficLight
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 617);
         this.Controls.Add(this.GreenLight);
         this.Controls.Add(this.YellowLight);
         this.Controls.Add(this.RedLight);
         this.Controls.Add(this.StopButton);
         this.Controls.Add(this.AmpelBox);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximumSize = new System.Drawing.Size(816, 656);
         this.MinimumSize = new System.Drawing.Size(816, 656);
         this.Name = "TrafficLight";
         this.Text = "Traffic Light";
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.AmpelBox)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox RedLight;
      private System.Windows.Forms.PictureBox GreenLight;
      private System.Windows.Forms.PictureBox YellowLight;
      private System.Windows.Forms.PictureBox AmpelBox;
      private System.Windows.Forms.Timer LightTimer;
      private System.Windows.Forms.Button StopButton;
   }
}