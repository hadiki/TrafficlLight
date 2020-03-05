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
         this.trafficLight = new Ampel.TrafficLight();
         this.SuspendLayout();
         // 
         // trafficLight
         // 
         this.trafficLight.Location = new System.Drawing.Point(94, 10);
         this.trafficLight.Name = "trafficLight";
         this.trafficLight.Size = new System.Drawing.Size(470, 433);
         this.trafficLight.TabIndex = 0;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(684, 455);
         this.Controls.Add(this.trafficLight);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximumSize = new System.Drawing.Size(700, 494);
         this.MinimumSize = new System.Drawing.Size(700, 494);
         this.Name = "MainForm";
         this.Text = "Traffic Light";
         this.ResumeLayout(false);

      }

      #endregion

      private TrafficLight trafficLight;
   }
}

