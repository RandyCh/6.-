
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_06
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new FrmMyAlbum());
            //Application.Run(new  FrmDownLoadData());
           Application.Run(new FrmThread());
         //   Application.Run(new Lab_05.Form1());

        }
    }
}
