using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class natic : Form
    {
        public natic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "14:20";
                nasit nasit1 = new nasit(date, time);
                nasit1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "16:30";
                nasit nasit1 = new nasit(date, time);
                nasit1.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "19:20";
                nasit nasit1 = new nasit(date, time);
                nasit1.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "20:40";
                nasit nasit1 = new nasit(date, time);
                nasit1.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "21:30";
                nasit nasit1 = new nasit(date, time);
                nasit1.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "22:40";
                nasit nasit1 = new nasit(date, time);
                nasit1.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "16:30";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
            }
        }
    }
}


