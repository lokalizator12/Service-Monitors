using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class Overlay : Form
    {
        private Color currentColor;
        private bool isFlashing = false;
        private bool isMulticolor = false;
        private List<Color> repairColors;
        private List<Rectangle> repairRegions;
        public int currentInterval { get; set; }
        private int colorIndex = 0;
        private Action updateProgress;
        private string testMode;

        public Overlay(Color color, int interval, bool isMulticolor, List<Color> repairColors, List<Rectangle> repairRegions, string testMode)
        {
            InitializeComponent();
            timer1.Interval = currentInterval = interval;
            this.currentColor = color;
            this.isMulticolor = isMulticolor;
            this.repairColors = repairColors;
            this.repairRegions = repairRegions;
            this.testMode = testMode;
            if (isMulticolor)
            {
                this.BackColor = repairColors[colorIndex];
            }
            else
            {
                this.BackColor = color;
            }
        }

        public void StartFlashing()
        {
            isFlashing = true;
            timer1.Interval = currentInterval;
            timer1.Start();
        }

        public void StopFlashing()
        {
            isFlashing = false;
            timer1.Stop();
            if (isMulticolor)
            {
                this.BackColor = repairColors[0];
            }
            else
            {
                this.BackColor = currentColor;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMulticolor)
            {
                colorIndex = (colorIndex + 1) % repairColors.Count;
                this.BackColor = repairColors[colorIndex];
            }
            else
            {
                if (this.BackColor == currentColor)
                {
                    this.BackColor = Color.Black;
                }
                else
                {
                    this.BackColor = currentColor;
                }
            }

            if (repairRegions.Count > 0)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    foreach (var region in repairRegions)
                    {

                        g.FillRectangle(new SolidBrush(this.BackColor), region);
                    }
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (testMode == "Color Spectrum")
            {
                DrawColorSpectrum(e.Graphics);
            }
            else if (testMode == "Grayscale Gradient")
            {
                DrawGrayscaleGradient(e.Graphics);
            }
        }

        private void DrawColorSpectrum(Graphics g)
        {
            // Логика для рисования цветового спектра
            Rectangle rect = this.ClientRectangle;
            for (int i = 0; i < rect.Width; i++)
            {
                float hue = (float)i / rect.Width;
                Color color = ColorFromHSV(hue * 360, 1, 1);
                using (Pen pen = new Pen(color))
                {
                    g.DrawLine(pen, i, 0, i, rect.Height);
                }
            }
        }

        private void DrawGrayscaleGradient(Graphics g)
        {
            // Логика для рисования градиента в оттенках серого
            Rectangle rect = this.ClientRectangle;
            for (int i = 0; i < rect.Width; i++)
            {
                int intensity = (int)(255 * ((float)i / rect.Width));
                Color color = Color.FromArgb(intensity, intensity, intensity);
                using (Pen pen = new Pen(color))
                {
                    g.DrawLine(pen, i, 0, i, rect.Height);
                }
            }
        }

        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
    }
}
