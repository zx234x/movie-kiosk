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
    public partial class hopeInfo : Form
    {
        public hopeInfo()
        {
            InitializeComponent();
        }
        //호프 예고편
        ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");
        private void hopeBtn_Click(object sender, EventArgs e)
        {
            //startInfo.Arguments = "https://www.youtube.com/watch?v=DrNM5QhAr_M";
            //Process.Start(startInfo);
            hope1 ho1 = new hope1();
            ho1.ShowDialog();

        }
        // 호프 예매
        private void hopetic_Click(object sender, EventArgs e)
        {
            hotic hoti = new hotic();
            hoti.Show();

            this.Close();
        }
        // 좋아요 증가 이벤트
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

        private void hopeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

