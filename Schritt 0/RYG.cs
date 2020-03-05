namespace Ampel
{
    using System;
    public partial class RYG : Telerik.WinControls.UI.RadForm
    {
        public RYG()
        {
            InitializeComponent();
            Red.Visible = true;
            Yellow.Visible = false;
            Green.Visible = false;
            GreenMan.Visible = true;
            RedMan.Visible = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //switch between the light when the timer is finshed
            if (Red.Visible == true)
            {
                timer1.Interval = 10000;
                Red.Visible = false;
                Yellow.Visible = false;
                Green.Visible = true;
                RedMan.Visible = true;
                GreenMan.Visible = false;
            }
            else if (Green.Visible == true)
            {

                timer1.Interval = 2000;
                Red.Visible = false;
                Yellow.Visible = true;
                Green.Visible = false;
                RedMan.Visible = true;
                GreenMan.Visible = false;
            }
            else if (Yellow.Visible == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 10000;
                Red.Visible = true;
                Yellow.Visible = false;
                Green.Visible = false;
                RedMan.Visible = false;
                GreenMan.Visible = true;
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            //change the light to red when the button clicked
            if (Green.Visible == true)
            {
                timer1.Interval = 2000;
                Red.Visible = false;
                Yellow.Visible = true;
                Green.Visible = false;
                RedMan.Visible = true;
                GreenMan.Visible = false;
            }
            if (Red.Visible == true)
            {
                timer1.Interval = 10000;
                RedMan.Visible = true;
                GreenMan.Visible = false;

            }
            return;
        }
    }
}
