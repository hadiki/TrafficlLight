namespace Ampel
{
   using System;
   using System.Windows.Forms;
   using System.Collections.Generic;

   public partial class Crossing : Form
   {
      PhaseController MainController, SubController;
      //Create a Queue
      public Queue<TrafficPhase> MainPhaseQueue = new Queue<TrafficPhase>();
      public Queue<TrafficPhase> SubPhaseQueue = new Queue<TrafficPhase>();

      public Crossing()
      {
         InitializeComponent();
         MainController = new PhaseController("E/W", MainPhaseQueue);
         SubController = new PhaseController("N/S", SubPhaseQueue, MainController);

         NorthTrafficLight.Switch(PhaseType.Stop);
         SouthTrafficLight.Switch(PhaseType.Stop);
         EastTrafficLight.Switch(PhaseType.Go);
         WestTrafficLight.Switch(PhaseType.Go);

         MainController.PhaseChanged += Controller_PhaseChanged;
         SubController.PhaseChanged += Controller_PhaseChanged;
      }

      private void Controller_PhaseChanged(object sender, PhaseEventArgs args)
      {
         if (sender.ToString() == "N/S")
         {
            NorthTrafficLight.Switch(args);
            SouthTrafficLight.Switch(args);
         }
         else
         {
            EastTrafficLight.Switch(args);
            WestTrafficLight.Switch(args);
         }
      }

      private void CarHasArrived(object sender, EventArgs e)
      {
         CreateMainQueue(this, EventArgs.Empty);
         CreateSubQueue(this, EventArgs.Empty);
         MainController.Start();
      }
      public void CreateMainQueue(object sender, EventArgs e)
      {
         MainPhaseQueue.Clear();

         //Add phases to the Queue and set the Current phase for the Controller
         var phase = new TrafficPhase(PhaseType.Go, 8);//Yelllow
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Attention, 2);//Yelllow
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Stop, 13);//Red
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Prepare, 2);//Red, Yellow
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Go, 0);//Green
         MainPhaseQueue.Enqueue(phase);

      }
      public void CreateSubQueue(object sender, EventArgs e)
      {
         SubPhaseQueue.Clear();

         //Add phases to the Queue and set the Current phase for the Controller
         var phase = new TrafficPhase(PhaseType.Stop, 10);//Red
         SubPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Prepare, 2);//Red, Yellow
         SubPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Go, 8);//Green
         SubPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Attention, 2);//Yellow
         SubPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Stop, 0);//Red
         SubPhaseQueue.Enqueue(phase);
      }

   }
}