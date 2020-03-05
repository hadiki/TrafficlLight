namespace Ampel
{
   partial class Crossing
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

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.NorthTrafficLight = new Ampel.TrafficLight();
            this.EastTrafficLight = new Ampel.TrafficLight();
            this.WestTrafficLight = new Ampel.TrafficLight();
            this.SouthTrafficLight = new Ampel.TrafficLight();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(24, 655);
            this.trackBar.Maximum = 0;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(300, 45);
            this.trackBar.TabIndex = 4;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(21, 605);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 29);
            this.label.TabIndex = 5;
            this.label.Text = "00";
            // 
            // NorthTrafficLight
            // 
            this.NorthTrafficLight.HasContactLoop = true;
            this.NorthTrafficLight.Location = new System.Drawing.Point(427, -1);
            this.NorthTrafficLight.Name = "NorthTrafficLight";
            this.NorthTrafficLight.Purpose = Ampel.TrafficLightPurpose.Traffic;
            this.NorthTrafficLight.Size = new System.Drawing.Size(343, 369);
            this.NorthTrafficLight.TabIndex = 1;
            this.NorthTrafficLight.LoopImpulseReceived += new System.EventHandler(this.CarHasArrived);
            // 
            // EastTrafficLight
            // 
            this.EastTrafficLight.HasContactLoop = false;
            this.EastTrafficLight.Location = new System.Drawing.Point(842, 258);
            this.EastTrafficLight.Name = "EastTrafficLight";
            this.EastTrafficLight.Purpose = Ampel.TrafficLightPurpose.Traffic;
            this.EastTrafficLight.Size = new System.Drawing.Size(310, 334);
            this.EastTrafficLight.TabIndex = 3;
            // 
            // WestTrafficLight
            // 
            this.WestTrafficLight.HasContactLoop = false;
            this.WestTrafficLight.Location = new System.Drawing.Point(12, 258);
            this.WestTrafficLight.Name = "WestTrafficLight";
            this.WestTrafficLight.Purpose = Ampel.TrafficLightPurpose.Traffic;
            this.WestTrafficLight.Size = new System.Drawing.Size(321, 334);
            this.WestTrafficLight.TabIndex = 2;
            // 
            // SouthTrafficLight
            // 
            this.SouthTrafficLight.HasContactLoop = true;
            this.SouthTrafficLight.Location = new System.Drawing.Point(427, 355);
            this.SouthTrafficLight.Name = "SouthTrafficLight";
            this.SouthTrafficLight.Purpose = Ampel.TrafficLightPurpose.Traffic;
            this.SouthTrafficLight.Size = new System.Drawing.Size(313, 369);
            this.SouthTrafficLight.TabIndex = 0;
            this.SouthTrafficLight.LoopImpulseReceived += new System.EventHandler(this.CarHasArrived);
            // 
            // Crossing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 736);
            this.Controls.Add(this.label);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.NorthTrafficLight);
            this.Controls.Add(this.EastTrafficLight);
            this.Controls.Add(this.WestTrafficLight);
            this.Controls.Add(this.SouthTrafficLight);
            this.MaximumSize = new System.Drawing.Size(1180, 775);
            this.MinimumSize = new System.Drawing.Size(1180, 775);
            this.Name = "Crossing";
            this.Text = "Traffic Light";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private TrafficLight SouthTrafficLight;
      private TrafficLight NorthTrafficLight;
      private TrafficLight WestTrafficLight;
      private TrafficLight EastTrafficLight;
      private System.Windows.Forms.TrackBar trackBar;
      private System.Windows.Forms.Label label;
   }
}

