using System;
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
            int baud =  Int32.Parse(baudTxt.Text);
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
            if (pari == "One")
            {
                stopAct = StopBits.One;
            }
            else if (pari == "Two")
            {
                stopAct = StopBits.Two;
            }
            
            string port = portsBox.Text;


            _serialPort = new SerialPort(port, baud, pariAct, data, stopAct);
            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.Open(); 
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {            
            string data = _serialPort.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }

        private void si_DataReceived(string data) 
        { 
            textBox1.Text = data.Trim(); 
        }

    }
}
