namespace Ampel
{
   using System;
   using System.Windows.Forms;

   internal class TrafficPhase
   {
      private Timer Timer = new Timer();
      public event EventHandler Done;
      /// <summary>
      /// Initializes a new instance of a traffic light phase
      /// </summary>
      /// <param name="type">Desired phase type</param>
      /// <param name="interval">Desired duration of the phase</param>
      public PhaseType Type { get; private set; }
     
      //set the type and the Time of the Phase
      public TrafficPhase(PhaseType type, int interval)
      {
         Type = type;
         Timer.Interval = interval * 1000;
         Timer.Tick += new EventHandler(Timer_Tick);
      }
      internal void Run()
      {
         Timer.Start();
      }
      private void Timer_Tick(object sender, EventArgs e)
      {
         Timer.Stop();
         Done(this, EventArgs.Empty);
      }
   }
}

