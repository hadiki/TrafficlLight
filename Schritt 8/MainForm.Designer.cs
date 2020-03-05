namespace Ampel
{
   partial class MainForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.trafficLight2 = new Ampel.TrafficLight();
         this.trafficLight1 = new Ampel.TrafficLight();
         this.pedestrianLight1 = new Ampel.PedestrianLight();
         this.pedestrianLight2 = new Ampel.PedestrianLight();
         this.SuspendLayout();
         // 
         // trafficLight2
         // 
         this.trafficLight2.Controller = null;
         this.trafficLight2.Location = new System.Drawing.Point(510, 12);
         this.trafficLight2.Name = "trafficLight2";
         this.trafficLight2.Size = new System.Drawing.Size(181, 297);
         this.trafficLight2.TabIndex = 1;
         // 
         // trafficLight1
         // 
         this.trafficLight1.Controller = null;
         this.trafficLight1.Location = new System.Drawing.Point(510, 438);
         this.trafficLight1.Name = "trafficLight1";
         this.trafficLight1.Size = new System.Drawing.Size(181, 285);
         this.trafficLight1.TabIndex = 0;
         // 
         // pedestrianLight1
         // 
         this.pedestrianLight1.Controller = null;
         this.pedestrianLight1.Location = new System.Drawing.Point(907, 229);
         this.pedestrianLight1.Name = "pedestrianLight1";
         this.pedestrianLight1.Size = new System.Drawing.Size(254, 336);
         this.pedestrianLight1.TabIndex = 2;
         // 
         // pedestrianLight2
         // 
         this.pedestrianLight2.Controller = null;
         this.pedestrianLight2.Location = new System.Drawing.Point(12, 229);
         this.pedestrianLight2.Name = "pedestrianLight2";
         this.pedestrianLight2.Size = new System.Drawing.Size(254, 336);
         this.pedestrianLight2.TabIndex = 3;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1164, 736);
         this.Controls.Add(this.pedestrianLight2);
         this.Controls.Add(this.pedestrianLight1);
         this.Controls.Add(this.trafficLight2);
         this.Controls.Add(this.trafficLight1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximumSize = new System.Drawing.Size(1180, 775);
         this.MinimumSize = new System.Drawing.Size(1180, 775);
         this.Name = "MainForm";
         this.Text = "Traffic Light";
         this.ResumeLayout(false);

      }

      #endregion

      private TrafficLight trafficLight1;
      private TrafficLight trafficLight2;
      private PedestrianLight pedestrianLight1;
      private PedestrianLight pedestrianLight2;
   }
}

