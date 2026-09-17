using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace project
{
    public partial class spyticket : Form
    {
        public spyticket()
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
                string date = comboBox1.SelectedItem .ToString();
                string time = "16:30";
                spysit spsit = new spysit(date,time);
                spsit.ShowDialog();
                
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
                spysit spsit = new spysit(date, time);
                spsit.ShowDialog();
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
                string time = "16:30";
                spysit spsit = new spysit(date, time);
                spsit.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "16:30";
                spysit spsit = new spysit(date, time);
                spsit.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("날짜를 선택하시오");
            }
            else
            {
                string date = comboBox1.SelectedItem.ToString();
                string time = "16:30";
                spysit spsit = new spysit(date, time);
                spsit.ShowDialog();
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
                string time = "16:30";
                spysit spsit = new spysit(date, time);
                spsit.ShowDialog();
            }
        }
    }
}
