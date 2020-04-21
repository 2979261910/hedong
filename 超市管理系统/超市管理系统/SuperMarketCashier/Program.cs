using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketModel;

namespace SuperMarketCashier
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //先显示收银员登录窗口
            FrmLogin login = new FrmLogin();
            //接收关闭结果
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)//表示登录成功
            {
                //显示收银员界面
                Application.Run(new FrmMain());
            }
            else
            {
                Environment.Exit(0);//不是OK直接全部关闭窗口
            }
        }
        //public static SalesPerson Sale { get; set; }
        public static SelesPersonSModel  Seles { get; set; }
    }
    
}
