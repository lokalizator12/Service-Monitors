using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Testing_Monitor
{
    public partial class RegionSelectorForm : Form
    {
        private bool isSelecting;
        private Point startPoint;

        public RegionSelectorForm(Screen screen)
        {
            InitializeComponent();
            BackColor = Color.White;
            Opacity = 0.5;
            StartPosition = FormStartPosition.Manual;
            Location = screen.Bounds.Location;
            Size = screen.Bounds.Size;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            MouseDown += RegionSelectorForm_MouseDown;
            MouseMove += RegionSelectorForm_MouseMove;
            MouseUp += RegionSelectorForm_MouseUp;
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        public List<Rectangle> SelectedRegions { get; } = new List<Rectangle>();

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
                using (var g = CreateGraphics())
                {
                    g.Clear(Color.White);
                    var rect = GetRectangle(startPoint, e.Location);
                    g.DrawRectangle(Pens.Red, rect);
                }
        }

        private void RegionSelectorForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                isSelecting = false;
                var rect = GetRectangle(startPoint, e.Location);
                SelectedRegions.Add(rect);
                DialogResult = DialogResult.OK;
                Close();
            }
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