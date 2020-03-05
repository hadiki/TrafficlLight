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
         this.MainTrafficLight1 = new Ampel.TrafficLight();
         this.MainTrafficLight2 = new Ampel.TrafficLight();
         this.SubTrafficLight1 = new Ampel.TrafficLight();
         this.SubTrafficLight2 = new Ampel.TrafficLight();
         this.SuspendLayout();
         // 
         // MainTrafficLight1
         // 
         this.MainTrafficLight1.Controller = null;
         this.MainTrafficLight1.HasContactLoop = false;
         this.MainTrafficLight1.Location = new System.Drawing.Point(842, 258);
         this.MainTrafficLight1.Name = "MainTrafficLight1";
         this.MainTrafficLight1.Size = new System.Drawing.Size(310, 334);
         this.MainTrafficLight1.TabIndex = 3;
         // 
         // MainTrafficLight2
         // 
         this.MainTrafficLight2.Controller = null;
         this.MainTrafficLight2.HasContactLoop = false;
         this.MainTrafficLight2.Location = new System.Drawing.Point(12, 258);
         this.MainTrafficLight2.Name = "MainTrafficLight2";
         this.MainTrafficLight2.Size = new System.Drawing.Size(321, 334);
         this.MainTrafficLight2.TabIndex = 2;
         // 
         // SubTrafficLight1
         // 
         this.SubTrafficLight1.Controller = null;
         this.SubTrafficLight1.HasContactLoop = true;
         this.SubTrafficLight1.Location = new System.Drawing.Point(427, 12);
         this.SubTrafficLight1.Name = "SubTrafficLight1";
         this.SubTrafficLight1.Size = new System.Drawing.Size(343, 356);
         this.SubTrafficLight1.TabIndex = 1;
         this.SubTrafficLight1.LoopImpulseReceived += new System.EventHandler(this.CarHasArrived);
         // 
         // SubTrafficLight2
         // 
         this.SubTrafficLight2.Controller = null;
         this.SubTrafficLight2.HasContactLoop = true;
         this.SubTrafficLight2.Location = new System.Drawing.Point(427, 403);
         this.SubTrafficLight2.Name = "SubTrafficLight2";
         this.SubTrafficLight2.Size = new System.Drawing.Size(313, 336);
         this.SubTrafficLight2.TabIndex = 0;
         this.SubTrafficLight2.LoopImpulseReceived += new System.EventHandler(this.CarHasArrived);
         // 
         // Crossing
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1164, 736);
         this.Controls.Add(this.MainTrafficLight1);
         this.Controls.Add(this.MainTrafficLight2);
         this.Controls.Add(this.SubTrafficLight1);
         this.Controls.Add(this.SubTrafficLight2);
         this.MaximumSize = new System.Drawing.Size(1180, 775);
         this.MinimumSize = new System.Drawing.Size(1180, 775);
         this.Name = "Crossing";
         this.Text = "Traffic Light";
         this.ResumeLayout(false);

      }

      #endregion

      private TrafficLight SubTrafficLight2;
      private TrafficLight SubTrafficLight1;
      private TrafficLight MainTrafficLight2;
      private TrafficLight MainTrafficLight1;
   }
}

