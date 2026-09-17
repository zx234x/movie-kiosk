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
    public partial class hotic : Form
    {
        public hotic()
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
                string time = "16:30";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
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
                string time = "18:30";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
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
                string time = "19:40";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
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
                string time = "21:20";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
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
                string time = "22:40";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
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
                string time = "23:20";
                hosit hosi = new hosit(date, time);
                hosi.ShowDialog();
            }
        }

        private void hotic_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DateTime today = DateTime.Today;

            for (int i = 1; i <= 5; i++)
            {
                DateTime targetDate = today.AddDays(i);
                string dateString = targetDate.ToString("M\\/dd");
                comboBox1.Items.Add(dateString);
            }
        }
    }
}
