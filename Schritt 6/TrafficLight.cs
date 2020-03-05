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
      }
      private void StopButton_Click(object sender, EventArgs e)
      {
         //Add the phases to a Queue with the time duration
         var phase = new TrafficPhase(PhaseType.Attention, 3);
         phase.Done += Phase_Done;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Stop, 7);
         phase.Done += Phase_Done;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Prepare, 2);
         phase.Done += Phase_Done;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Go, 8);
         phase.Done += Phase_Done;
         phaseQueue.Enqueue(phase);

         CurrentPhase.Run();
         phaseQueue.Enqueue(phase);
      }
      private void Phase_Done(object sender, EventArgs e)
      {
         if (phaseQueue.Count != 0)
         {
            CurrentPhase = phaseQueue.Dequeue();
            CurrentPhase.Run();
         }
      }
   }
}

