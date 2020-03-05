namespace Ampel
{
   using System;
   using System.Windows.Forms;

   public partial class TrafficLight : UserControl
   {
      enum TrafficPhase
      {
         Go,
         Attention,
         Stop,
         Prepare
      }

      private TrafficPhase _CurrentPhase = TrafficPhase.Go;



      private TrafficPhase CurrentPhase
      {
         get { return _CurrentPhase; }
         set
         {
            _CurrentPhase = value;

            RedLight.State = (value == TrafficPhase.Stop) || (value == TrafficPhase.Prepare) ? LampState.On : LampState.Off;
            YellowLight .State = (value == TrafficPhase.Attention ) || (value == TrafficPhase.Prepare) ? LampState.On : LampState.Off;
            GreenLight.State = (value == TrafficPhase.Go) ? LampState.On : LampState.Off;
         }
      }

      public TrafficLight()
      {
         InitializeComponent();
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
            LightTimer.Interval = 3000;
         }
         //Stop phase
         else if (CurrentPhase == TrafficPhase.Attention)
         {
            CurrentPhase = TrafficPhase.Stop;
            LightTimer.Interval = 6000;

         }

         //Prepare Phase
         else if (CurrentPhase == TrafficPhase.Stop)
         {
            CurrentPhase = TrafficPhase.Prepare;
            LightTimer.Interval = 2000;

         }
         //return to Go Phase
         else if (CurrentPhase == TrafficPhase.Prepare)
         {
            CurrentPhase = TrafficPhase.Go;
            LightTimer.Stop();
         }

      }
   }
}

