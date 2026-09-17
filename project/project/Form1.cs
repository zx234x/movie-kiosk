using System.Collections.Specialized;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void spyInfo_Click(object sender, EventArgs e)  //스파이더맨 상세정보
        {
            spyderInfo form2 = new spyderInfo();
            form2.ShowDialog();
            
        }

        private void hopeInfo_Click(object sender, EventArgs e) // 호프 상세정보
        {
            hopeInfo hopeinfo = new hopeInfo();
            hopeinfo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) //모아나 상세정보
        {
            naInfo nainfo = new naInfo();
            nainfo.ShowDialog();
        }

        private void spyTic_Click(object sender, EventArgs e) //스파이더맨 예매
        {
            spyticket spy = new spyticket();
            spy.ShowDialog();
        }

        private void hoTic_Click(object sender, EventArgs e) // 호프 예매
        {
            hotic hoti = new hotic();
            hoti.ShowDialog();
        }

        private void naTic_Click(object sender, EventArgs e) //모아나 예매
        {
            natic na = new natic();
            na.ShowDialog();
        }
    }
}
