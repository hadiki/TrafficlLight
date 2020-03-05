namespace Ampel
{
   /// <summary>
   /// Carry the Remaining Time Value
   /// </summary>
   public class TrafficPhase
    {

      public int RemainingTime { get; set; }

      /// <summary>
      /// Initializes a new instance of a traffic light phase
      /// </summary>
      /// <param name="type">Desired phase type</param>
      /// <param name="interval">Desired duration of the phase</param>
      public PhaseType Type { get; set; }
      private int _Duration;

      public int Duration
      {
         get { return _Duration; }
         set
         {
            _Duration = value;
            RemainingTime = Duration;
         }
      }

      //set the type and the Time of the Phase
      public TrafficPhase(PhaseType type, int duration = 0)
      {
         Type = type;
         Duration = duration;
      }

      public override string ToString()
      {
         return $"{Type.ToString()} ({RemainingTime} left of {Duration}sec.)";
      }
   }
}