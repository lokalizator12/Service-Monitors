using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class TestOverlay : Form
    {

        private string testMode;
        private string testPattern;
        private Color customColor;
        private int direction = 0;
        public TestOverlay(Color customColor)
        {
            InitializeComponent();
            this.customColor = customColor;
        }
        private Dictionary<string, int> patternParameters = new Dictionary<string, int>()
        {
            { "spacing", 20 },
            { "radius", 50 },
            { "size", 50 },
            {"number of lines", 10},
            {"number cells", 8 }
        };

        public TestOverlay(string testMode, string testPattern, Color customColor)
        {
            InitializeComponent();
            this.testMode = testMode;
            this.testPattern = testPattern;
            this.customColor = customColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            switch (testMode)
            {
                case "Default":
                    DrawOnlyBackground();
                    break;
                case "Color Spectrum":
                    DrawColorSpectrum(e.Graphics);
                    break;
                case "Grayscale Gradient":
                    DrawGrayscaleGradient(e.Graphics);
                    break;
                case "Color Lines":
                    DrawColorLines(e.Graphics);
                    break;
                case "Checkerboard":
                    DrawCheckerboard(e.Graphics);
                    break;
                case "Circular Gradient":
                    DrawCircularGradient(e.Graphics);
                    break;

            }
        }

        private void DrawOnlyBackground()
        {
            this.BackColor = customColor;
        }
        private void DrawCircularGradient(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            PathGradientBrush brush = new PathGradientBrush(path)
            {
                CenterColor = Color.White,
                SurroundColors = new Color[] { Color.Black }
            };

            g.FillEllipse(brush, rect);
        }
        private void DrawCheckerboard(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            int numCells = patternParameters["number cells"];
            int cellWidth = rect.Width / numCells;
            int cellHeight = rect.Height / numCells;

            for (int y = 0; y < numCells; y++)
            {
                for (int x = 0; x < numCells; x++)
                {
                    using (Brush brush = new SolidBrush((x + y) % 2 == 0 ? Color.Black : Color.White))
                    {
                        g.FillRectangle(brush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                    }
                }
            }
        }
        private void DrawColorLines(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            int numberOfLines = patternParameters["number of lines"];

            for (int i = 0; i < numberOfLines; i++)
            {
                using (Pen pen = new Pen(ColorFromHSV(i * (360 / numberOfLines), 1, 1), 5))
                {
                    g.DrawLine(pen, 0, (i + 1) * rect.Height / (numberOfLines + 1), rect.Width, (i + 1) * rect.Height / (numberOfLines + 1));
                }
            }
        }
        private void DrawColorSpectrum(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            for (int i = 0; i < (direction % 2 == 0 ? rect.Width : rect.Height); i++)
            {
                float hue = (float)i / (direction % 2 == 0 ? rect.Width : rect.Height);
                Color color = ColorFromHSV(hue * 360, 1, 1);
                using (Pen pen = new Pen(color))
                {
                    switch (direction)
                    {
                        case 0: // Left to Right
                            g.DrawLine(pen, i, 0, i, rect.Height);
                            break;
                        case 1: // Right to Left
                            g.DrawLine(pen, rect.Width - i - 1, 0, rect.Width - i - 1, rect.Height);
                            break;
                        case 2: // Top to Bottom
                            g.DrawLine(pen, 0, i, rect.Width, i);
                            break;
                        case 3: // Bottom to Top
                            g.DrawLine(pen, 0, rect.Height - i - 1, rect.Width, rect.Height - i - 1);
                            break;
                    }
                }
            }
        }

        private void DrawGrayscaleGradient(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            int length = (direction % 2 == 0 ? rect.Width : rect.Height);

            for (int i = 0; i <= length; i++)
            {
                int intensity = (int)(255 * ((float)i / length));
                Color color = Color.FromArgb(intensity, intensity, intensity);
                using (Pen pen = new Pen(color))
                {
                    switch (direction)
                    {
                        case 0: // Left to Right
                            g.DrawLine(pen, i, 0, i, rect.Height);
                            break;
                        case 1: // Right to Left
                            g.DrawLine(pen, rect.Width - i - 2, 0, rect.Width - i - 2, rect.Height);
                            break;
                        case 2: // Top to Bottom
                            g.DrawLine(pen, 0, i, rect.Width, i);
                            break;
                        case 3: // Bottom to Top
                            g.DrawLine(pen, 0, rect.Height - i, rect.Width, rect.Height - i);
                            break;
                    }
                }
            }
        }

        private void DrawCustomPattern(Graphics g)
        {
            if (testPattern == "Chessboard")
            {
                DrawChessboardPattern(g);
            }
            else if (testPattern == "Circles")
            {
                DrawCirclesPattern(g);
            }
            else if (testPattern == "Lines")
            {
                DrawLinesPattern(g);
            }
        }

        private void DrawChessboardPattern(Graphics g)
        {
            int size = patternParameters["size"];
            bool isWhite = true;
            for (int y = 0; y < this.ClientRectangle.Height; y += size)
            {
                for (int x = 0; x < this.ClientRectangle.Width; x += size)
                {
                    using (Brush brush = new SolidBrush(isWhite ? Color.White : customColor))
                    {
                        if (direction == 0)
                            g.FillRectangle(brush, x, y, size, size);
                        else if (direction == 1)
                            g.FillRectangle(brush, this.ClientRectangle.Width - x - size, y, size, size);
                        else if (direction == 2)
                            g.FillRectangle(brush, x, y, size, size); // Top to Bottom
                        else if (direction == 3)
                            g.FillRectangle(brush, x, this.ClientRectangle.Height - y - size, size, size);
                    }
                    isWhite = !isWhite;
                }
                isWhite = !isWhite;
            }
        }

        private void DrawCirclesPattern(Graphics g)
        {
            int radius = patternParameters["radius"];
            for (int y = 0; y < this.ClientRectangle.Height; y += radius * 2)
            {
                for (int x = 0; x < this.ClientRectangle.Width; x += radius * 2)
                {
                    using (Brush brush = new SolidBrush(customColor))
                    {
                        if (direction == 0)
                            g.FillEllipse(brush, x, y, radius * 2, radius * 2);
                        else if (direction == 1)
                            g.FillEllipse(brush, this.ClientRectangle.Width - x - radius * 2, y, radius * 2, radius * 2);
                        else if (direction == 2)
                            g.FillEllipse(brush, x, y, radius * 2, radius * 2);
                        else if (direction == 3)
                            g.FillEllipse(brush, x, this.ClientRectangle.Height - y - radius * 2, radius * 2, radius * 2);
                    }
                }
            }
        }

        private void DrawLinesPattern(Graphics g)
        {
            int spacing = patternParameters["spacing"];
            using (Pen pen = new Pen(customColor))
            {
                for (int y = 0; y < this.ClientRectangle.Height; y += spacing)
                {
                    if (direction == 0 || direction == 1)
                        g.DrawLine(pen, 0, y, this.ClientRectangle.Width, y);
                    else
                        g.DrawLine(pen, y, 0, y, this.ClientRectangle.Height);
                }
                for (int x = 0; x < this.ClientRectangle.Width; x += spacing)
                {
                    if (direction == 0 || direction == 1)
                        g.DrawLine(pen, x, 0, x, this.ClientRectangle.Height);
                    else
                        g.DrawLine(pen, 0, x, this.ClientRectangle.Width, x);
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

        private void TestOverlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void TestOverlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                direction = (direction + 1) % 4;
                this.Invalidate();
            }
        }

        private void TestOverlay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (testPattern == "Chessboard" || testPattern == "Circles" || testPattern == "Lines")
            {
                if (e.Delta > 0)
                {
                    patternParameters["size"] += 5;
                    patternParameters["radius"] += 5;
                    patternParameters["spacing"] += 2;
                    patternParameters["number of lines"] += 1;
                    patternParameters["number cells"] += 1;
                }
                else if (e.Delta < 0)
                {
                    patternParameters["size"] = Math.Max(5, patternParameters["size"] - 5);
                    patternParameters["radius"] = Math.Max(5, patternParameters["radius"] - 5);
                    patternParameters["spacing"] = Math.Max(2, patternParameters["spacing"] - 2);
                    patternParameters["number cells"] = Math.Max(2, patternParameters["number cells"] - 1);
                    patternParameters["number of lines"] = Math.Max(1, patternParameters["number of lines"] - 1);

                }
                this.Invalidate(); // Перерисовать форму
            }
        }

        private void TestOverlay_Load(object sender, EventArgs e)
        {

        }
    }
}
