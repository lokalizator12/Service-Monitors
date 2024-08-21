using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using ServiceMonitorEVK.Main;
using ServiceMonitorEVK.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Testing_Monitor
{
    public partial class MonitorTestForm : MaterialForm
    {
        public bool AutoCycle = true;

        private readonly List<Color> colors = new List<Color>
        {
            Color.Red,
            Color.Lime,
            Color.Yellow,
            Color.Aqua,
            Color.Magenta,
            Color.Blue,
            Color.Silver,
            Color.Black,
            Color.White
        };

        private int currentColorIndex;
        private TestOverlay currentTestOverlay;
        private Color customColor = Color.Blue;
        private readonly Form1 form1;
        private bool isPinned;
        private MaterialSkinManager materialSkinManager;

        private Point originalPosition;
        private readonly Dictionary<PictureBox, Color> pictureBoxColors = new Dictionary<PictureBox, Color>();
        private Point pinnedPosition;
        private PictureBox previousPictureBox;
        private Screen selectedScreen;
        private string testMode = "Default";
        private string testPattern = "Default";


        public MonitorTestForm(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            FillMonitorComboBox();
            InitizializeCustomForm();

            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
        }


        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {
            InitizializeCustomForm();
            FillMonitorComboBox();
        }



        public void InitizializeCustomForm()
        {

            foreach (Control control in flowLayoutPanel1.Controls)
                if (control is PictureBox pictureBox)
                    pictureBoxColors[pictureBox] = pictureBox.BackColor;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            CheckTheme();
            DrawerAutoShow = true;
        }

        private void CheckTheme()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = false;

            if (form1.materialSwitch1.Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                Accent.Red400,
                TextShade.WHITE);
            foreach (var entry in pictureBoxColors) entry.Key.BackColor = entry.Value;
        }


        private void testModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testModeComboBox1.SelectedItem.ToString() == "Custom Pattern")
            {
                testPatternComboBox1.Enabled = true;
                selectColorButton.Enabled = true;
            }
            else
            {
                testPatternComboBox1.Enabled = false;
                selectColorButton.Enabled = false;
            }
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                colorChangeTimer.Stop();
                if (currentTestOverlay != null)
                    currentTestOverlay.BackColor = colorDialog2.Color;
                else
                    TestMonitor(testMode, testPattern, colorDialog2.Color);

                AutoCycle = false;
            }
        }

        private void StartTest()
        {
            if (currentTestOverlay != null)
            {
                currentTestOverlay.Close();
                currentTestOverlay = null;
            }

            testMode = testModeComboBox1.SelectedItem.ToString();
            testPattern = testPatternComboBox1.SelectedItem == null
                ? "Default"
                : testPatternComboBox1.SelectedItem.ToString();
            TestMonitor(testMode, testPattern, customColor);
        }

        private TestOverlay TestMonitor(string testMode, string testPattern, Color customColor)
        {
            var selectedScreen = Screen.AllScreens[monitorComboBox1.SelectedIndex];
            currentTestOverlay = new TestOverlay(testMode, testPattern, customColor)
            {
                StartPosition = FormStartPosition.Manual,
                Location = selectedScreen.Bounds.Location,
                Size = selectedScreen.Bounds.Size,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = customColor
            };

            currentTestOverlay.Show();
            return currentTestOverlay;
        }

        private void FillMonitorComboBox()
        {
            monitorComboBox1.Items.Clear();

            var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
            var queryObjects = searcher.Get().Cast<ManagementObject>();

            foreach (var queryObj in queryObjects)
            {
                var model = DecodeMonitorString((ushort[])queryObj["UserFriendlyName"]);
                if (string.IsNullOrWhiteSpace(model)) model = "Integrated Monitor";
                monitorComboBox1.Items.Add(model);
            }

            if (monitorComboBox1.Items.Count > 0) monitorComboBox1.SelectedIndex = 0;
        }

        private static string DecodeMonitorString(ushort[] data)
        {
            if (data == null) return string.Empty;

            var result = new StringBuilder();
            foreach (var code in data)
            {
                if (code == 0) break;
                result.Append((char)code);
            }

            return result.ToString();
        }

        private TestOverlay TestMonitor(Color customColor)
        {
            var selectedScreen = Screen.AllScreens[monitorComboBox1.SelectedIndex];
            currentTestOverlay = new TestOverlay(customColor)
            {
                StartPosition = FormStartPosition.Manual,
                Location = selectedScreen.Bounds.Location,
                Size = selectedScreen.Bounds.Size,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = customColor
            };

            currentTestOverlay.Show();
            return currentTestOverlay;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            PictureBox currentPictureBox = null;
            switch (keyData)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    currentPictureBox = pictureBoxRed;
                    changeColorFromPanel(Color.Red);
                    currentColorIndex = 0;
                    return true;
                case Keys.D2:
                case Keys.NumPad2:
                    changeColorFromPanel(Color.Lime);
                    currentPictureBox = pictureBoxLime;
                    currentColorIndex = 1;
                    return true;
                case Keys.D3:
                case Keys.NumPad3:
                    changeColorFromPanel(Color.Yellow);
                    currentPictureBox = pictureBoxYellow;
                    currentColorIndex = 2;
                    return true;
                case Keys.D4:
                case Keys.NumPad4:
                    changeColorFromPanel(Color.Aqua);
                    currentPictureBox = pictureBoxAqua;
                    currentColorIndex = 3;
                    return true;
                case Keys.D5:
                case Keys.NumPad5:
                    changeColorFromPanel(Color.Magenta);
                    currentPictureBox = pictureBoxMagneta;
                    currentColorIndex = 4;
                    return true;
                case Keys.D6:
                case Keys.NumPad6:
                    changeColorFromPanel(Color.Blue);
                    currentPictureBox = pictureBoxBlue;
                    currentColorIndex = 5;
                    return true;
                case Keys.D7:
                case Keys.NumPad7:
                    changeColorFromPanel(Color.Silver);
                    currentPictureBox = pictureBoxSilver;
                    currentColorIndex = 6;
                    return true;
                case Keys.D8:
                case Keys.NumPad8:
                    changeColorFromPanel(Color.White);
                    currentPictureBox = pictureBoxWhite;
                    currentColorIndex = 8;
                    return true;
                case Keys.D9:
                case Keys.NumPad9:
                    changeColorFromPanel(Color.Black);
                    currentPictureBox = pictureBoxBlack;
                    currentColorIndex = 9;
                    return true;
                case Keys.Tab:
                    if (colorDialog2.ShowDialog() == DialogResult.OK)
                    {
                        currentPictureBox = pictureBoxChoose;
                        changeColorFromPanel(colorDialog2.Color);
                    }

                    return true;
                case Keys.Space:
                case Keys.Right:
                    currentColorIndex = (currentColorIndex + 1) % colors.Count;
                    changeColorFromPanel(colors[currentColorIndex]);
                    currentPictureBox = GetPictureBoxByIndex(currentColorIndex);
                    return true;
                case Keys.Left:
                    currentColorIndex = (currentColorIndex - 1 + colors.Count) % colors.Count;
                    customColor = colors[currentColorIndex];
                    currentPictureBox = GetPictureBoxByIndex(currentColorIndex);
                    return true;
                case Keys.Q:
                    SetOverlayBackgroundFromPictureBox(pictureBox5);
                    return true;
                case Keys.W:
                    SetOverlayBackgroundFromPictureBox(pictureBox6);
                    return true;
                case Keys.Control | Keys.S:
                    SaveImage();
                    return true;
                case Keys.X:
                    if (currentTestOverlay != null) currentTestOverlay.ClearMarks();
                    return true;
                case Keys.A:
                    SetMark(Color.Yellow);
                    return true;
                case Keys.S:
                    SetMark(Color.DeepSkyBlue);
                    return true;
                case Keys.D:
                    SetMark(Color.Red);
                    return true;
                case Keys.Escape:
                    Close();
                    return true;
            }

            if (previousPictureBox != null) previousPictureBox.BorderStyle = BorderStyle.FixedSingle;

            if (currentPictureBox != null)
            {
                currentPictureBox.BorderStyle = BorderStyle.Fixed3D;
                previousPictureBox = currentPictureBox;
            }

            Invalidate();
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private PictureBox GetPictureBoxByIndex(int index)
        {
            switch (index)
            {
                case 0: return pictureBoxRed;
                case 1: return pictureBoxLime;
                case 2: return pictureBoxYellow;
                case 3: return pictureBoxAqua;
                case 4: return pictureBoxMagneta;
                case 5: return pictureBoxBlue;
                case 6: return pictureBoxSilver;
                case 7: return pictureBoxBlack;
                case 8: return pictureBoxWhite;
                default: return null;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Red);
        }

        private void pictureBoxLime_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Lime);
        }

        private void pictureBoxYellow_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Yellow);
        }

        private void pictureBoxAqua_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Aqua);
        }

        private void pictureBoxMagneta_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Magenta);
        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Blue);
        }

        private void pictureBoxSilver_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Silver);
        }

        private void pictureBoxWhite_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.White);
        }

        private void pictureBoxBlack_Click(object sender, EventArgs e)
        {
            changeColorFromPanel(Color.Black);
        }

        private void changeColorFromPanel(Color color)
        {
            if (currentTestOverlay != null)
            {
                var tmp = currentTestOverlay;
                currentTestOverlay.Close();
                currentTestOverlay = !currentTestOverlay.TestMode.Equals("Default")
                    ? TestMonitor("Default", "Default", color)
                    : TestMonitor(tmp.TestMode, tmp.TestPattern, color);
            }
            else
            {
                currentTestOverlay = TestMonitor("Default", "Default", color);
            }
        }

        private void pictureBoxChoose_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                if (currentTestOverlay != null)
                    currentTestOverlay.BackColor = colorDialog2.Color;
                else
                    TestMonitor(testMode, testPattern, colorDialog2.Color);

                AutoCycle = false;
            }
        }

        private void materialSliderOpasity_onValueChanged(object sender, int newValue)
        {
            if (newValue > 1)
            {
                Opacity = newValue / 100.0;
                Invalidate();
            }
        }

        private void testModeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            testMode = testModeComboBox1.SelectedIndex.ToString();
            StartTest();
        }

        private void testPatternComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            testPattern = testPatternComboBox1.SelectedIndex.ToString();
            StartTest();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SetMark(Color.Red);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void SetMark(Color color)
        {
            Cursor = Cursors.Cross;
            if (currentTestOverlay != null) currentTestOverlay.SetMarkColor(color);
            Cursor = Cursors.Default;
        }

        private void Clean()
        {
            if (currentTestOverlay != null) currentTestOverlay.ClearMarks();
        }

        private void SaveImage()
        {
            if (currentTestOverlay != null)
            {
                var fileName = $"screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                currentTestOverlay.CaptureScreenshot(fileName);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SetMark(Color.DeepSkyBlue);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SetMark(Color.Yellow);
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SetOverlayBackgroundFromPictureBox(pictureBox6);
        }


        private void SetOverlayBackgroundFromPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.BackgroundImage != null)
            {
                if (currentTestOverlay != null)
                {
                    currentTestOverlay.BackgroundImage = pictureBox.BackgroundImage;
                    currentTestOverlay.BackgroundImageLayout = pictureBox.BackgroundImageLayout;
                }
                else
                {
                    TestMonitorWithBackgroundImage(pictureBox.BackgroundImage, pictureBox.BackgroundImageLayout);
                }
            }
            else
            {
                var selectedColor = pictureBox.BackColor;
                if (currentTestOverlay != null)
                    currentTestOverlay.BackColor = selectedColor;
                else
                    TestMonitor(testMode, testPattern, selectedColor);
            }
        }


        private TestOverlay TestMonitorWithBackgroundImage(Image backgroundImage, ImageLayout layout)
        {
            var selectedScreen = Screen.AllScreens[monitorComboBox1.SelectedIndex];
            currentTestOverlay = new TestOverlay(testMode, testPattern, customColor)
            {
                StartPosition = FormStartPosition.Manual,
                Location = selectedScreen.Bounds.Location,
                Size = selectedScreen.Bounds.Size,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackgroundImage = backgroundImage,
                BackgroundImageLayout = layout
            };

            currentTestOverlay.Show();
            return currentTestOverlay;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SetOverlayBackgroundFromPictureBox(pictureBox5);
        }

        private void MonitorTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentTestOverlay?.Close();
            form1.IsMonitorFormExist = false;
        }

        private void MonitorTestForm_Load(object sender, EventArgs e)
        {
            RoundPictureBoxCorners(pictureBoxSilver, cornerRadius);
            RoundPictureBoxCorners(pictureBoxBlack, cornerRadius);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPinned = !isPinned;

            if (isPinned)
            {
                pictureBox2.Image = Resources.pinOut;
                originalPosition = Location;

                Location = new Point(
                    Screen.PrimaryScreen.WorkingArea.Width - Width,
                    Screen.PrimaryScreen.WorkingArea.Height - Height
                );
            }
            else
            {
                pictureBox2.Image = Resources.push_pin;
                Location = originalPosition;
            }
        }

        private void pictureBox2_Move(object sender, EventArgs e)
        {
            if (isPinned) Location = pinnedPosition;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (currentTestOverlay != null) currentTestOverlay.Close();
        }
    }
}