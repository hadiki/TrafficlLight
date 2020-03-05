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
         CurrentPhase = new TrafficPhase(PhaseType.Go, 7);
      }
      private void StopButton_Click(object sender, EventArgs e)
      {
         //Add the phases to a Queue with the time duration
         var phaseQueue = new Queue<TrafficPhase>();
         
         phaseQueue.Enqueue(new TrafficPhase(PhaseType.Attention, 3));
         phaseQueue.Enqueue(new TrafficPhase(PhaseType.Stop, 7));
         phaseQueue.Enqueue(new TrafficPhase(PhaseType.Prepare, 2));

         CurrentPhase.Run();

         //execute the Queue elements statrs from the first phase
         while (phaseQueue.Count > 0)
         {
            CurrentPhase = phaseQueue.Dequeue();
            CurrentPhase.Run();
         }

         //set the Go phase as the last phase
         CurrentPhase = new TrafficPhase(PhaseType.Go, 7);
      }
   }
}

