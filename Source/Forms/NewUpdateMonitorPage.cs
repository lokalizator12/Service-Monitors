using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ServiceMonitorEVK.Source.Main;
using System.Threading.Tasks;
using ServiceMonitorEVK.Source.Utils;

namespace ServiceMonitorEVK.Source.Forms
{

    public partial class NewMonitorFormat : MaterialForm
    {

        public MonitorInfo monitor { get; private set; }

        public NewMonitorFormat(MonitorInfo monitorInfo)
        {
            InitializeComponent();
            UiUtil uiUtil = new UiUtil(this);
            uiUtil.InitializeTheme();
            monitor = monitorInfo;
            LoadBasicInfo();
                // FillTextBoxFromMonitor();
        }
        private void LoadBasicInfo()
        {
            textBoxChangeManufacturer.Text = monitor.Manufacturer;
            textBoxChangeEvkModel.Text = monitor.EvkModel;
            textBoxChangeSystemModel.Text = monitor.SystemModel;
            textBoxChangeTypeMatrix.Text = monitor.PanelType;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Загружаем остальные данные асинхронно
            await LoadDetailsAsync();
        }

        private async Task LoadDetailsAsync()
        {
            textBoxChangeDiagonal.Text = monitor.Diagonal1.ToString(CultureInfo.InvariantCulture);
            textBoxChangeResponseTime.Text = monitor.ResponseTime;
            textBoxChangeResolution.Text = monitor.Resolution;
            textBoxChangeFrequency.Text = monitor.Frequency.ToString();
            textBoxChangeViewAngles.Text = monitor.ViewingAngles;
            textBoxChangeScreenFormat.Text = monitor.AspectRatio;
            textBoxChangeSizeMonitor.Text = monitor.Dimensions;
            textBoxChangeBrightness.Text = monitor.Brightness;
            textBoxChangeWeight.Text = monitor.Weight;

            // Обработка кабелей
            UpdateCableInputs(monitor.CableTypes);
        }
       
        private void EnableCableInput(Dictionary<string, int> cables, string cableType, CheckBox checkBox, NumericUpDown numericUpDown)
        {
            if (cables.ContainsKey(cableType))
            {
                checkBox.Checked = true;
                numericUpDown.Value = cables[cableType];
                numericUpDown.Enabled = true;
            }
            else
            {
                checkBox.Checked = false;
                numericUpDown.Enabled = false;
            }
        }

        private void UpdateCableInputs(string cableInfo)
        {
            ResetCableInputs();
            if (string.IsNullOrWhiteSpace(cableInfo)) return;

            var cables = cableInfo.Split(';')
                .Select(c => c.Trim())
                .Where(c => !string.IsNullOrEmpty(c))
                .ToDictionary(
                    c => c.Split(' ')[0],
                    c => int.Parse(c.Split('x')[1]));

            EnableCableInput(cables, "HDMI", checkBoxChangeHDMI, numericUpDownChangeHdmi);
            EnableCableInput(cables, "VGA", checkBoxChangeVGA, numericUpDownChangeVga);
            EnableCableInput(cables, "DVI", checkBoxChangeDVI, numericUpDownChangeDvi);
            EnableCableInput(cables, "DisplayPort", checkBoxChangeDisplayPort, numericUpDownChangeDisplayPort);
        }
        

        private void ResetCableInputs()
        {
            checkBoxChangeHDMI.Checked = false;
            numericUpDownChangeHdmi.Value = 1;
            numericUpDownChangeHdmi.Enabled = false;

            checkBoxChangeVGA.Checked = false;
            numericUpDownChangeVga.Value = 1;
            numericUpDownChangeVga.Enabled = false;

            checkBoxChangeDVI.Checked = false;
            numericUpDownChangeDvi.Value = 1;
            numericUpDownChangeDvi.Enabled = false;

            checkBoxChangeDisplayPort.Checked = false;
            numericUpDownChangeDisplayPort.Value = 1;
            numericUpDownChangeDisplayPort.Enabled = false;
        }

        private void UpdateMonitorInfosFromElements()
        {
            monitor.Diagonal1 = Convert.ToDouble(textBoxChangeDiagonal.Text);
            monitor.Manufacturer = textBoxChangeManufacturer.Text;
            monitor.EvkModel = textBoxChangeEvkModel.Text;
            monitor.SystemModel = textBoxChangeSystemModel.Text;
            monitor.PanelType = textBoxChangeTypeMatrix.Text;
            monitor.ResponseTime = textBoxChangeResponseTime.Text;
            monitor.Resolution = textBoxChangeResolution.Text;
            monitor.Brightness = textBoxChangeBrightness.Text;
            monitor.Weight = textBoxChangeWeight.Text;
            monitor.Frequency = Convert.ToInt32(textBoxChangeFrequency.Text);
            monitor.ViewingAngles = textBoxChangeViewAngles.Text;
            monitor.Dimensions = textBoxChangeSizeMonitor.Text;
            monitor.AspectRatio = textBoxChangeScreenFormat.Text;

            var cables = new Dictionary<string, int>();
            if (checkBoxChangeHDMI.Checked)
                cables.Add("HDMI", (int)numericUpDownChangeHdmi.Value);
            if (checkBoxChangeVGA.Checked)
                cables.Add("VGA", (int)numericUpDownChangeVga.Value);
            if (checkBoxChangeDVI.Checked)
                cables.Add("DVI", (int)numericUpDownChangeDvi.Value);
            if (checkBoxChangeDisplayPort.Checked)
                cables.Add("DisplayPort", (int)numericUpDownChangeDisplayPort.Value);
            monitor.CableTypes = monitor.UpdateCableTypes(cables);
            Console.WriteLine($"result update string: {monitor}");


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            UpdateMonitorInfosFromElements();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            if (Application.OpenForms["Form1"] is Form1 mainForm)
            {
                mainForm.materialTabControl1.SelectedTab = mainForm.tabPageMain;
            }

            this.Close();
        }

        private void checkBoxChangeHDMI_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownChangeHdmi.Enabled = checkBoxChangeHDMI.Checked;

        }

        private void checkBoxChangeVGA_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownChangeVga.Enabled = checkBoxChangeVGA.Checked;
        }

        private void checkBoxChangeDVI_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownChangeDvi.Enabled = checkBoxChangeDVI.Checked;
        }

        private void checkBoxChangeDisplayPort_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownChangeDisplayPort.Enabled = checkBoxChangeDisplayPort.Checked;
        }
    }
}
