namespace Ampel
{
   using System;
   using System.Collections.Generic;
   public enum PhaseType
   {
      Go,
      Attention,
      Stop,
      Prepare
   }
   public class PhaseEventArgs : EventArgs
   {
      internal TrafficPhase Phase { get; }
      internal PhaseEventArgs(TrafficPhase phase)
      {
         Phase = phase;
      }
   }

   public class PhaseController
   {
      #region Fields
      private TrafficPhase _CurrentPhase;
      public Queue<TrafficPhase> PhaseQueue = new Queue<TrafficPhase>();
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

      }
      #endregion

      #region Methods
      protected virtual void OnPhaseChanged()
      {
         PhaseChanged?.Invoke(this, new PhaseEventArgs(CurrentPhase));
      }
      //start the sequence of the phases and Inform the Events 
      public void Start()
      {
         CurrentPhase.Done += Phase_Done;
         CurrentPhase.Elapsed += Phase_Elapsed;
         CurrentPhase.Run();
      }
      #endregion

      #region Event Handling
      //handling the Count Down value
      private void Phase_Elapsed(object sender, PhaseEventArgs e)
      {
         OnPhaseChanged();
      }

      private void Phase_Done(object sender, EventArgs e)
      {
         //execute the next phase in the Queue and inform the Events
         if (PhaseQueue.Count != 0)
         {
            CurrentPhase = PhaseQueue.Dequeue();
            CurrentPhase.Done += Phase_Done;
            CurrentPhase.Elapsed += Phase_Elapsed;
            CurrentPhase.Run();
         }
         OnPhaseChanged();
      }
      #endregion
   }
}