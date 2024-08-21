using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceMonitorEVK
{
    public partial class Overlay : Form
    {
        private int colorIndex;
        private readonly Color currentColor;
        private bool isFlashing;
        private readonly bool isMulticolor;
        private readonly List<Color> repairColors;
        private readonly List<Rectangle> repairRegions;
        private readonly string testMode;

        public Overlay(Color color, int interval, bool isMulticolor, bool isSingleColor, List<Color> repairColors,
            List<Rectangle> repairRegions, string testMode)
        {
            InitializeComponent();
            timer1.Interval = CurrentInterval = interval;
            currentColor = color;
            this.isMulticolor = isMulticolor;
            this.repairColors = repairColors;
            this.repairRegions = repairRegions;
            this.testMode = testMode;
            if (isMulticolor) BackColor = repairColors[colorIndex];
            if (isSingleColor)
            {
                BackColor = color;
            }
            else
            {
                BackColor = Color.White;
                Opacity = 1;
            }
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        public int CurrentInterval { get; set; }

        public void StartFlashing()
        {
            isFlashing = true;
            timer1.Interval = CurrentInterval;
            timer1.Start();
        }

        public void StopFlashing()
        {
            isFlashing = false;
            timer1.Stop();
            BackColor = isMulticolor ? repairColors[0] : currentColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMulticolor)
            {
                colorIndex = (colorIndex + 1) % repairColors.Count;
                BackColor = repairColors[colorIndex];
            }
            else
            {
                BackColor = BackColor == currentColor ? Color.Black : currentColor;
            }

            if (repairRegions.Count > 0)
                using (var g = CreateGraphics())
                {
                    foreach (var region in repairRegions) g.FillRectangle(new SolidBrush(BackColor), region);
                }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            switch (testMode)
            {
                case "Color Spectrum":
                    DrawColorSpectrum(e.Graphics);
                    break;
                case "Grayscale Gradient":
                    DrawGrayscaleGradient(e.Graphics);
                    break;
            }
        }

        private void DrawColorSpectrum(Graphics g)
        {
            var rect = ClientRectangle;
            for (var i = 0; i < rect.Width; i++)
            {
                var hue = (float)i / rect.Width;
                var color = ColorFromHsv(hue * 360, 1, 1);
                using (var pen = new Pen(color))
                {
                    g.DrawLine(pen, i, 0, i, rect.Height);
                }
            }
        }

        private void DrawGrayscaleGradient(Graphics g)
        {
            var rect = ClientRectangle;
            for (var i = 0; i < rect.Width; i++)
            {
                var intensity = (int)(255 * ((float)i / rect.Width));
                var color = Color.FromArgb(intensity, intensity, intensity);
                using (var pen = new Pen(color))
                {
                    g.DrawLine(pen, i, 0, i, rect.Height);
                }
            }
        }

        private Color ColorFromHsv(double hue, double saturation, double value)
        {
            var hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            var f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            var v = Convert.ToInt32(value);
            var p = Convert.ToInt32(value * (1 - saturation));
            var q = Convert.ToInt32(value * (1 - f * saturation));
            var t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0:
                    return Color.FromArgb(255, v, t, p);
                case 1:
                    return Color.FromArgb(255, q, v, p);
                case 2:
                    return Color.FromArgb(255, p, v, t);
                case 3:
                    return Color.FromArgb(255, p, q, v);
                case 4:
                    return Color.FromArgb(255, t, p, v);
                default:
                    return Color.FromArgb(255, v, p, q);
            }
        }
    }
}