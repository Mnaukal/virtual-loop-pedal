using NAudio.CoreAudioApi;
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
                else if (radioButton_wasapi.Checked)
                    return Driver.Wasapi;
                else
                    return Driver.WaveEvent;
            }
        }
        public int SampleRate { get { return Convert.ToInt32(numericUpDown_sampleRate.Value); } }
        public int DesiredLatency { get { return Convert.ToInt32(numericUpDown_latency.Value); } }
        public int BufferSize { get { return Convert.ToInt32(numericUpDown_bufferSize.Value); } }
        public MMDevice WasapiOutDevice { get { return (MMDevice)comboBox_outputWasapi.SelectedValue; } }
        public MMDevice WasapiInDevice { get { return (MMDevice)comboBox_inputWasapi.SelectedValue; } }
        public AudioClientShareMode ShareMode { get { return checkBox_exclusive.Checked ? AudioClientShareMode.Exclusive : AudioClientShareMode.Shared; } }

        public Settings()
        {
            InitializeComponent();
            linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = "https://github.com/Mnaukal/virtual-loop-pedal" });
            linkLabel2.Links.Add(new LinkLabel.Link() { LinkData = "https://github.com/naudio/NAudio" });

            Properties.Settings settings = Properties.Settings.Default;

            numericUpDown_sampleRate.Value = settings.SampleRate;
            numericUpDown_latency.Value = settings.DesiredLatency;
            numericUpDown_bufferSize.Value = settings.BufferSize;
            radioButton_waveOutEvent.Checked = (settings.Driver == "WaveEvent");
            radioButton_asio.Checked = (settings.Driver == "ASIO");
            radioButton_wasapi.Checked = (settings.Driver == "Wasapi");

            // Wave devices
            if (WaveOut.DeviceCount > 0)
            {
                for (var deviceId = -1; deviceId < WaveOut.DeviceCount; deviceId++)
                {
                    var capabilities = WaveOut.GetCapabilities(deviceId);
                    comboBox_outputWave.Items.Add($"Device {deviceId} ({capabilities.ProductName})");
                }
                comboBox_outputWave.SelectedIndex = (Owner as Pedal) != null ? (Owner as Pedal).settings.WaveOutDeviceNumber + 1 : 0;
            }

            if (WaveIn.DeviceCount > 0)
            {
                for (var deviceId = -1; deviceId < WaveIn.DeviceCount; deviceId++)
                {
                    var capabilities = WaveIn.GetCapabilities(deviceId);
                    comboBox_inputWave.Items.Add($"Device {deviceId} ({capabilities.ProductName})");
                }
                comboBox_inputWave.SelectedIndex = (Owner as Pedal) != null ? (Owner as Pedal).settings.WaveInDeviceNumber + 1 : 0;
            }

            // asio
            var asioDriverNames = AsioOut.GetDriverNames();
            foreach (string driverName in asioDriverNames)
            {
                comboBox_asioDriver.Items.Add(driverName);
            }
            comboBox_asioDriver.SelectedIndex = 0;

            // wasapi
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection endPoints = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            List<WasapiDeviceComboItem> outComboItems = new List<WasapiDeviceComboItem>();
            foreach (MMDevice endPoint in endPoints)
            {
                outComboItems.Add(new WasapiDeviceComboItem()
                {
                    Description = endPoint.FriendlyName + " (" + endPoint.DeviceFriendlyName + ")",
                    Device = endPoint
                });
            }
            comboBox_outputWasapi.DisplayMember = "Description";
            comboBox_outputWasapi.ValueMember = "Device";
            comboBox_outputWasapi.DataSource = outComboItems;

            endPoints = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            List<WasapiDeviceComboItem> inComboItems = new List<WasapiDeviceComboItem>();
            foreach (MMDevice endPoint in endPoints)
            {
                inComboItems.Add(new WasapiDeviceComboItem()
                {
                    Description = endPoint.FriendlyName + " (" + endPoint.DeviceFriendlyName + ")",
                    Device = endPoint
                });
            }
            comboBox_inputWasapi.DisplayMember = "Description";
            comboBox_inputWasapi.ValueMember = "Device";
            comboBox_inputWasapi.DataSource = inComboItems; 
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
            EnablePanelContents(panel_wasapi, false);
        }

        private void radioButton_asio_CheckedChanged(object sender, EventArgs e)
        {
            EnablePanelContents(panel_waveEvent, false);
            EnablePanelContents(panel_asio, true);
            EnablePanelContents(panel_wasapi, false);
        }

        private void radioButton_wasapi_CheckedChanged(object sender, EventArgs e)
        {
            EnablePanelContents(panel_waveEvent, false);
            EnablePanelContents(panel_asio, false);
            EnablePanelContents(panel_wasapi, true);
        }

        private void EnablePanelContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (sender as LinkLabel).LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }

    class WasapiDeviceComboItem
    {
        public string Description { get; set; }
        public MMDevice Device { get; set; }
    }
}
