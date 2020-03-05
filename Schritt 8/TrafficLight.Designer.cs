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
         this.components = new System.ComponentModel.Container();
         this.LightTimer = new System.Windows.Forms.Timer(this.components);
         this.AmpelBox = new System.Windows.Forms.PictureBox();
         this.GreenLight = new Ampel.Lamp();
         this.YellowLight = new Ampel.Lamp();
         this.RedLight = new Ampel.Lamp();
         this.lblCountDown = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.AmpelBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
         this.SuspendLayout();
         // 
         // AmpelBox
         // 
         this.AmpelBox.BackColor = System.Drawing.Color.Black;
         this.AmpelBox.Location = new System.Drawing.Point(3, 13);
         this.AmpelBox.Name = "AmpelBox";
         this.AmpelBox.Size = new System.Drawing.Size(103, 264);
         this.AmpelBox.TabIndex = 19;
         this.AmpelBox.TabStop = false;
         // 
         // GreenLight
         // 
         this.GreenLight.BackColor = System.Drawing.Color.Black;
         this.GreenLight.Image = global::Ampel.Properties.Resources.LightGreen;
         this.GreenLight.Location = new System.Drawing.Point(17, 181);
         this.GreenLight.Name = "GreenLight";
         this.GreenLight.OffImage = global::Ampel.Properties.Resources.DarkGreen;
         this.GreenLight.OnImage = global::Ampel.Properties.Resources.LightGreen;
         this.GreenLight.Size = new System.Drawing.Size(76, 66);
         this.GreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.GreenLight.State = Ampel.LampState.On;
         this.GreenLight.TabIndex = 23;
         this.GreenLight.TabStop = false;
         // 
         // YellowLight
         // 
         this.YellowLight.BackColor = System.Drawing.Color.Black;
         this.YellowLight.Image = global::Ampel.Properties.Resources.DarkYellow;
         this.YellowLight.Location = new System.Drawing.Point(17, 109);
         this.YellowLight.Name = "YellowLight";
         this.YellowLight.OffImage = global::Ampel.Properties.Resources.DarkYellow;
         this.YellowLight.OnImage = global::Ampel.Properties.Resources.LightYellow;
         this.YellowLight.Size = new System.Drawing.Size(76, 66);
         this.YellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.YellowLight.State = Ampel.LampState.Off;
         this.YellowLight.TabIndex = 22;
         this.YellowLight.TabStop = false;
         // 
         // RedLight
         // 
         this.RedLight.BackColor = System.Drawing.Color.Black;
         this.RedLight.Image = global::Ampel.Properties.Resources.DarkRed;
         this.RedLight.Location = new System.Drawing.Point(17, 39);
         this.RedLight.Name = "RedLight";
         this.RedLight.OffImage = global::Ampel.Properties.Resources.DarkRed;
         this.RedLight.OnImage = global::Ampel.Properties.Resources.LightRed;
         this.RedLight.Size = new System.Drawing.Size(76, 64);
         this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.RedLight.State = Ampel.LampState.Off;
         this.RedLight.TabIndex = 21;
         this.RedLight.TabStop = false;
         // 
         // lblCountDown
         // 
         this.lblCountDown.AutoSize = true;
         this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCountDown.Location = new System.Drawing.Point(112, 39);
         this.lblCountDown.Name = "lblCountDown";
         this.lblCountDown.Size = new System.Drawing.Size(55, 39);
         this.lblCountDown.TabIndex = 24;
         this.lblCountDown.Text = "00";
         // 
         // TrafficLight
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.lblCountDown);
         this.Controls.Add(this.GreenLight);
         this.Controls.Add(this.YellowLight);
         this.Controls.Add(this.RedLight);
         this.Controls.Add(this.AmpelBox);
         this.Name = "TrafficLight";
         this.Size = new System.Drawing.Size(181, 347);
         ((System.ComponentModel.ISupportInitialize)(this.AmpelBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      public System.Windows.Forms.PictureBox AmpelBox;
      public System.Windows.Forms.Timer LightTimer;
      private Lamp GreenLight;
      private Lamp YellowLight;
      private Lamp RedLight;
      private System.Windows.Forms.Label lblCountDown;
   }
}
