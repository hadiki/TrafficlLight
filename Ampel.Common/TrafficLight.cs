namespace Ampel
{
   using System;
   using System.Windows.Forms;

   public partial class TrafficLight : UserControl
   {
      public event EventHandler LoopImpulseReceived;

      private TrafficLightPurpose _Purpose;
      public TrafficLightPurpose Purpose
      {
         get { return _Purpose; }
         set
         {
            if (_Purpose == value)
            {
               return;
            }
            _Purpose = value;
            OnPurposeChanged();
         }
      }
    
      //Control the Visibility of the ButtonA
      public bool HasContactLoop
      {
         get { return BtnContact.Visible; }
         set
         {
            BtnContact.Visible = value;
            if (BtnContact.Visible == false)
            {
               RedLight.State = LampState.Off;
               YellowLight.State = LampState.Off;
               GreenLight.State = LampState.On;
            }
            Invalidate();
            Application.DoEvents();
         }
      }

      

      public TrafficLight()
      {
         InitializeComponent();
      }

      public void Switch(PhaseType phaseType)
      {
         if (Purpose == TrafficLightPurpose.Traffic)
         {
            YellowLight.State = (phaseType == PhaseType.Attention) || (phaseType == PhaseType.Prepare) ? LampState.On : LampState.Off;
         }
         RedLight.State = (phaseType == PhaseType.Stop) || (phaseType == PhaseType.Prepare) ? LampState.On : LampState.Off;
         GreenLight.State = (phaseType == PhaseType.Go) ? LampState.On : LampState.Off;
         Invalidate();
         Application.DoEvents();
      }

      public void Switch(PhaseEventArgs e)
      {
         //change the Light depands on the phase
         if (Purpose == TrafficLightPurpose.Traffic)
         {
            YellowLight.State = (e.Phase.Type == PhaseType.Attention) || (e.Phase.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
         }
         //change the label to the current value
         lblCountDown.Text = e.Phase.RemainingTime.ToString("00");
         RedLight.State = (e.Phase.Type == PhaseType.Stop) || (e.Phase.Type == PhaseType.Prepare) ? LampState.On : LampState.Off;
         GreenLight.State = (e.Phase.Type == PhaseType.Go) ? LampState.On : LampState.Off;
         Invalidate();
         Application.DoEvents();
      }
      protected virtual void OnPurposeChanged()
      {
         YellowLight.Visible = (Purpose == TrafficLightPurpose.Traffic);
         LampPanel.Size = (Purpose == TrafficLightPurpose.Traffic) ? LampPanel.MaximumSize : LampPanel.MinimumSize;
         LampPanel.Invalidate();
         Invalidate();
         Application.DoEvents();
      }

      private void BtnContact_Click(object sender, System.EventArgs e)
      {
         LoopImpulseReceived?.Invoke(this, EventArgs.Empty);
      }
   }
}