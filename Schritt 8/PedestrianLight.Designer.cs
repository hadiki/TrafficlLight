namespace Ampel
{
   partial class PedestrianLight
   {
      /// <summary> 
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Komponenten-Designer generierter Code

      /// <summary> 
      /// Erforderliche Methode für die Designerunterstützung. 
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
         this.BtnStop = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblCountDown = new System.Windows.Forms.Label();
         this.GreenLight = new Ampel.Lamp();
         this.RedLight = new Ampel.Lamp();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
         this.SuspendLayout();
         // 
         // BtnStop
         // 
         this.BtnStop.BackColor = System.Drawing.Color.Yellow;
         this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnStop.Location = new System.Drawing.Point(91, 176);
         this.BtnStop.Name = "BtnStop";
         this.BtnStop.Size = new System.Drawing.Size(30, 92);
         this.BtnStop.TabIndex = 1;
         this.BtnStop.Text = "STOP";
         this.BtnStop.UseVisualStyleBackColor = false;
         this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.pictureBox1.Location = new System.Drawing.Point(65, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(86, 158);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // lblCountDown
         // 
         this.lblCountDown.AutoSize = true;
         this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCountDown.Location = new System.Drawing.Point(165, 36);
         this.lblCountDown.Name = "lblCountDown";
         this.lblCountDown.Size = new System.Drawing.Size(46, 31);
         this.lblCountDown.TabIndex = 4;
         this.lblCountDown.Text = "00";
         // 
         // GreenLight
         // 
         this.GreenLight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.GreenLight.Image = global::Ampel.Properties.Resources.DarkGreen;
         this.GreenLight.Location = new System.Drawing.Point(77, 104);
         this.GreenLight.Name = "GreenLight";
         this.GreenLight.OffImage = global::Ampel.Properties.Resources.DarkGreen;
         this.GreenLight.OnImage = global::Ampel.Properties.Resources.LightGreen;
         this.GreenLight.Size = new System.Drawing.Size(61, 54);
         this.GreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.GreenLight.State = Ampel.LampState.Off;
         this.GreenLight.TabIndex = 3;
         this.GreenLight.TabStop = false;
         // 
         // RedLight
         // 
         this.RedLight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.RedLight.Image = global::Ampel.Properties.Resources.LightRed;
         this.RedLight.Location = new System.Drawing.Point(77, 26);
         this.RedLight.Name = "RedLight";
         this.RedLight.OffImage = global::Ampel.Properties.Resources.DarkRed;
         this.RedLight.OnImage = global::Ampel.Properties.Resources.LightRed;
         this.RedLight.Size = new System.Drawing.Size(61, 54);
         this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.RedLight.State = Ampel.LampState.On;
         this.RedLight.TabIndex = 2;
         this.RedLight.TabStop = false;
         // 
         // PedestrianLight
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.lblCountDown);
         this.Controls.Add(this.GreenLight);
         this.Controls.Add(this.RedLight);
         this.Controls.Add(this.BtnStop);
         this.Controls.Add(this.pictureBox1);
         this.Name = "PedestrianLight";
         this.Size = new System.Drawing.Size(212, 293);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button BtnStop;
      private Lamp RedLight;
      private Lamp GreenLight;
      private System.Windows.Forms.Label lblCountDown;
   }
}
