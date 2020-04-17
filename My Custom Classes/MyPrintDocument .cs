using System.Drawing;
using System.Drawing.Printing;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    public class MyPrintDocument : RadPrintDocument
    {
        public string RightUpperText { get; set; }
        public Font RightUpperFont { get; set; }
        public string RightMiddleText { get; set; }
        public Font RightMiddleFont { get; set; }
        public string RightLowerText { get; set; }
        public Font RightLowerFont { get; set; }
        protected override void PrintHeader(PrintPageEventArgs args)
        {
            base.PrintHeader(args);
            var headerRect = new Rectangle(args.MarginBounds.Location, new Size(args.MarginBounds.Width, HeaderHeight));
            var stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
                FormatFlags = StringFormatFlags.NoClip ,
                LineAlignment = StringAlignment.Near
            };
            args.Graphics.DrawString(RightUpperText, RightUpperFont, Brushes.Black, new Rectangle(headerRect.X, headerRect.Y, headerRect.Width , headerRect.Height), stringFormat);
            args.Graphics.DrawString(RightMiddleText, RightMiddleFont, Brushes.Black, new Rectangle(headerRect.X, headerRect.Y + headerRect.Height / 3, headerRect.Width , headerRect.Height ), stringFormat);
            args.Graphics.DrawString(RightLowerText, RightLowerFont, Brushes.Black, new Rectangle(headerRect.X, headerRect.Y + (headerRect.Height) * 2 / 3, headerRect.Width, headerRect.Height), stringFormat);
            args.Graphics.DrawLine(new Pen(Brushes.Black), headerRect.Location, new Point(headerRect.Location.X + headerRect.Width, headerRect.Location.Y));
        }

    }
}
