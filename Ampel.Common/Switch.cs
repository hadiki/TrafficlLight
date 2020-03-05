
namespace Ampel
{
   using System.Windows.Forms;

   class Switch5000 : Control, ISwitch
   {
      public bool On { get; private set; }

      public void Switch()
      {
         On = !On;
      }
   }


}
