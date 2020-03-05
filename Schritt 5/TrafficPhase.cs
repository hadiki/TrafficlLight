namespace Ampel
{
   using System;
   using System.Windows.Forms;

   class TrafficPhase
   {
      private PhaseType _type;
      private DateTime EndTime;
      private int duration { get; set; }

      //get the type of the phase
      public PhaseType Type
      {
         get { return _type; }
         private set { _type = value; }
      }
      //set the type and the Time of the Phase
      public TrafficPhase(PhaseType type, int interval)
      {
         _type = type;
         duration = interval;
      }
      internal void Run()
      {
         EndTime = DateTime.Now.AddSeconds(duration);
         //block the phase till the time is Finishes
         while (DateTime.Now < EndTime)
         {
            Application.DoEvents();
         }
      }
   }
}

