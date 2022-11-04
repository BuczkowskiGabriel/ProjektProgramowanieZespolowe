using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static SerialPort port = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.One);
        List<String> lines = new List<String>();
        String Data;
        public Form1()
        {
            InitializeComponent();
            SerialPortProgram();
        }
        public void SerialPortProgram()
        {
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String timeStamp = DateTime.Now.ToString();
            String ID = port.ReadExisting();
            Data = ID + " " + timeStamp + " ";
            if (!File.Exists("log.txt"))
            {
                using (StreamWriter sw = File.CreateText("log.txt"))
                {
                }
            }
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.WriteLine(ID + " " + timeStamp);
            }
            int a = 0;
            using (StreamReader sr = File.OpenText("autoryzacja.txt"))
            {
                string s = "";
                
                while ((s = sr.ReadLine()) != null && a == 0)
                {
                    if (ID.Equals(s))
                    {
                        Data += "autoryzowano";
                        a = 1;
                    }
                }
                sr.Close();
            }
            if (a == 0)
            {
                Data += "nie autoryzowano";
            }

            bool uiMarshal = LogsTextBox.InvokeRequired;

            lines.Add(Data);

            if (uiMarshal)
            {
                LogsTextBox.Invoke(new Action(() => { LogsTextBox.Lines = lines.ToArray(); }));
            }
            else
            {
                LogsTextBox.Lines = lines.ToArray();
            }
        }
        private void LogsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("autoryzacja.txt"))
            {
                
                if (!NewUserBox.Text.Equals(""))
                {
                    sw.WriteLine("UID  " + NewUserBox.Text);
                }
                else
                {
                    NewUserBox.Text = "Podaj numer";
                }
                sw.Close();
            }
        }

        private void NewUserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            LogsTextBox.Clear();
            lines.Clear();
        }

        private void LoadTextButton_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText("log.txt"))
            {
                string s = "";
                string pattern = @"\d{0,2}.\d{0,2}.\d{4}";
                Regex rg = new Regex(pattern);
                lines.Clear();
                if (rg.IsMatch(DateTextBox.Text) || DateTextBox.Text.Equals("") || DateTextBox.Text.Equals(null))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (DateTextBox.Text.Equals("") || DateTextBox.Text.Equals(null))
                        {
                            lines.Add(s);
                        }
                        else
                        {


                            string date = s;
                            MatchCollection matchedDates = rg.Matches(date);
                            if (DateTextBox.Text.Equals(matchedDates[0].Value))
                            {
                                lines.Add(s);
                            }

                        }
                    }
                    LogsTextBox.Lines = lines.ToArray();
                }
                else
                {
                    DateTextBox.Text = "Podaj poprawną datę";
                }
                sr.Close();
            }
        }
    }
}
