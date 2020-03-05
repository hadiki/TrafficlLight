namespace Ampel
{
   using System;
   using System.Windows.Forms;

   public partial class TrafficLight : UserControl
   {
      public event EventHandler Clicked;

      //control the Visibility of the Button
      public bool HasContactLoop
      {
         get { return BtnContact.Visible; }
         set
         {
            BtnContact.Visible = value;
            Invalidate();
            Application.DoEvents();
         }
      }

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
         lblCountDown.Text = e.Phase.RemainingTime.ToString("00");
         //change the Light depands on the phase
         RedLight.State = (e.Phase.Type == PhaseType.Stop) || (e.Phase.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
         YellowLight.State = (e.Phase.Type == PhaseType.Attention) || (e.Phase.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
         GreenLight.State = (e.Phase.Type == PhaseType.Go) ? LampState.On : LampState.Off;
         Invalidate();
         Application.DoEvents();
      }

      private void BtnContact_Click(object sender, EventArgs e)
      {
         Clicked?.Invoke(this, EventArgs.Empty);
      }
   }
}