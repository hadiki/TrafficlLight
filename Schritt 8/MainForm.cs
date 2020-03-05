namespace Ampel
{
   using System;
   using System.Windows.Forms;
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         var controller = new PhaseController();

         trafficLight1.Controller =
            trafficLight2.Controller =
            pedestrianLight1.Controller =
            pedestrianLight2.Controller = controller;

      }
   }
}

