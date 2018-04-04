using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace GNSSInitialize
{
    public partial class mGNSSInitializeForm : Form
    {
        private string mSaveFileName;
        private Boolean mBeginSave = false;
        private string closeAllOutput = "02 00 64 0D 00 00 00 03 00 01 00 07 04 FF 00 00 00 7F 03";
        private string outputGPGGA1hz = "02 00 64 0D 00 00 00 03 00 01 00 07 04 06 00 03 00 89 03";
        private string outputGPZDA1hz = "02 00 64 0D 00 00 00 03 00 01 00 07 04 08 00 03 00 8B 03";

        public mGNSSInitializeForm()
        {
            InitializeComponent();

            //initialize SerialPort
            initializePortName();
            initializeBaudRate();
            initializeDataBits();
            initializeParity();
            initializeStopBits();
        }

        private void mOpenPortButton_Click(object sender, EventArgs e)
        {
            mSerialPort.PortName = portNameComboBox.SelectedItem.ToString();
            if (mSerialPort.IsOpen)
            {
                MessageBox.Show("This Port is already opened!!!");
            }
            else
            {
                try
                {
                    this.mSerialPort.BaudRate = (int)this.baudRateComboBox.SelectedItem;
                    this.mSerialPort.DataBits = (int)this.dataBitsComboBox.SelectedItem;
                    this.mSerialPort.Parity = (Parity)this.parityComboBox.SelectedItem;
                    this.mSerialPort.StopBits = (StopBits)this.stopBitsComboBox.SelectedItem;
                    mSerialPort.Open();
                    mOpenPortButton.Enabled = false;
                    disableComboBox();
                    mInitializButton.Enabled = true;
                    mSaveCheckBox.Enabled = true;
                    mClosePortButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }


        private void mSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            int currentBufferSize = mSerialPort.BytesToRead;
            int realRead = 0;
            byte[] byteBuffer = new byte[currentBufferSize];
            realRead = mSerialPort.Read(byteBuffer, 0, currentBufferSize);
            string rawData = Encoding.ASCII.GetString(byteBuffer);
            if (rawData.Length > 0)
            {
                this.BeginInvoke((EventHandler)(delegate
                {
                    mDataTextBox.AppendText(rawData);
                   if (mBeginSave == true)
                    {
                        StreamWriter sw = new StreamWriter(new FileStream(mSaveFileName, FileMode.Append));
                        sw.Write(rawData);
                       
                        sw.Close();
                    }
                }));
            }
            else { return; }

        }

        private void mInitializeButton_Click(object sender, EventArgs e)
        {
                           try
            {
                mSerialPort.Write(string2btye(closeAllOutput), 0, string2btye(closeAllOutput).Length);
                System.Threading.Thread.Sleep(100);
                mSerialPort.Write(string2btye(outputGPGGA1hz), 0, string2btye(outputGPGGA1hz).Length);
                System.Threading.Thread.Sleep(100);
                mSerialPort.Write(string2btye(outputGPZDA1hz), 0, string2btye(outputGPZDA1hz).Length);
                System.Threading.Thread.Sleep(100);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void mClosePortButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(100);
            mSerialPort.Close();
            enableComboxBox();
            mOpenPortButton.Enabled = true;
            mInitializButton.Enabled = false;
            mSaveCheckBox.Enabled = false;
            mClosePortButton.Enabled = false;
        }

        private void mGNSSInitializeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mSerialPort.IsOpen)
            {
                try
                {
                    System.Threading.Thread.Sleep(100);
                    mSerialPort.Close();
                    System.Threading.Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private static byte[] string2btye(string command)
        {
            string[] commandStringArray = command.Split();//string will be splited via backspace.
            byte[] commandByteArray = new byte[commandStringArray.Length];
            for (int i = 0; i < commandStringArray.Length; ++i)
            {
                commandByteArray[i] = Convert.ToByte(commandStringArray[i], 16);
            }
            return commandByteArray;
        }

        private void saveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mSaveCheckBox.Checked == true)
            {
                mSaveFileName = "GNSSData_" + System.DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
                mBeginSave = true;
            }
            else
            {
                mBeginSave = false;
            }
        }

        private void initializeBaudRate()
        {
            this.baudRateComboBox.Items.Add(1200);
            this.baudRateComboBox.Items.Add(2400);
            this.baudRateComboBox.Items.Add(4800);
            this.baudRateComboBox.Items.Add(9600);
            this.baudRateComboBox.Items.Add(19200);
            this.baudRateComboBox.Items.Add(38400);
            this.baudRateComboBox.Items.Add(56000);
            this.baudRateComboBox.Items.Add(57600);
            this.baudRateComboBox.Items.Add(76800);
            this.baudRateComboBox.Items.Add(115200);
            this.baudRateComboBox.Items.Add(128000);
            this.baudRateComboBox.Items.Add(256000);
            this.baudRateComboBox.SelectedIndex=4;
        }

        private void initializeDataBits()
        {
            this.dataBitsComboBox.Items.Add(5);
            this.dataBitsComboBox.Items.Add(6);
            this.dataBitsComboBox.Items.Add(7);
            this.dataBitsComboBox.Items.Add(8);
            this.dataBitsComboBox.SelectedIndex = 3;
        }
        
        private void initializeParity()
        {
            this.parityComboBox.Items.Add(Parity.None);
            this.parityComboBox.Items.Add(Parity.Odd);
            this.parityComboBox.Items.Add(Parity.Even);
            this.parityComboBox.Items.Add(Parity.Mark);
            this.parityComboBox.Items.Add(Parity.Space);
            this.parityComboBox.SelectedIndex = 0;
        }

        private void initializeStopBits()
        {
            this.stopBitsComboBox.Items.Add(StopBits.None);
            this.stopBitsComboBox.Items.Add(StopBits.One);
            this.stopBitsComboBox.Items.Add(StopBits.OnePointFive);
            this.stopBitsComboBox.Items.Add(StopBits.Two);
            this.stopBitsComboBox.SelectedIndex = 1;
        }

        private void initializePortName()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length != 0)
            {
                Array.Sort(ports);
                portNameComboBox.Items.AddRange(ports);
                portNameComboBox.SelectedIndex = 0;
                mInitializButton.Enabled = false;
                mSaveCheckBox.Enabled = false;
                mClosePortButton.Enabled = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                mSerialPort.DataReceived += new SerialDataReceivedEventHandler(mSerialPort_DataReceived);
            }
            else
            {
                MessageBox.Show("There is no COM port!!!");
                System.Environment.Exit(0);
            }
        }

        private void disableComboBox()
        {
            this.portNameComboBox.Enabled = false;
            this.baudRateComboBox.Enabled = false;
            this.dataBitsComboBox.Enabled = false;
            this.parityComboBox.Enabled = false;
            this.stopBitsComboBox.Enabled = false;
        }

        private void enableComboxBox()
        {
            this.portNameComboBox.Enabled = true;
            this.baudRateComboBox.Enabled = true;
            this.dataBitsComboBox.Enabled = true;
            this.parityComboBox.Enabled = true;
            this.stopBitsComboBox.Enabled = true;
        }
    }
}
