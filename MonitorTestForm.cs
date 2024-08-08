using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class MonitorTestForm : MaterialForm
    {
        private TestOverlay currentTestOverlay;
        private string testMode = "Default";
        private string testPattern = "Default";
        private Color customColor = Color.Blue;
        Form1 form1;
        private ResolutionDisplayManager resolutionManager;

        private Dictionary<string, string> monitorNameToIdentifierMap;
        private PictureBox previousPictureBox = null;
        private int currentColorIndex = 0;
        private List<Color> colors = new List<Color>
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
        private bool autoCycle = true;
        private Screen selectedScreen;
        private MaterialSkinManager materialSkinManager;
        private MonitorInfoManager monitorInfoManager;
        private Dictionary<PictureBox, Color> pictureBoxColors = new Dictionary<PictureBox, Color>();


        public MonitorTestForm()
        {
            resolutionManager = new ResolutionDisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            InitializeComponent();
            FillMonitorComboBox();
            // InitializeCustomComponents();
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
        }

        public MonitorTestForm(Form1 form)
        {
            resolutionManager = new ResolutionDisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            form1 = form;
            InitializeComponent();
            FillMonitorComboBox();
            InitizializeCustomForm();

            //InitializeCustomComponents();
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
        }


        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {

            InitizializeCustomForm();
            FillMonitorComboBox();


        }
        private void InitializeCustomComponents()
        {
            // selectedScreen = monitorInfoManager.SetScreenToComboBoxAndGetNonIntegred(monitorComboBox1);\
            FillMonitorComboBox();

        }
        public void InitizializeCustomForm()
        {
            foreach (Control control in colorPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBoxColors[pictureBox] = pictureBox.BackColor;
                }
            }
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            checkTheme();
            DrawerAutoShow = true;
        }
        private void checkTheme()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = false;

            if (form1.materialSwitch1.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            }
            materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                        Accent.Red400,
                        TextShade.WHITE);
            foreach (var entry in pictureBoxColors)
            {
                entry.Key.BackColor = entry.Value;
            }
        }


        private void testMonitorButton_Click(object sender, EventArgs e)
        {
            startTest();
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
                {
                    currentTestOverlay.BackColor = colorDialog2.Color;
                }
                else
                {
                    TestMonitor(testMode, testPattern, colorDialog2.Color);
                }

                autoCycle = false;
            }
        }

        private void startTest()
        {
            if (currentTestOverlay != null)
            {
                currentTestOverlay.Close();
                currentTestOverlay = null;
            }

            testMode = testModeComboBox1.SelectedItem.ToString();
            testPattern = testPatternComboBox1.SelectedItem == null ? "Default" : testPatternComboBox1.SelectedItem.ToString();
            TestMonitor(testMode, testPattern, customColor);
        }

        private TestOverlay TestMonitor(string testMode, string testPattern, Color customColor)
        {
            Screen selectedScreen = Screen.AllScreens[monitorComboBox1.SelectedIndex];
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
                string model = DecodeMonitorString((ushort[])queryObj["UserFriendlyName"]);
                if (string.IsNullOrWhiteSpace(model))
                {
                    model = "Integrated Monitor";
                }
                monitorComboBox1.Items.Add(model);
            }

            if (monitorComboBox1.Items.Count > 0)
            {
                monitorComboBox1.SelectedIndex = 0;
            }

        }

        private static string DecodeMonitorString(ushort[] data)
        {
            if (data == null) return string.Empty;

            StringBuilder result = new StringBuilder();
            foreach (ushort code in data)
            {
                if (code == 0) break;
                result.Append((char)code);
            }

            return result.ToString();
        }
        private TestOverlay TestMonitor(Color customColor)
        {
            Screen selectedScreen = Screen.AllScreens[monitorComboBox1.SelectedIndex];
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
                    changeColorFromPanel(Color.Black);
                    currentPictureBox = pictureBoxBlack;
                    currentColorIndex = 7;
                    return true;
                case Keys.D9:
                case Keys.NumPad9:
                    changeColorFromPanel(Color.White);
                    currentPictureBox = pictureBoxWhite;
                    currentColorIndex = 8;
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
                default:
                    break;
            }

            if (previousPictureBox != null)
            {
                previousPictureBox.BorderStyle = BorderStyle.FixedSingle;
            }

            if (currentPictureBox != null)
            {
                currentPictureBox.BorderStyle = BorderStyle.Fixed3D;
                previousPictureBox = currentPictureBox;
            }
            this.Invalidate();
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
        private void colorChangeTimer_Tick(object sender, EventArgs e)
        {
        }

        private void monitorTestForm_KeyDown(object sender, KeyEventArgs e)
        {

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
                TestOverlay tmp = currentTestOverlay;
                currentTestOverlay.Close();
                currentTestOverlay = (!currentTestOverlay.testMode.Equals("Default") ? TestMonitor("Default", "Default", color) : TestMonitor(tmp.testMode, tmp.testPattern, color));
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
                {
                    currentTestOverlay.BackColor = colorDialog2.Color;
                }
                else
                {
                    TestMonitor(testMode, testPattern, colorDialog2.Color);
                }

                autoCycle = false;
            }
        }

        private void materialSliderOpasity_onValueChanged(object sender, int newValue)
        {
            if (newValue > 1)
            {
                this.Opacity = newValue / 100.0;
                this.Invalidate();
            }
        }

        private void testModeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            testMode = testModeComboBox1.SelectedIndex.ToString();
            startTest();
        }

        private void testPatternComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            testPattern = testPatternComboBox1.SelectedIndex.ToString();
            startTest();
        }
    }
}

