namespace Ampel
{
   using System.Drawing;
   using System.Windows.Forms;

   internal enum LampState
   {
      On,
      Off
   }

   internal class Lamp : PictureBox
   {
      private LampState _State = LampState.Off;
      public LampState State
      {
         get { return _State; }
         set
         {
            _State = value;
            Image = (value == LampState.On) ? OnImage : OffImage;
         }
      }


      public Image OnImage { get; set; }
      public Image OffImage { get; set; }

      public void Toggle()
      {
      // Switches from the current state to the other state
         State = (State == LampState.On) ? LampState.Off : LampState.On;
      }
   }
}
