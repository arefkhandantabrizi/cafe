using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public class MyPrintSettingsDiagloFactory : IPrintSettingsDialogFactory
    {
        public Form CreateDialog(RadPrintDocument document)
        {
            return new MyGridViewPrintSettingsDialog(document);
        }
    }
 
}
