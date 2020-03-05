namespace Ampel
{
   using System.Windows.Forms;

   public partial class TrafficLight : UserControl
   {
      private PhaseController _Controller;
      public PhaseController Controller
      {
         get { return _Controller; }
         set
         {
            _Controller = value;
            if (_Controller != null)
               _Controller.PhaseChanged += Controller_PhaseChanged;
         }
      }

      public TrafficLight()
      {
         InitializeComponent();
      }
      private void Controller_PhaseChanged(object sender, PhaseEventArgs e)
      {
         //change the label to the current value
         lblCountDown.Text = e.RemainingTime.ToString("00");

         //change the Light depands on the phase
         RedLight.State = (e.Phase.Type == PhaseType.Stop) || (e.Phase.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
         YellowLight.State = (e.Phase.Type == PhaseType.Attention) || (e.Phase.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
         GreenLight.State = (e.Phase.Type == PhaseType.Go) ? LampState.On : LampState.Off;
         Invalidate();
         Application.DoEvents();
      }
      
   }
}