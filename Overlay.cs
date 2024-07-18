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
            if (isMulticolor)
            {
                this.BackColor = repairColors[0];
            }
            else
            {
                this.BackColor = currentColor;
            }
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
            this.Invalidate();
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

            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (repairRegions.Count > 0)
            {
                using (Graphics g = e.Graphics)
                {
                    g.Clear(Color.Black); // Очистка экрана черным цветом
                    foreach (var region in repairRegions)
                    {
                        // Масштабируем координаты и размеры region в пределах клиентской области
                        Rectangle scaledRegion = ScaleRegionToClientSize(region);

                        // Проверяем корректность координат и размеров прямоугольника
                        if (IsValidRectangle(scaledRegion))
                        {
                            try
                            {
                                g.FillRectangle(new SolidBrush(this.BackColor), scaledRegion);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ошибка при рисовании прямоугольника: {ex.Message}\n" +
                                                $"Координаты: {scaledRegion.X}, {scaledRegion.Y}, {scaledRegion.Width}, {scaledRegion.Height}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Некорректные параметры прямоугольника: {scaledRegion.X}, {scaledRegion.Y}, {scaledRegion.Width}, {scaledRegion.Height}");
                        }
                    }
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }

        private Rectangle ScaleRegionToClientSize(Rectangle region)
        {
            float xRatio = (float)this.ClientSize.Width / (float)Screen.PrimaryScreen.Bounds.Width;
            float yRatio = (float)this.ClientSize.Height / (float)Screen.PrimaryScreen.Bounds.Height;

            return new Rectangle(
                (int)(region.X * xRatio),
                (int)(region.Y * yRatio),
                (int)(region.Width * xRatio),
                (int)(region.Height * yRatio)
            );
        }

        private bool IsValidRectangle(Rectangle rect)
        {
            return rect.X >= 0 && rect.Y >= 0 &&
                   rect.Width > 0 && rect.Height > 0 &&
                   rect.X + rect.Width <= this.ClientSize.Width &&
                   rect.Y + rect.Height <= this.ClientSize.Height;
        }
    }
}
