namespace Ampel
{
   using System;
   using System.Windows.Forms;

 /// <summary>
 /// Carry the Remaining Time Value
 /// </summary>
   internal class RemainingTimeEventArgs : EventArgs
   {
      public int RemainingTime { get; }
      public RemainingTimeEventArgs(int remainingTime)
      {
         RemainingTime = remainingTime;
      }
   }
   internal class TrafficPhase
   {
      private Timer Timer = new Timer();

      /// <summary>Tritt ein nachdem die Phase abgelaufen ist</summary>
      public event EventHandler Done;

      /// <summary>Tritt ein nachdem sich die verbleibende Zeit geändert hat</summary>
      public event EventHandler<RemainingTimeEventArgs> Elapsed;

      private int remainingTime;

      /// <summary>
      /// Initializes a new instance of a traffic light phase
      /// </summary>
      /// <param name="type">Desired phase type</param>
      /// <param name="interval">Desired duration of the phase</param>
      public PhaseType Type { get; private set; }
      private int Duration;
     
      //set the type and the Time of the Phase
      public TrafficPhase(PhaseType type, int duration)
      {
         Type = type;
         Duration = duration;
         Timer.Interval = 1000;
         Timer.Tick += new EventHandler(Timer_Tick);
      }
   //Run the Next phase
      internal void Run()
      {
         remainingTime = Duration;
         Timer.Start();
      }
      protected virtual void OnDone()
      {
         Done(this, EventArgs.Empty);
      }
    //loop every Second and Check of the Remaining time 
      private void Timer_Tick(object sender, EventArgs e)
      {
         if (remainingTime > 0)
         {
            Elapsed?.Invoke(this, new RemainingTimeEventArgs(remainingTime));
            remainingTime--;
         }
         else
         {
            Timer.Stop();
            OnDone();
         }
      }
   }
}