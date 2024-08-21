using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ServiceMonitorEVK.Properties;
using static Mysqlx.Crud.Order.Types;

namespace ServiceMonitorEVK.Testing_Monitor
{
    public sealed partial class TestOverlay : Form
    {
        private readonly Dictionary<Rectangle, Color> areaColors = new Dictionary<Rectangle, Color>();

        private readonly List<Color> colors = new List<Color>
        {
            Color.Red,
            Color.Lime,
            Color.Yellow,
            Color.Aqua,
            Color.Magenta,
            Color.Blue,
            Color.Gray,
            Color.Black,
            Color.White
        };

        private int currentColorIndex;
        private Color currentMarkColor = Color.Red; // Default color for marking
        private Rectangle currentRect;
        private Color customColor;
        private int Direction = 0;
        private bool isDrawing;

        private readonly List<Rectangle> markedAreas = new List<Rectangle>();

        private readonly Dictionary<string, int> patternParameters = new Dictionary<string, int>
        {
            { "spacing", 20 },
            { "radius", 50 },
            { "size", 50 },
            { "number of lines", 10 },
            { "number cells", 8 }
        };

        public string TestMode;
        public string TestPattern;

        public TestOverlay(Color customColor)
        {
            InitializeComponent();
            this.customColor = customColor;
            TestMode = "Default";
            TestPattern = "Default";

            ///////////////////
            DoubleBuffered = true;
        }

        public TestOverlay(string testMode, string testPattern, Color customColor)
        {
            InitializeComponent();
            this.TestMode = testMode;
            this.TestPattern = testPattern;
            this.customColor = customColor;
            /////////////////////
            DoubleBuffered = true;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            switch (TestMode)
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
                case "Custom Pattern":
                    DrawCustomPattern(e.Graphics);
                    break;
            }

            /////////////////
            foreach (var area in markedAreas) DrawCircle(e.Graphics, area, areaColors[area]);

            if (isDrawing) DrawCircle(e.Graphics, currentRect, currentMarkColor);

            if (markedAreas.Count > 0) DrawLegend(e.Graphics);
        }

        private static void DrawCircle(Graphics g, Rectangle rect, Color color)
        {
            using (var pen = new Pen(color, 2))
            {
                g.DrawEllipse(pen, rect);
            }
        }

        private void DrawLegend(Graphics g)
        {
            const string legendText = "Red: Scratch, Blue: Dead Pixel, Yellow: Burn-in";
            using (var font = new Font("Arial", 10, FontStyle.Bold))
            {
                var textSize = g.MeasureString(legendText, font);
                var legendRect = new RectangleF(new PointF(10, ClientSize.Height - textSize.Height - 10), textSize);
                using (Brush brush = new SolidBrush(Color.White))
                {
                    g.FillRectangle(brush, legendRect);
                }

                using (Brush brush = new SolidBrush(Color.Black))
                {
                    g.DrawString(legendText, font, brush, new PointF(10, ClientSize.Height - textSize.Height - 10));
                }
            }
        }

        private void DrawOnlyBackground()
        {
            BackColor = customColor;
            Invalidate();
        }

        private void DrawCircularGradient(Graphics g)
        {
            var rect = ClientRectangle;
            var path = new GraphicsPath();
            path.AddEllipse(rect);
            var brush = new PathGradientBrush(path)
            {
                CenterColor = Color.White,
                SurroundColors = new[] { Color.Black }
            };

            g.FillEllipse(brush, rect);
        }

        private void DrawCheckerboard(Graphics g)
        {
            var rect = ClientRectangle;
            var numCells = patternParameters["number cells"];
            var cellWidth = rect.Width / numCells;
            var cellHeight = rect.Height / numCells;

            for (var y = 0; y < numCells; y++)
            for (var x = 0; x < numCells; x++)
                using (Brush brush = new SolidBrush((x + y) % 2 == 0 ? Color.Black : Color.White))
                {
                    g.FillRectangle(brush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                }
        }

        private void DrawColorLines(Graphics g)
        {
            var rect = ClientRectangle;
            var numberOfLines = patternParameters["number of lines"];

            for (var i = 0; i < numberOfLines; i++)
                using (var pen = new Pen(ColorFromHsv(i * (360 / numberOfLines), 1, 1), 5))
                {
                    g.DrawLine(pen, 0, (i + 1) * rect.Height / (numberOfLines + 1), rect.Width,
                        (i + 1) * rect.Height / (numberOfLines + 1));
                }
        }

        private void DrawColorSpectrum(Graphics g)
        {
            var rect = ClientRectangle;
            for (var i = 0; i < (Direction % 2 == 0 ? rect.Width : rect.Height); i++)
            {
                var hue = (float)i / (Direction % 2 == 0 ? rect.Width : rect.Height);
                var color = ColorFromHsv(hue * 360, 1, 1);
                using (var pen = new Pen(color))
                {
                    switch (Direction)
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
            var rect = ClientRectangle;
            var length = Direction % 2 == 0 ? rect.Width : rect.Height;

            for (var i = 0; i <= length; i++)
            {
                var intensity = (int)(255 * ((float)i / length));
                var color = Color.FromArgb(intensity, intensity, intensity);
                using (var pen = new Pen(color))
                {
                    switch (Direction)
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


        private void DrawCustomPattern(Graphics g)
        {
            switch (TestPattern)
            {
                case "Chessboard":
                    DrawChessboardPattern(g);
                    break;
                case "Circles":
                    DrawCirclesPattern(g);
                    break;
                case "Lines":
                    DrawLinesPattern(g);
                    break;
            }
        }

        private void DrawChessboardPattern(Graphics g)
        {
            var size = patternParameters["size"];
            var isWhite = true;
            for (var y = 0; y < ClientRectangle.Height; y += size)
            {
                for (var x = 0; x < ClientRectangle.Width; x += size)
                {
                    using (Brush brush = new SolidBrush(isWhite ? Color.White : customColor))
                    {
                        switch (Direction)
                        {
                            case 0:
                                g.FillRectangle(brush, x, y, size, size);
                                break;
                            case 1:
                                g.FillRectangle(brush, ClientRectangle.Width - x - size, y, size, size);
                                break;
                            case 2:
                                g.FillRectangle(brush, x, y, size, size); // Top to Bottom
                                break;
                            case 3:
                                g.FillRectangle(brush, x, ClientRectangle.Height - y - size, size, size);
                                break;
                        }
                    }

                    isWhite = !isWhite;
                }

                isWhite = !isWhite;
            }
        }

        private void DrawCirclesPattern(Graphics g)
        {
            var radius = patternParameters["radius"];
            for (var y = 0; y < ClientRectangle.Height; y += radius * 2)
            for (var x = 0; x < ClientRectangle.Width; x += radius * 2)
                using (Brush brush = new SolidBrush(customColor))
                {
                    switch (Direction)
                    {
                        case 0:
                            g.FillEllipse(brush, x, y, radius * 2, radius * 2);
                            break;
                        case 1:
                            g.FillEllipse(brush, ClientRectangle.Width - x - radius * 2, y, radius * 2, radius * 2);
                            break;
                        case 2:
                            g.FillEllipse(brush, x, y, radius * 2, radius * 2);
                            break;
                        case 3:
                            g.FillEllipse(brush, x, ClientRectangle.Height - y - radius * 2, radius * 2, radius * 2);
                            break;
                    }
                }
        }

        private void DrawLinesPattern(Graphics g)
        {
            var spacing = patternParameters["spacing"];
            using (var pen = new Pen(customColor))
            {
                for (var y = 0; y < ClientRectangle.Height; y += spacing)
                    if (Direction == 0 || Direction == 1)
                        g.DrawLine(pen, 0, y, ClientRectangle.Width, y);
                    else
                        g.DrawLine(pen, y, 0, y, ClientRectangle.Height);
                for (var x = 0; x < ClientRectangle.Width; x += spacing)
                    if (Direction == 0 || Direction == 1)
                        g.DrawLine(pen, x, 0, x, ClientRectangle.Height);
                    else
                        g.DrawLine(pen, 0, x, ClientRectangle.Width, x);
            }
        }

        private static Color ColorFromHsv(double hue, double saturation, double value)
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
                default:
                    return hi == 4 ? Color.FromArgb(255, t, p, v) : Color.FromArgb(255, v, p, q);
            }
        }

        private void TestOverlay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    customColor = Color.Red;
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    customColor = Color.Lime;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    customColor = Color.Yellow;
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    customColor = Color.Aqua;
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    customColor = Color.Magenta;
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    customColor = Color.Blue;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    customColor = Color.Gray;
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    customColor = Color.Black;
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    customColor = Color.White;
                    break;
                case Keys.Tab:
                    if (colorDialog1.ShowDialog() == DialogResult.OK) customColor = colorDialog1.Color;
                    break;
                case Keys.Space:
                case Keys.Right:
                    currentColorIndex = (currentColorIndex + 1) % colors.Count;
                    customColor = colors[currentColorIndex];
                    break;
                case Keys.Left:
                    currentColorIndex = (currentColorIndex - 1 + colors.Count) % colors.Count;
                    customColor = colors[currentColorIndex];
                    break;
                case Keys.Q:
                    BackgroundImage = Resources.win_back;
                    break;
                case Keys.W:
                    BackgroundImage = Resources.color_pallete;
                    break;
                case Keys.Control | Keys.S:
                    CaptureScreenshot($"screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png");
                    break;
                case Keys.X:
                    ClearMarks();
                    break;
                case Keys.A:
                    SetMarkColor(Color.Yellow);
                    break;
                case Keys.S:
                    SetMarkColor(Color.DeepSkyBlue);
                    break;
                case Keys.D:
                    SetMarkColor(Color.Red);
                    break;
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Up: // Изменение направления
                    Direction = (Direction + 1) % 4; // Переключение направления
                    Invalidate(); // Перерисовка формы после смены направления
                    break;
                case Keys.Down: // Изменение направления в обратном порядке
                    Direction = (Direction - 1 + 4) % 4;
                    Invalidate(); // Перерисовка формы после смены направления
                    break;
            }

            Invalidate();
        }


        private void TestOverlay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (TestPattern == "Chessboard" || TestPattern == "Circles" || TestPattern == "Lines")
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

                Invalidate(); // Перерисовать форму
            }
        }


        private void TestOverlay_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                currentRect = new Rectangle(e.Location, new Size(0, 0));
            }
        }

        private void TestOverlay_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                var radius = Math.Max(Math.Abs(e.X - currentRect.X), Math.Abs(e.Y - currentRect.Y));
                currentRect.Width = radius * 2;
                currentRect.Height = radius * 2;
                currentRect.X = e.X - radius;
                currentRect.Y = e.Y - radius;
                Invalidate();
            }
        }

        private void TestOverlay_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                markedAreas.Add(currentRect);
                areaColors[currentRect] = currentMarkColor;
                Invalidate();
            }
        }

        public void ClearMarks()
        {
            markedAreas.Clear();
            areaColors.Clear();
            Invalidate();
        }

        public void SetMarkColor(Color color)
        {
            currentMarkColor = color;
        }

        public void CaptureScreenshot(string fileName)
        {
            var directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
            var filePath = Path.Combine(directoryPath, fileName);

            using (var bitmap = new Bitmap(ClientSize.Width, ClientSize.Height))
            {
                DrawToBitmap(bitmap, new Rectangle(Point.Empty, ClientSize));
                using (var g = Graphics.FromImage(bitmap))
                {
                    DrawLegend(g);
                }

                bitmap.Save(filePath, ImageFormat.Png);
            }
        }
    }
}