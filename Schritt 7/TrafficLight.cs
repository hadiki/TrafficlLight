namespace Ampel
{
   using System;
   using System.Collections.Generic;
   using System.Windows.Forms;
   enum PhaseType
   {
      Go,
      Attention,
      Stop,
      Prepare
   }
   public partial class TrafficLight : UserControl
   {
      private Queue<TrafficPhase> phaseQueue = new Queue<TrafficPhase>();
      private TrafficPhase _CurrentPhase;
      private TrafficPhase CurrentPhase
      {
         get { return _CurrentPhase; }
         set
         {
          //change the lamp Color depending on the phase
            _CurrentPhase = value;
            RedLight.State = (value.Type == PhaseType.Stop) || (value.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
            YellowLight.State = (value.Type == PhaseType.Attention) || (value.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
            GreenLight.State = (value.Type == PhaseType.Go) ? LampState.On : LampState.Off;
            StopButton.Enabled = (value.Type == PhaseType.Go);
            Invalidate();
            Application.DoEvents();
         }
      }
      public TrafficLight()
      {
         InitializeComponent();
         CurrentPhase = new TrafficPhase(PhaseType.Go, 8);
         CurrentPhase.Done += Phase_Done;
         CurrentPhase.Elapsed += Phase_Elapsed;
      }
      private void StopButton_Click(object sender, EventArgs e)
      {
         lblCountDown.Visible = true;

      //Add the phases to a Queue with the time duration
         var phase = new TrafficPhase(PhaseType.Attention, 3);
         phase.Done += Phase_Done;
         phase.Elapsed += Phase_Elapsed;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Stop, 7);
         phase.Done += Phase_Done;
         phase.Elapsed += Phase_Elapsed;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Prepare, 2);
         phase.Done += Phase_Done;
         phase.Elapsed += Phase_Elapsed;
         phaseQueue.Enqueue(phase);

      // Aktuelle Phase Go ist am Ende wieder Ausgangszustand
         phaseQueue.Enqueue(CurrentPhase);

      // Ablauf der aktuellen Phase auslösen
         CurrentPhase.Run();
      }

      private void Phase_Elapsed(object sender, RemainingTimeEventArgs e)
      {
       //update the label to the value of the Remaining Time
         lblCountDown.Text = e.RemainingTime.ToString("00");
         if (phaseQueue.Count == 1)
         {
            lblCountDown.Visible = false;
         }
      }
      private void Phase_Done(object sender, EventArgs e)
      {
      //execute the next phase in the Queue
         if (phaseQueue.Count != 0)
         {
            CurrentPhase = phaseQueue.Dequeue();
            CurrentPhase.Run();
         }
      }
   }
}