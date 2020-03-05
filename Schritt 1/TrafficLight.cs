namespace Ampel
{
   using System;
   using System.Windows.Forms;

   public partial class TrafficLight : Form
   {
      enum TrafficPhase
      {
         Go,
         Attention,
         Stop,
         Prepare
      }

      private TrafficPhase CurrentPhase { get; set; }

      public TrafficLight()
      {
         InitializeComponent();
         CurrentPhase = TrafficPhase.Go;

         GreenLight.Image = Properties.Resources.LightGreen;
         YellowLight.Image = Properties.Resources.DarkYellow;
         RedLight.Image = Properties.Resources.DarkRed;
         

      }

      private void StopButton_Click(object sender, EventArgs e) 
      {
         //start the Attention phase by calling 'LightTimer'
         LightTimer.Interval = 6000;
         LightTimer.Start();
      }

      private void LightTimer_Tick(object sender, EventArgs e)
      {
         //Attention phase
         if (CurrentPhase == TrafficPhase.Go)
         {
            CurrentPhase = TrafficPhase.Attention;
            GreenLight.Image = Properties.Resources.DarkGreen;
            YellowLight.Image = Properties.Resources.LightYellow;
            RedLight.Image = Properties.Resources.DarkRed;
            LightTimer.Interval = 3000;
         }
         //Stop phase
         else if (CurrentPhase == TrafficPhase.Attention)
         {
            CurrentPhase = TrafficPhase.Stop;
            GreenLight.Image = Properties.Resources.DarkGreen;
            YellowLight.Image = Properties.Resources.DarkYellow;
            RedLight.Image = Properties.Resources.LightRed;
            LightTimer.Interval = 6000;

         }
         //Prepare Phase

         else if (CurrentPhase == TrafficPhase.Stop)
         {
            CurrentPhase = TrafficPhase.Prepare;
            GreenLight.Image = Properties.Resources.DarkGreen;
            YellowLight.Image = Properties.Resources.LightYellow;
            RedLight.Image = Properties.Resources.LightRed;
            LightTimer.Interval = 2000;

         }
         else if (CurrentPhase == TrafficPhase.Prepare)
         {
            CurrentPhase = TrafficPhase.Go;
            GreenLight.Image = Properties.Resources.LightGreen;
            YellowLight.Image = Properties.Resources.DarkYellow;
            RedLight.Image = Properties.Resources.DarkRed;
            LightTimer.Stop();
         }

      }
   }
}

