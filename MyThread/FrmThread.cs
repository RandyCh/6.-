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

        private void ThreadStart_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(new ThreadStart(LongTask2));///使用執行緒,不會完全卡死,程式的其他功能還可以動
            //treadstart這種委派呼叫的方法為無回傳參數的method
            //thread後面可接三種方法
            T1.Start();
        }
        void LongTask2()
        {
            ///...
            ///
            Thread.Sleep(5000);
            MessageBox.Show("done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(LongTask3);
            T1.Start();

            for(int i = 1; i <= 4000; i++)
            {
                Console.Write("1");
            }
        }
        void LongTask3()
        {
            for (int i = 1; i <= 4000; i++)
            {
                Console.Write("3");
            }

        }
        //=================================2.0
        private void button7_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();//啟動dowork event
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //long task
            Thread.Sleep(500);
            e.Result = LongTask();//等到執行完成傳到runworkercompleted
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());//收到
        }
    }
}
