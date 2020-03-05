namespace Ampel
{
   using System;
   using System.Collections.Generic;
   using System.Windows.Forms;

   public class PhaseController
   {
      public Timer Timer = new Timer();

      #region Fields
      private TrafficPhase _CurrentPhase;
      public Queue<TrafficPhase> PhaseQueue = new Queue<TrafficPhase>();
      private Queue<TrafficPhase> WorkingQueue = new Queue<TrafficPhase>();
      #endregion

      #region Properties
      public event EventHandler<PhaseEventArgs> PhaseChanged;
      public string Name { get; private set; }

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
      #region Variables
      private bool initialized = false;
      #endregion
      #region ctor.
      public PhaseController(string name, Queue<TrafficPhase> phaseQueue, PhaseController parent = null, TrafficPhase initialPhase = null)
      {
         Name = name;
         Parent = parent;
         CurrentPhase = initialPhase;
         PhaseQueue = phaseQueue;
         Timer.Interval = 1000;
         Timer.Tick += new EventHandler(Timer_Tick);
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
         if (Parent == null)
         {
            CreateWorkingQueue();
            Timer.Start();
         }
         PerformClockTick();
      }
      #endregion

      #region Event Handling

      public void Timer_Tick(object sender, EventArgs e)
      {
         PerformClockTick();
      }
      private void Parent_PhaseChanged(object sender, PhaseEventArgs e)
      {
         if ((e.MessageType == MessageType.Move) && (e.Time >= 0))
         {
            GoToTime(e.Time);
         }
         else
         {
            if (!initialized)
               CreateWorkingQueue();
         }
         PerformClockTick();
      }
      private void PerformClockTick()
      {
         if (CurrentPhase?.RemainingTime >= 1)
         {
            CurrentPhase.RemainingTime--;
            OnPhaseChanged();
         }
         else
         {
            if (WorkingQueue.Count != 0)
            {
               CurrentPhase = WorkingQueue.Dequeue();
               OnPhaseChanged();
            }
            else
               Timer.Stop();
         }
      }
      #endregion

      public override string ToString()
      {
         return Name;
      }
      public void CreateWorkingQueue()
      {
         initialized = true;
         if (WorkingQueue?.Count == 0)
         {
            foreach (var item in PhaseQueue)
            {
               WorkingQueue.Enqueue(item);
            }
         }
      }
      public void GoToTime(int time)
      {
         //Zeitpunkt bestimmt CurrentPhase und verbleibende Phasen
         var sum = 0;
         var found = false;

         foreach (var phase in PhaseQueue)
         {
            sum += phase.Duration;
            if (sum >= time)
            {
               if (found)
               {
                  WorkingQueue.Enqueue(phase);
               }
               else
               {
                  found = true;
                  CurrentPhase = phase;
                  CurrentPhase.RemainingTime = (sum - time);
                  WorkingQueue.Clear();
               }
            }
         }

         //PhaseEventArgs als Informationspaket instanzieren
         PhaseChanged?.Invoke(this, new PhaseEventArgs(CurrentPhase, MessageType.Move, time));
      }
   }
}