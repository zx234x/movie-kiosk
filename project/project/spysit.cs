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
    public partial class spysit : Form
    {
        public List<string> SelectedSeats = new List<string>();
        public spysit(string selectedDate, string selectedTime)
        {
            InitializeComponent();
            label2.Text = selectedDate + " " + selectedTime + " 좌석 예매";
            this.Load += spysit_Load;
        }


        private void spysit_Load(object sender, EventArgs e)
        {
            int rowCount = 5;
            int colCount = 10;
            int startX = 50;
            int startY = 150;
            int buttonSize = 40;
            int padding = 5;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    Button seatBtn = new Button();

                    char rowLabel = (char)('A' + r);
                    seatBtn.Text = $"{rowLabel}{c + 1}";

                    seatBtn.Size = new Size(buttonSize, buttonSize);

                    seatBtn.Location = new Point(
                        startX + (c * (buttonSize + padding)),
                        startY + (r * (buttonSize + padding))
                    );

                    seatBtn.BackColor = Color.LightGray;

                    seatBtn.Click += SeatBtn_Click;

                    this.Controls.Add(seatBtn);
                }
            }
        }

        private void SeatBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            string seatName = clickedBtn.Text;

            if (clickedBtn.BackColor == Color.LightGray)
            {
                clickedBtn.BackColor = Color.LimeGreen;
                SelectedSeats.Add(seatName);
            }
            else
            {
                clickedBtn.BackColor = Color.LightGray;
                SelectedSeats.Remove(seatName);
            }
        }

        private void btn_pha_Click(object sender, EventArgs e)
        {
            if (SelectedSeats.Count == 0)
            {
                MessageBox.Show("좌석을 1개 이상 선택해주세요.");
                return;
            }


            mocal payForm = new mocal(this.SelectedSeats);

            payForm.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

