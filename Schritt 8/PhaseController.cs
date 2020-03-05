namespace Ampel
{
   using System;
   using System.Collections.Generic;
   enum PhaseType
   {
      Go,
      Attention,
      Stop,
      Prepare
   }
   public class PhaseEventArgs : EventArgs
   {
      internal TrafficPhase Phase { get; }
      internal int RemainingTime { get; }
      internal PhaseEventArgs(TrafficPhase phase, int remainingTime)
      {
         Phase = phase;
         RemainingTime = remainingTime;
      }
   }

   public class PhaseController
   {
      #region Fields
      private TrafficPhase _CurrentPhase;
      private int remainingTime;
      private Queue<TrafficPhase> phaseQueue = new Queue<TrafficPhase>();
      #endregion

      #region Properties
      public event EventHandler<PhaseEventArgs> PhaseChanged;
      internal TrafficPhase CurrentPhase
      {
         get { return _CurrentPhase; }
         set
         {
            _CurrentPhase = value;
         }
      }
      #endregion

      #region ctor.
      public PhaseController()
      {
         CurrentPhase = new TrafficPhase(PhaseType.Go, 8);
         CurrentPhase.Done += Phase_Done;
         CurrentPhase.Elapsed += Phase_Elapsed;
      }
      #endregion

      #region Methods
      private void InitQueue(object sender, EventArgs e)
      {
         //Add the phases to a Queue with the time duration
         var phase = new TrafficPhase(PhaseType.Attention, 3);
         phase.Done += Phase_Done;
         phase.Elapsed += Phase_Elapsed;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Stop, 8);
         phase.Done += Phase_Done;
         phase.Elapsed += Phase_Elapsed;
         phaseQueue.Enqueue(phase);

         phase = new TrafficPhase(PhaseType.Prepare, 2);
         phase.Done += Phase_Done;
         phase.Elapsed += Phase_Elapsed;
         phaseQueue.Enqueue(phase);

         // Aktuelle Phase Go ist am Ende wieder Ausgangszustand
         phaseQueue.Enqueue(CurrentPhase);
      }


      protected virtual void OnPhaseChanged()
      {
         PhaseChanged?.Invoke(this, new PhaseEventArgs(CurrentPhase, remainingTime));
      }
      //start the sequence of the phases
      public void Start()
      {
         if (phaseQueue.Count == 0)
         {
            InitQueue(this, EventArgs.Empty);
            CurrentPhase.Run();
         }
      }
      #endregion

      #region Event Handling
      //handling the Count Down value
      private void Phase_Elapsed(object sender, RemainingTimeEventArgs e)
      {
         remainingTime = e.RemainingTime;
         OnPhaseChanged();
      }

      private void Phase_Done(object sender, EventArgs e)
      {
         //execute the next phase in the Queue
         if (phaseQueue.Count != 0)
         {
            CurrentPhase = phaseQueue.Dequeue();
            CurrentPhase.Run();
         }
         OnPhaseChanged();
      }
      #endregion


   }
}