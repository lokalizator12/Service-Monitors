using System;
using System.Drawing;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class MonitorTestForm : Form
    {
        private TestOverlay currentTestOverlay;
        string testMode = "Default";
        string testPattern = "Default";
        Color customColor = Color.White;
        private int colorIndex;
        private Color[] testColors = { Color.Red, Color.Green, Color.Blue, Color.White, Color.Black };
        private bool autoCycle = true;
        public MonitorTestForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {


            foreach (var screen in Screen.AllScreens)
            {
                monitorComboBox.Items.Add(screen.DeviceName);
            }
            monitorComboBox.SelectedIndex = 0;
            testModeComboBox.SelectedIndex = 0;
            testPatternComboBox.SelectedIndex = 0;
            for (int i = 0; i < testColors.Length; i++)
            {
                Button colorButton = new Button
                {
                    BackColor = testColors[i],
                    Width = 50,
                    Height = 50,
                    Margin = new Padding(5),
                    Tag = i
                };
                colorButton.Click += ColorButton_Click;
                colorPanel.Controls.Add(colorButton);
            }

        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                colorIndex = (int)button.Tag;
                currentTestOverlay.BackColor = testColors[colorIndex];
                autoCycle = false;
                colorChangeTimer.Stop();
            }
        }
        private void testMonitorButton_Click(object sender, EventArgs e)
        {
            if (currentTestOverlay != null)
            {
                currentTestOverlay.Close();
                currentTestOverlay = null;
            }

            testMode = testModeComboBox.SelectedItem.ToString();
            testPattern = testPatternComboBox.SelectedItem.ToString();
            TestMonitor(testMode, testPattern, customColor);
        }

        private void testModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testModeComboBox.SelectedItem.ToString() == "Custom Pattern")
            {
                testPatternComboBox.Enabled = true;
                selectColorButton.Enabled = true;
            }
            else
            {
                testPatternComboBox.Enabled = false;
                selectColorButton.Enabled = false;
            }
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorChangeTimer.Stop();
                if (currentTestOverlay != null)
                {
                    currentTestOverlay.BackColor = colorDialog1.Color;
                }
                else { TestMonitor(testMode, testPattern, customColor); }
                
                autoCycle = false;
            }
        }

        private void TestMonitor(string testMode, string testPattern, Color customColor)
        {
            Screen selectedScreen = Screen.AllScreens[monitorComboBox.SelectedIndex]; 
            currentTestOverlay = new TestOverlay(testMode, testPattern, customColor);
            currentTestOverlay.StartPosition = FormStartPosition.Manual;
            currentTestOverlay.Location = selectedScreen.Bounds.Location;
            currentTestOverlay.Size = selectedScreen.Bounds.Size;
            currentTestOverlay.FormBorderStyle = FormBorderStyle.None;
            currentTestOverlay.WindowState = FormWindowState.Maximized;
            currentTestOverlay.Show();
        }

        private void colorChangeTimer_Tick(object sender, EventArgs e)
        {
            if (autoCycle)
            {
                colorIndex = (colorIndex + 1) % testColors.Length;
               
                TestMonitor(testMode, "Default", testColors[colorIndex]);
            }
        }

        private void MonitorTestForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                autoCycle = false;
                colorChangeTimer.Stop();
                colorIndex = (colorIndex - 1 + testColors.Length) % testColors.Length;
                this.BackColor = testColors[colorIndex];
            }
            else if (e.KeyCode == Keys.Right)
            {
                autoCycle = false;
                colorChangeTimer.Stop();
                colorIndex = (colorIndex + 1) % testColors.Length;
                this.BackColor = testColors[colorIndex];
            }
        }
    }
}
