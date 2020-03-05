namespace Ampel
{
   partial class TrafficLight
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
         this.RedLight = new Ampel.Lamp();
         this.YellowLight = new Ampel.Lamp();
         this.GreenLight = new Ampel.Lamp();
         this.LampPanel = new System.Windows.Forms.Panel();
         this.BtnContact = new System.Windows.Forms.Button();
         this.lblCountDown = new System.Windows.Forms.Label();
         this.BtnStop = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
         this.LampPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // RedLight
         // 
         this.RedLight.Dock = System.Windows.Forms.DockStyle.Top;
         this.RedLight.Image = global::Ampel.Common.Properties.Resources.DarkRed;
         this.RedLight.Location = new System.Drawing.Point(0, 0);
         this.RedLight.Name = "RedLight";
         this.RedLight.OffImage = global::Ampel.Common.Properties.Resources.DarkRed;
         this.RedLight.OnImage = global::Ampel.Common.Properties.Resources.LightRed;
         this.RedLight.Size = new System.Drawing.Size(82, 82);
         this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.RedLight.State = Ampel.LampState.Off;
         this.RedLight.TabIndex = 0;
         this.RedLight.TabStop = false;
         // 
         // YellowLight
         // 
         this.YellowLight.Dock = System.Windows.Forms.DockStyle.Top;
         this.YellowLight.Image = global::Ampel.Common.Properties.Resources.DarkYellow;
         this.YellowLight.Location = new System.Drawing.Point(0, 82);
         this.YellowLight.Name = "YellowLight";
         this.YellowLight.OffImage = global::Ampel.Common.Properties.Resources.DarkYellow;
         this.YellowLight.OnImage = global::Ampel.Common.Properties.Resources.LightYellow;
         this.YellowLight.Size = new System.Drawing.Size(82, 82);
         this.YellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.YellowLight.State = Ampel.LampState.Off;
         this.YellowLight.TabIndex = 1;
         this.YellowLight.TabStop = false;
         // 
         // GreenLight
         // 
         this.GreenLight.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GreenLight.Image = global::Ampel.Common.Properties.Resources.DarkGreen;
         this.GreenLight.Location = new System.Drawing.Point(0, 164);
         this.GreenLight.Name = "GreenLight";
         this.GreenLight.OffImage = global::Ampel.Common.Properties.Resources.DarkGreen;
         this.GreenLight.OnImage = global::Ampel.Common.Properties.Resources.LightGreen;
         this.GreenLight.Size = new System.Drawing.Size(82, 82);
         this.GreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.GreenLight.State = Ampel.LampState.Off;
         this.GreenLight.TabIndex = 2;
         this.GreenLight.TabStop = false;
         // 
         // LampPanel
         // 
         this.LampPanel.BackColor = System.Drawing.Color.Black;
         this.LampPanel.Controls.Add(this.GreenLight);
         this.LampPanel.Controls.Add(this.YellowLight);
         this.LampPanel.Controls.Add(this.RedLight);
         this.LampPanel.Location = new System.Drawing.Point(93, 54);
         this.LampPanel.MaximumSize = new System.Drawing.Size(82, 246);
         this.LampPanel.MinimumSize = new System.Drawing.Size(82, 164);
         this.LampPanel.Name = "LampPanel";
         this.LampPanel.Size = new System.Drawing.Size(82, 246);
         this.LampPanel.TabIndex = 3;
         // 
         // BtnContact
         // 
         this.BtnContact.Location = new System.Drawing.Point(49, 321);
         this.BtnContact.Name = "BtnContact";
         this.BtnContact.Size = new System.Drawing.Size(202, 40);
         this.BtnContact.TabIndex = 4;
         this.BtnContact.UseVisualStyleBackColor = true;
         this.BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
         // 
         // lblCountDown
         // 
         this.lblCountDown.AutoSize = true;
         this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCountDown.Location = new System.Drawing.Point(196, 77);
         this.lblCountDown.Name = "lblCountDown";
         this.lblCountDown.Size = new System.Drawing.Size(55, 39);
         this.lblCountDown.TabIndex = 5;
         this.lblCountDown.Text = "00";
         // 
         // BtnStop
         // 
         this.BtnStop.BackColor = System.Drawing.Color.Yellow;
         this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnStop.Location = new System.Drawing.Point(203, 167);
         this.BtnStop.Name = "BtnStop";
         this.BtnStop.Size = new System.Drawing.Size(59, 50);
         this.BtnStop.TabIndex = 6;
         this.BtnStop.Text = "Stop";
         this.BtnStop.UseVisualStyleBackColor = false;
         // 
         // TrafficLight
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.BtnStop);
         this.Controls.Add(this.lblCountDown);
         this.Controls.Add(this.BtnContact);
         this.Controls.Add(this.LampPanel);
         this.Name = "TrafficLight";
         this.Size = new System.Drawing.Size(296, 424);
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
         this.LampPanel.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Lamp RedLight;
      private Lamp YellowLight;
      private Lamp GreenLight;
      private System.Windows.Forms.Panel LampPanel;
      private System.Windows.Forms.Button BtnContact;
      private System.Windows.Forms.Label lblCountDown;
      private System.Windows.Forms.Button BtnStop;
   }
}
