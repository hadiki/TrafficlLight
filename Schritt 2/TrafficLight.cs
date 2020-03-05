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

         RedLight.SetState(LampState.Off);
         YellowLight.SetState(LampState.Off);
         GreenLight.SetState(LampState.On);
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
            RedLight.SetState(LampState.Off);
            YellowLight.SetState(LampState.On);
            GreenLight.SetState(LampState.Off);
            LightTimer.Interval = 3000;
         }
         //Stop phase
         else if (CurrentPhase == TrafficPhase.Attention)
         {
            CurrentPhase = TrafficPhase.Stop;
            RedLight.SetState(LampState.On);
            YellowLight.SetState(LampState.Off);//LightStateOff();
            GreenLight.SetState(LampState.Off);
            LightTimer.Interval = 6000;

         }
         //Prepare Phase

         else if (CurrentPhase == TrafficPhase.Stop)
         {
            CurrentPhase = TrafficPhase.Prepare;
            RedLight.SetState(LampState.On);
            YellowLight.SetState(LampState.On);
            GreenLight.SetState(LampState.Off);
            LightTimer.Interval = 2000;

         }
         else if (CurrentPhase == TrafficPhase.Prepare)
         {
            CurrentPhase = TrafficPhase.Go;
            RedLight.SetState(LampState.Off);
            YellowLight.SetState(LampState.Off);
            GreenLight.SetState(LampState.On);
            LightTimer.Stop();
         }

      }
   }
}

