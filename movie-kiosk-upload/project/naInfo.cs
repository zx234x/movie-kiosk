using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class naInfo : Form
    {
        public naInfo()
        {
            InitializeComponent();
        }
        ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");
        private void naBtn_Click(object sender, EventArgs e)
        {
            startInfo.Arguments = "https://www.youtube.com/watch?v=izunRLYzHU0";
            Process.Start(startInfo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            natic nati = new natic();
            nati.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {

                string currentText = clickedButton.Text;


                string numberPart = currentText.Replace("♡ ", "").Trim();


                if (int.TryParse(numberPart, out int currentNumber))
                {

                    currentNumber++;


                    clickedButton.Text = $"♡ {currentNumber}";
                }
            }
        }
    }

}
