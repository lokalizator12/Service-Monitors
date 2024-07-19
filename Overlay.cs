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
        private int colorIndex = 0;

        public Overlay(Color color, int interval, bool isMulticolor, List<Color> repairColors, List<Rectangle> repairRegions)
        {
            InitializeComponent();
            timer1.Interval = interval;
            this.currentColor = color;
            this.isMulticolor = isMulticolor;
            this.repairColors = repairColors;
            this.repairRegions = repairRegions;

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
    }
}
