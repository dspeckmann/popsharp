using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DSpeckmann.PopSharp;

namespace DSpeckmann.PopSharpClient
{
    class EmailListBox : ListBox
    {
        public EmailListBox()
            : base()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 30;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // TODO: if necessary? Prevents exception at design time
            if (Items.Count > 0)
            {
                Email currentEmail = (Email)Items[e.Index];

                e.DrawBackground();
                e.Graphics.DrawString(currentEmail.Sender, SystemFonts.DefaultFont, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
                Font subjectFont = new Font(SystemFonts.DefaultFont, FontStyle.Italic);
                e.Graphics.DrawString(currentEmail.Subject, subjectFont, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y + 15));
                e.DrawFocusRectangle();
            }
        }
    }
}
