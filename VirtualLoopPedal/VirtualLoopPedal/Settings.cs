using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLoopPedal
{
    public partial class Settings : Form
    {
        public int WaveOutDeviceNumber { get { return comboBox_outputWave.SelectedIndex - 1; } }
        public int WaveInDeviceNumber { get { return comboBox_inputWave.SelectedIndex - 1; } }
        public string AsioDeviceName { get { return (string)comboBox_asioDriver.SelectedItem; } }
        public Driver SelectedDriver
        {
            get
            {
                if (radioButton_asio.Checked)
                    return Driver.ASIO;
                else
                    return Driver.WaveEvent;
            }
        }
        public int SampleRate { get { return Convert.ToInt32(numericUpDown_sampleRate.Value); } }

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            numericUpDown_sampleRate.Value = settings.SampleRate;
            radioButton_waveOutEvent.Checked = (settings.Driver == "WaveEvent");
            radioButton_asio.Checked = (settings.Driver == "ASIO");

            if (WaveOut.DeviceCount > 0)
            {
                for (var deviceId = -1; deviceId < WaveOut.DeviceCount; deviceId++)
                {
                    var capabilities = WaveOut.GetCapabilities(deviceId);
                    comboBox_outputWave.Items.Add($"Device {deviceId} ({capabilities.ProductName})");
                }
                comboBox_outputWave.SelectedIndex = (Owner as Pedal) != null ? (Owner as Pedal).WaveOutDeviceNumber + 1 : 0;
            }

            if (WaveIn.DeviceCount > 0)
            {
                for (var deviceId = -1; deviceId < WaveIn.DeviceCount; deviceId++)
                {
                    var capabilities = WaveIn.GetCapabilities(deviceId);
                    comboBox_inputWave.Items.Add($"Device {deviceId} ({capabilities.ProductName})");
                }
                comboBox_inputWave.SelectedIndex = (Owner as Pedal) != null ? (Owner as Pedal).WaveInDeviceNumber + 1 : 0;
            }

            var asioDriverNames = AsioOut.GetDriverNames();
            foreach (string driverName in asioDriverNames)
            {
                comboBox_asioDriver.Items.Add(driverName);
            }
            comboBox_asioDriver.SelectedIndex = 0;
        }

        private void button_asioPanel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var asio = new AsioOut(AsioDeviceName))
                {
                    asio.ShowControlPanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void radioButton_waveOutEvent_CheckedChanged(object sender, EventArgs e)
        {
            EnablePanelContents(panel_waveEvent, true);
            EnablePanelContents(panel_asio, false);
        }

        private void radioButton_asio_CheckedChanged(object sender, EventArgs e)
        {
            EnablePanelContents(panel_waveEvent, false);
            EnablePanelContents(panel_asio, true);
        }

        private void EnablePanelContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }
    }
}
