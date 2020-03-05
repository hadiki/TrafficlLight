namespace Ampel
{
   using System;
   public enum PhaseType
   {
      Go,
      Attention,
      Stop,
      Prepare
   }
   public enum LampState
   {
      On,
      Off
   }

   public enum TrafficLightPurpose
   {
      Traffic,
      Pedestrian
   }
   public enum MessageType
   {
      Move,
      Tick
   }
   public class PhaseEventArgs : EventArgs
   {
      public TrafficPhase Phase { get; }
      public int Time { get; set; }
      public MessageType MessageType { get; private set; }
      public PhaseEventArgs(TrafficPhase phase, MessageType messageType = MessageType.Tick, int time = 0)
      {
         Phase = phase;
         MessageType = messageType;
         Time = time; 
      }
   }
}
