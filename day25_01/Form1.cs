using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day25_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            //progressBar1.PerformStep(); -> value++ 대신에 사용할 수 있으며, 이는 step에 증가량을 설정 할 수 있다.
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                MessageBox.Show("작업이 완료되었습니다.");
            }
            textBox1.Text = progressBar1.Value.ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) { timer1.Stop(); btn_start.Text = "시작"; }
            else { timer1.Start(); btn_start.Text = "대기"; }
        }
    }
}
