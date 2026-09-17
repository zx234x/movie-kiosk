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
using System.Windows.Forms.VisualStyles;

namespace project
{
    public partial class spyderInfo : Form
    {
        public spyderInfo()
        {
            InitializeComponent();
        }


        //스파이더맨 예고편 
        ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");

        private void spyBtn_Click(object sender, EventArgs e)
        {
            // startInfo.Arguments = "https://www.youtube.com/watch?v=KRarob7gwC4";

            //Process.Start(startInfo);
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        // 스파이더맨 예매
        private void button1_Click(object sender, EventArgs e)
        {
            spyticket spti = new spyticket();
            spti.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)  //좋아요 증가 이벤트 
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