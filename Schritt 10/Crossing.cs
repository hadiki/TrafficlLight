namespace Ampel
{
   using System;
   using System.Windows.Forms;
   using System.Collections.Generic;

   public partial class Crossing : Form
   {
      public PhaseController MainController, SubController;
      //Create a Queue
      public Queue<TrafficPhase> MainPhaseQueue = new Queue<TrafficPhase>();
      public Queue<TrafficPhase> SubPhaseQueue = new Queue<TrafficPhase>();

      public Crossing()
      {

         InitializeComponent();
         MainController = new PhaseController(MainPhaseQueue, initialPhase: new TrafficPhase(PhaseType.Go, 8));
         SubController = new PhaseController(SubPhaseQueue, MainController, new TrafficPhase(PhaseType.Stop));

         MainTrafficLight1.Controller =
           MainTrafficLight2.Controller = MainController;
         SubTrafficLight1.Controller =
            SubTrafficLight2.Controller = SubController;
      }
      private void CarHasArrived(object sender, EventArgs e)
      {
         CreateMainQueue(this, EventArgs.Empty);
         CreateSubQueue(this, EventArgs.Empty);
         MainController.Start();
      }
      public void CreateMainQueue(object sender, EventArgs e)
      {
         //Add phases to the Queue and set the Current phase for the Controller

         var phase = new TrafficPhase(PhaseType.Attention, 2);//Yelllow
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Stop, 15);//Red
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Prepare, 2);//Red, Yellow
         MainPhaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Go, 0);//Green
         MainPhaseQueue.Enqueue(phase);
      }
      public void CreateSubQueue(object sender, EventArgs e)
      {
         //Add phases to the Queue and set the Current phase for the Controller
         var phase = new TrafficPhase(PhaseType.Stop,10);//Red
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