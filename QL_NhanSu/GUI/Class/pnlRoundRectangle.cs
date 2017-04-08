using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI.Class
{
    class pnlRoundRectangle : Panel
    {
        private int radius = 0;
        private Color boderColor;
        private Color innerColor = Color.White;

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0 && value * 2 < this.Width && value * 2 < this.Height)
                {
                    radius = value;
                    Invalidate();
                }
            }
        }

        public Color BoderColor
        {
            get
            {
                return boderColor;
            }

            set
            {
                boderColor = value;
            }
        }

        public Color InnerColor
        {
            get
            {
                return innerColor;
            }

            set
            {
                innerColor = value;
                Invalidate();
            }
        }

        public pnlRoundRectangle() : base() { this.Height = 30; this.Width = 90; this.Paint += PnlRoundRectangle_Paint; }

        private void PnlRoundRectangle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath gp = GetGraphicsPath(this.Width, this.Height, radius);
            e.Graphics.FillPath(new SolidBrush(this.innerColor), gp);
            if (boderColor != Color.Empty) e.Graphics.DrawPath(new Pen(boderColor), gp);
        }

        private GraphicsPath GetGraphicsPath(int width, int height, int r)
        {
            r *= 2;
            GraphicsPath grp = new GraphicsPath();
            grp.StartFigure();
            if (r > 0)
            {
                grp.AddArc(0, 0, r, r, 180, 90);
                grp.AddArc(width - r - 1, 0, r, r, 270, 90);
                grp.AddArc(width - r - 1, height - r - 1, r, r, 0, 90);
                grp.AddArc(0, height - r - 1, r, r, 90, 90);
            }
            else grp.AddRectangle(new Rectangle(0, 0, width - 1, height - 1));
            grp.CloseFigure();
            return grp;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Refresh();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            this.Refresh();
        }
    }
}
