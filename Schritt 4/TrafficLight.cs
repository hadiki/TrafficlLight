namespace Ampel
{
   using System;
   using System.Windows.Forms;

   public partial class TrafficLight : UserControl
   {
      enum TrafficPhase
      {
         Go = 7,
         Attention = 3,
         Stop = 6,
         Prepare = 2
      }

      private TrafficPhase _CurrentPhase = TrafficPhase.Go;
      private int remainingTime = (int)TrafficPhase.Go;

      private TrafficPhase CurrentPhase
      {
         get { return _CurrentPhase; }
         set
         {
            _CurrentPhase = value;
            RedLight.State = (value == TrafficPhase.Stop) || (value == TrafficPhase.Prepare) ? LampState.On : LampState.Off;
            YellowLight.State = (value == TrafficPhase.Attention) || (value == TrafficPhase.Prepare) ? LampState.On : LampState.Off;
            GreenLight.State = (value == TrafficPhase.Go) ? LampState.On : LampState.Off;
            remainingTime = (int)_CurrentPhase;
         }
      }
      public TrafficLight()
      {
         InitializeComponent();
      }
      private void StopButton_Click(object sender, EventArgs e)
      {
         //start the Attention phase by calling 'LightTimer'
         lblCountDown.Visible = true;
         LightTimer.Start();
      }
      private void LightTimer_Tick(object sender, EventArgs e)
      {
         // Wenn keine Zeit übrig ist: Phasenwechsel
         if (remainingTime == 0)
         {
            CurrentPhase = GoToNextPhase();
         }

         // Anzeige aktualisieren
         lblCountDown.Text = remainingTime.ToString("00");
         lblCountDown.Refresh();

         // Verbleibende Zeit reduzieren
         remainingTime--;
      }
      private TrafficPhase GoToNextPhase()
      {
         //Switch between phases depending on the Current phase

         switch (CurrentPhase)
         {
            case TrafficPhase.Go: return TrafficPhase.Attention;
            case TrafficPhase.Attention: return TrafficPhase.Stop;
            case TrafficPhase.Stop: return TrafficPhase.Prepare;

            default:
               LightTimer.Stop();
               lblCountDown.Visible = false;
               return TrafficPhase.Go;
         }
      }
   }
}

