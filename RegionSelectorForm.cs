using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class RegionSelectorForm : Form
    {
        public List<Rectangle> SelectedRegions { get; private set; } = new List<Rectangle>();
        private bool isSelecting = false;
        private Point startPoint;
        private Screen selectedScreen;

        public RegionSelectorForm(Screen screen)
        {
            InitializeComponent();
            this.selectedScreen = screen;
            this.BackColor = Color.White;
            this.Opacity = 0.5;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = screen.Bounds.Location;
            this.Size = screen.Bounds.Size;
        }

            private void RegionSelectorForm_Load(object sender, EventArgs e)
        {

        }

        private void RegionSelectorForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isSelecting = true;
                startPoint = e.Location;
            }
        }

        private void RegionSelectorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.Clear(Color.White);
                    Rectangle rect = GetRectangle(startPoint, e.Location);
                    g.DrawRectangle(Pens.Red, rect);
                }
            }
        }

        private void RegionSelectorForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                isSelecting = false;
                Rectangle rect = GetRectangle(startPoint, e.Location);

                if (IsValidRectangle(rect))
                {
                    SelectedRegions.Add(rect);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"Некорректные параметры прямоугольника: {rect.X}, {rect.Y}, {rect.Width}, {rect.Height}");
                }
                this.Close();
            }
        }
        private bool IsValidRectangle(Rectangle rect)
        {
            return rect.X >= 0 && rect.Y >= 0 &&
                   rect.Width > 0 && rect.Height > 0 &&
                   rect.X + rect.Width <= this.ClientSize.Width &&
                   rect.Y + rect.Height <= this.ClientSize.Height;
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }
    }
}
