using System.ComponentModel;
using System.Runtime.InteropServices;
using static PanelTitlebarExample.Win32Helpers;
namespace PanelTitlebarExample
{
    public class PanelEx : Panel
    {
        private Color titlebarBackColor = Color.Black;
        [DefaultValue(typeof(Color), "Black")]
        public Color TitlebarBackColor
        {
            get { return titlebarBackColor; }
            set
            {
                if (titlebarBackColor != value)
                {
                    titlebarBackColor = value;
                    Redraw();
                }
            }
        }

        private Color titlebarForeColor = Color.White;
        [DefaultValue(typeof(Color), "White")]
        public Color TitlebarForeColor
        {
            get { return titlebarForeColor; }
            set
            {
                if (titlebarForeColor != value)
                {
                    titlebarForeColor = value;
                    Redraw();
                }
            }
        }

        private bool showTitlebar = true;
        [DefaultValue(true)]
        public bool ShowTitlebar
        {
            get { return showTitlebar; }
            set
            {
                if (showTitlebar != value)
                {
                    showTitlebar = value;
                    RecalculateClientSize();
                    Redraw();
                }
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Redraw();
            }
        }

        private Font titlebarFont = DefaultFont;
        public virtual Font TitlebarFont
        {
            get
            {
                return titlebarFont;
            }
            set
            {
                if (titlebarFont != value)
                {
                    titlebarFont = value;
                    RecalculateClientSize();
                    Redraw();
                }
            }
        }
        private bool ShouldSerializeTitlebarFont()
        {
            return TitlebarFont != DefaultFont;
        }
        private void ResetTitlebarFont()
        {
            TitlebarFont = DefaultFont;
        }

        private Padding titlebarTextPadding = new Padding(5, 10, 5, 10);
        [DefaultValue(typeof(Padding), "5,10,5,10")]
        public virtual Padding TitlebarTextPadding
        {
            get
            {
                return titlebarTextPadding;
            }
            set
            {
                if (titlebarTextPadding != value)
                {
                    titlebarTextPadding = value;
                    RecalculateClientSize();
                    Redraw();
                }
            }
        }

        public virtual int GetTitlebarHeight()
        {
            return (int)TitlebarFont.GetHeight() +
                titlebarTextPadding.Top +
                titlebarTextPadding.Bottom;
        }

        public virtual Rectangle GetTitlebarRectangle()
        {
            return new Rectangle(0, 0, Width, GetTitlebarHeight());
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCPAINT)
            {
                base.WndProc(ref m);
                WmNCPaint(ref m);
            }
            else if (m.Msg == WM_NCCALCSIZE)
            {
                base.WndProc(ref m);
                WmNCCalcSize(ref m);
            }
            else
                base.WndProc(ref m);

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Redraw();
        }

        private void Redraw()
        {
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
               RDW_FRAME | RDW_INVALIDATE | RDW_UPDATENOW);
        }

        private void RecalculateClientSize()
        {
            SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0,
                SWP_NOSIZE | SWP_NOMOVE | SWP_FRAMECHANGED | SWP_NOZOORDER);
        }

        private void WmNCCalcSize(ref Message m)
        {
            var h = ShowTitlebar ? GetTitlebarHeight() : 0;
            var b = BorderStyle == BorderStyle.FixedSingle ? 1 :
               BorderStyle == BorderStyle.Fixed3D ? 2 : 0;

            if (m.WParam != IntPtr.Zero)
            {
                var nccsp = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALCSIZE_PARAMS));
                nccsp.rgrc[0].top += h - b;
                nccsp.rgrc[0].bottom -= 0;
                nccsp.rgrc[0].left += 0;
                nccsp.rgrc[0].right -= 0;
                Marshal.StructureToPtr(nccsp, m.LParam, true);
                InvalidateRect(this.Handle, nccsp.rgrc[0], true);
                m.Result = IntPtr.Zero;
            }
        }

        private void WmNCPaint(ref Message m)
        {
            if (!ShowTitlebar)
                return;

            var dc = GetWindowDC(Handle);
            using (var g = Graphics.FromHdc(dc))
            {
                using (var b = new SolidBrush(TitlebarBackColor))
                    g.FillRectangle(b, GetTitlebarRectangle());
                if (BorderStyle != BorderStyle.None)
                    using (var p = new Pen(TitlebarBackColor))
                        g.DrawRectangle(p, 0, 0,
                            Width - 1, Height - 1);

                var tf = TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter;
                if (RightToLeft == RightToLeft.Yes)
                    tf |= TextFormatFlags.Right | TextFormatFlags.RightToLeft;
                var t = GetTitlebarRectangle();
                var r = new Rectangle(
                    t.Left + TitlebarTextPadding.Left,
                    t.Top,
                    t.Width - TitlebarTextPadding.Left - TitlebarTextPadding.Right,
                    t.Height);
                TextRenderer.DrawText(g, Text, TitlebarFont, r, TitlebarForeColor, tf);
            }
            ReleaseDC(Handle, dc);
            m.Result = IntPtr.Zero;
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            var size = base.GetPreferredSize(proposedSize);
            if (ShowTitlebar)
                size.Height += GetTitlebarHeight();
            return size;
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
            RecalculateClientSize();
            Redraw();
        }
    }
}
