namespace Ampel
{
   using System;
   using System.Collections.Generic;
   using System.Windows.Forms;
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
      public Timer Timer = new Timer();

      #region Fields
      private TrafficPhase _CurrentPhase;
      public Queue<TrafficPhase> PhaseQueue = new Queue<TrafficPhase>();
      #endregion

      #region Properties
      public event EventHandler<PhaseEventArgs> PhaseChanged;

      private PhaseController parent;
      public PhaseController Parent
      {
         get { return parent; }
         set
         {
            parent = value;
            if (Parent != null)
            {
               parent.PhaseChanged += Parent_PhaseChanged;
            }
         }
      }

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
      public PhaseController(Queue<TrafficPhase> phaseQueue, PhaseController parent = null, TrafficPhase initialPhase = null)
      {
         Parent = parent;
         CurrentPhase = initialPhase;
         PhaseQueue = phaseQueue;
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
         OnPhaseChanged();
         CurrentPhase.RemainingTime = CurrentPhase.Duration;
         if (Parent != null)
            return;

         Timer.Interval = 1000;
         Timer.Start();
         Timer.Tick += new EventHandler(Timer_Tick);
      }
      #endregion

      #region Event Handling

      public void Timer_Tick(object sender, EventArgs e)
      {
         PerformClockTick();
      }
      private void Parent_PhaseChanged(object sender, PhaseEventArgs e)
      {
         PerformClockTick();
      }

      private void PerformClockTick()
      {
         if (CurrentPhase.RemainingTime >= 1)
         {
            CurrentPhase.RemainingTime--;
            OnPhaseChanged();
         }
         else
         {
            if (Parent == null)
               Timer.Stop();
            if (PhaseQueue.Count != 0)
            {
               CurrentPhase = PhaseQueue.Dequeue();
               if (Parent == null)
                  Timer.Start();
            }
            OnPhaseChanged();
         }
      }
      #endregion
   }
}