namespace Ampel
{
   /// <summary>
   /// Carry the Remaining Time Value
   /// </summary>
   public class TrafficPhase : object
   {
      /// <summary>Tritt ein nachdem die Phase abgelaufen ist</summary>
//      public event EventHandler<PhaseEventArgs> Done;

      /// <summary>Tritt ein nachdem sich die verbleibende Zeit geändert hat</summary>
  //    internal event EventHandler<PhaseEventArgs> Elapsed;

      public int RemainingTime { get;  set; }

      /// <summary>
      /// Initializes a new instance of a traffic light phase
      /// </summary>
      /// <param name="type">Desired phase type</param>
      /// <param name="interval">Desired duration of the phase</param>
      public PhaseType Type { get; private set; }
      public int Duration { get; private set; }

      //set the type and the Time of the Phase
      public TrafficPhase(PhaseType type, int duration = 0)
      {
         Type = type;
         Duration = duration;
         RemainingTime = Duration;
      }

      public override string ToString()
      {
         return $"{Type.ToString()} ({RemainingTime} left of {Duration}sec.)";
      }
   }
}