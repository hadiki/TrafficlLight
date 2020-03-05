namespace Ampel
{
   using System;
   using System.Windows.Forms;
   public partial class PedestrianLight : UserControl
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
      public PedestrianLight()
      {
         InitializeComponent();

      }
      private void Controller_PhaseChanged(object sender, PhaseEventArgs e)
      {
         //change the label to the current value
         if (GreenLight.State == LampState.On)
         {
            lblCountDown.Text = e.RemainingTime.ToString("00");
         }
         //change the Light depands on the phase
         GreenLight.State = (e.Phase.Type == PhaseType.Stop) ? LampState.On : LampState.Off;
         RedLight.State = (e.Phase.Type == PhaseType.Go || e.Phase.Type == PhaseType.Prepare || e.Phase.Type == PhaseType.Attention) ? LampState.On : LampState.Off;
         Invalidate();
         Application.DoEvents();
      }

      private void BtnStop_Click(object sender, EventArgs e)
      {
         Controller.Start();
      }
   }
}
