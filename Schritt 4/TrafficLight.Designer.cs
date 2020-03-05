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
         this.StopButton = new System.Windows.Forms.Button();
         this.LightTimer = new System.Windows.Forms.Timer(this.components);
         this.AmpelBox = new System.Windows.Forms.PictureBox();
         this.lblCountDown = new System.Windows.Forms.Label();
         this.GreenLight = new Ampel.Lamp();
         this.YellowLight = new Ampel.Lamp();
         this.RedLight = new Ampel.Lamp();
         ((System.ComponentModel.ISupportInitialize)(this.AmpelBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
         this.SuspendLayout();
         // 
         // StopButton
         // 
         this.StopButton.BackColor = System.Drawing.Color.Yellow;
         this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.StopButton.Location = new System.Drawing.Point(234, 298);
         this.StopButton.Name = "StopButton";
         this.StopButton.Size = new System.Drawing.Size(26, 123);
         this.StopButton.TabIndex = 20;
         this.StopButton.Text = "Stop";
         this.StopButton.UseVisualStyleBackColor = false;
         this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
         // 
         // LightTimer
         // 
         this.LightTimer.Interval = 1000;
         this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
         // 
         // AmpelBox
         // 
         this.AmpelBox.BackColor = System.Drawing.Color.Black;
         this.AmpelBox.Location = new System.Drawing.Point(193, 13);
         this.AmpelBox.Name = "AmpelBox";
         this.AmpelBox.Size = new System.Drawing.Size(103, 264);
         this.AmpelBox.TabIndex = 19;
         this.AmpelBox.TabStop = false;
         // 
         // lblCountDown
         // 
         this.lblCountDown.AutoSize = true;
         this.lblCountDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCountDown.ForeColor = System.Drawing.Color.Green;
         this.lblCountDown.Location = new System.Drawing.Point(331, 62);
         this.lblCountDown.Name = "lblCountDown";
         this.lblCountDown.Size = new System.Drawing.Size(44, 31);
         this.lblCountDown.TabIndex = 24;
         this.lblCountDown.Text = "00";
         this.lblCountDown.Visible = false;
         // 
         // GreenLight
         // 
         this.GreenLight.BackColor = System.Drawing.Color.Black;
         this.GreenLight.Image = global::Ampel.Properties.Resources.LightGreen;
         this.GreenLight.Location = new System.Drawing.Point(207, 181);
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
         this.YellowLight.Location = new System.Drawing.Point(207, 109);
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
         this.RedLight.Location = new System.Drawing.Point(207, 37);
         this.RedLight.Name = "RedLight";
         this.RedLight.OffImage = global::Ampel.Properties.Resources.DarkRed;
         this.RedLight.OnImage = global::Ampel.Properties.Resources.LightRed;
         this.RedLight.Size = new System.Drawing.Size(76, 64);
         this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.RedLight.State = Ampel.LampState.Off;
         this.RedLight.TabIndex = 21;
         this.RedLight.TabStop = false;
         // 
         // TrafficLight
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.lblCountDown);
         this.Controls.Add(this.StopButton);
         this.Controls.Add(this.GreenLight);
         this.Controls.Add(this.YellowLight);
         this.Controls.Add(this.RedLight);
         this.Controls.Add(this.AmpelBox);
         this.Name = "TrafficLight";
         this.Size = new System.Drawing.Size(485, 449);
         ((System.ComponentModel.ISupportInitialize)(this.AmpelBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.Button StopButton;
      public System.Windows.Forms.PictureBox AmpelBox;
      public System.Windows.Forms.Timer LightTimer;
      private Lamp GreenLight;
      private Lamp YellowLight;
      private Lamp RedLight;
      private System.Windows.Forms.Label lblCountDown;
   }
}
