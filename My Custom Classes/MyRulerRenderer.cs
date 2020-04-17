using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls.Paint;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public class MyRulerRenderer : RulerRenderer
    {
        public MyRulerRenderer(RulerPrimitive ruler)
            : base(ruler)
        {
            this.ruler.MinutesFont = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
        }
        
        public void RenderHour(IGraphics g, int hour, Rectangle bounds)
        {
            using (var sf = new StringFormat())
            {
                var font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
                var hDate = new DateTime(2010, 1, 1, hour, 0, 0, 0);
                g.DrawString(hDate.ToString(CultureInfo.CurrentCulture), bounds, font, ruler.ForeColor, sf, Orientation.Horizontal, false);
            }
        }

        public override void RenderSubHour(IGraphics graphics, int hour, int sectionIndex, RectangleF bounds)
        {
            using (var sf = new StringFormat())
            {
                var font = new Font("IRANSansDNFaNum", 10.0f, FontStyle.Regular);
                var hDate = new DateTime(2010, 1, 1, hour, 0, 0, 0);
                graphics.DrawString(hDate.ToString(CultureInfo.CurrentCulture), bounds, font, ruler.ForeColor, sf, Orientation.Horizontal, false);
            }
        }

        //public override void RenderHour(Telerik.WinControls.Paint.IGraphics g, int hour, Rectangle bounds)
        //{
        //    using (StringFormat sf = new StringFormat())
        //    {
        //        Font font = new Font(this.ruler.Font.FontFamily, 12);
        //        DateTime hDate = new DateTime(2010, 1, 1, hour, 0, 0, 0);
        //        g.DrawString(hDate.ToString(), bounds, font, this.ruler.ForeColor, sf, Orientation.Horizontal, false);
        //    }
        //}
    }
}
