﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;

namespace SerialDataReader
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             portsBox.Items.AddRange(SerialPort.GetPortNames());        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int baud = Int32.Parse(baudTxt.Text);
                string stop = stopTxt.Text;
                int data = Int32.Parse(dataTxt.Text);
                string pari = pariTxt.Text;
                Parity pariAct = Parity.None;
                if (pari == "Even")
                {
                    pariAct = Parity.Even;
                }
                else if (pari == "Odd")
                {
                    pariAct = Parity.Odd;
                }

                StopBits stopAct = StopBits.None;
                if (stop == "One")
                {
                    stopAct = StopBits.One;
                }
                else if (stop == "Two")
                {
                    stopAct = StopBits.Two;
                }

                string port = portsBox.Text;

                
                _serialPort = new SerialPort(port, baud, pariAct, data, stopAct);                
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    MessageBox.Show("Closing Serial Port");
                }
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string data;
        string globald;
        delegate void SetTextDeleg();
        public void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = _serialPort.ReadExisting();
            globald = data;            
            data = "";
            this.BeginInvoke(new SetTextDeleg(si_DataReceived));
        }

        private void si_DataReceived() 
        {
            globald = globald.Replace("0x0D", Environment.NewLine);
            textBox1.Text += globald;
        }

    }
}
