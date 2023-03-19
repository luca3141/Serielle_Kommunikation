using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace Serielle_Kommunikation
{
    public partial class Form1 : Form
    {
        string dataIN;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //COM aktiv durchsuchen 
            string[] ports = SerialPort.GetPortNames();
            cBox_COM_PORT.Items.AddRange(ports);
        }

        private void button_OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                //dem Prt alles zuweisen
                serialPort1.PortName = cBox_COM_PORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBox_BAUD.Text);
                
                serialPort1.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK);
            }

        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox_SEND_DATA.Text); 
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            textBox1_DATA_IN.Text = dataIN;
        }
    }
}
