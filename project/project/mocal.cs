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
    public partial class mocal : Form
    {
        public mocal(List<string> selectedSeats)
        {
            InitializeComponent();
            domainUpDownList.Add(domainUpDown1);
            numericUpDownList.Add(numericUpDown1);

            dx = domainUpDown1.Location.X;
            dy = domainUpDown1.Location.Y;
            nx = numericUpDown1.Location.X;
            ny = numericUpDown1.Location.Y;
            receivedSeats = selectedSeats;

            this.Load += mocal_Load;
        }

        List<NumericUpDown> numericUpDownList = new List<NumericUpDown>();
        List<DomainUpDown> domainUpDownList = new List<DomainUpDown>();

        int y = 30;
        int cnt = 1;
        int dx, dy;
        int nx, ny;

        //  티켓 총액
        static int[] price = new int[] { 16000, 10000 };
        static string[] menu = new string[] { "성인", "어린이" };

        private void button1_Click(object sender, EventArgs e)
        {
            DomainUpDown domainUpDown = new DomainUpDown();

            NumericUpDown numericUpDown = new NumericUpDown();



            for (int i = 0; i < domainUpDown1.Items.Count; i++)

            {

                domainUpDown.Items.Add(domainUpDown1.Items[i]);

            }



            if (domainUpDown.Items.Count > 0)

            {

                domainUpDown.SelectedIndex = 0;

            }

            domainUpDown.Location = new Point(dx, dy + y);

            numericUpDown.Location = new Point(nx, ny + y);

            y += 30;

            domainUpDownList.Add(domainUpDown);

            numericUpDownList.Add(numericUpDown);

            cnt++;



            Controls.Add(domainUpDown);

            Controls.Add(numericUpDown);
        }

        private List<string> receivedSeats;

        private void mocal_Load(object sender, EventArgs e)
        {
            if (receivedSeats != null && receivedSeats.Count > 0)
            {
                string result = string.Join(", ", receivedSeats);
                sitInfo.Text = "선택하신 좌석: " + result;
            }
            else
            {
                sitInfo.Text = "선택된 좌석이 없습니다.";
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DomainUpDown domainUpDown = new DomainUpDown();

            NumericUpDown numericUpDown = new NumericUpDown();

            for (int i = 0; i < domainUpDown1.Items.Count; i++)

            {
                domainUpDown.Items.Add(domainUpDown1.Items[i]);
            }


            if (domainUpDown.Items.Count > 0)

            {

                domainUpDown.SelectedIndex = 0;

            }

            domainUpDown.Location = new Point(dx, dy + y);

            numericUpDown.Location = new Point(nx, ny + y);

            y += 30;

            domainUpDownList.Add(domainUpDown);

            numericUpDownList.Add(numericUpDown);

            cnt++;


            Controls.Add(domainUpDown);

            Controls.Add(numericUpDown);
        }

        private void btResult_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            int num = 0;


            for (int i = 0; i < cnt; i++)
            {
                for (int k = 0; k < menu.Length; k++)
                {
                    if (domainUpDownList[i].Text == menu[k])
                    {
                        num = price[k] * (int)numericUpDownList[i].Value;
                        sum += num;
                    }
                }
            }
            textBox1.Text = sum.ToString();
        }
        private void agree_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("예매 취소및 환불 정보에 동의 하셨습니다.");
            }
            else
            {
                MessageBox.Show("예매 취소및 환불 정보에 동의 하셔야\n 결제가 가능합니다");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("결제방법을 선택하시오");
            }
            else
            {
                MessageBox.Show(comboBox1.Text + " (으)로 " + listBox1.Text + " 결제방법을 선택하셨습니다."
                    + "\n결제금액은 " + textBox1.Text + "원입니다.\n");

                Application.Restart();
            }
        }
   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("일시불");
                listBox1.Items.Add("3개월 할부");
                listBox1.Items.Add("6개월 할부");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("k은행");
                listBox1.Items.Add("N은행");
                listBox1.Items.Add("S은행");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("L포인트");
                listBox1.Items.Add("N포인트");
            }
        }
    }
}




