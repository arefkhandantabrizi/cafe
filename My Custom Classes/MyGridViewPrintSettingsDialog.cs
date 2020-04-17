using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public class MyGridViewPrintSettingsDialog : GridViewPrintSettingsDialog
    {
        public MyGridViewPrintSettingsDialog(RadPrintDocument document)
            : base(document)
        {
            
        }
        protected override void LoadSettings()
        {
            base.LoadSettings();

            RightToLeft = RightToLeft.Yes;
            AutoSize = true;
            RightToLeftLayout = true;
            Font = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
            SetFontForControls(this);
        }

        private static void SetFontForControls(Control parentControl)
        {
            var font = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
            parentControl.Font = font;
            var allControls = ControlHelper.GetChildControls<Control>(parentControl, true);
            foreach (var c in allControls)
            {
                c.Font = font;
                
            }
        }

    }
}
