using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class FrmThread : Form
    {
        public FrmThread()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sum =LongTask();
            MessageBox.Show("sum= "+sum);

        }
        long LongTask()//單一執行緒會拖住其他功能執行包括UI
        {
            long sum = 0;
            for(long i = 1; i <= int.MaxValue; i++)
            {
                sum += 1;
            }
            return sum;
        }

        private void FrmThread_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
