using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketModel;
using SuperMarketBLL;
using SuperMarketIBLL;
using System.Data.SqlClient;
using System.Net;
using SuperMarketCommon;
using SuperMarketIDAL;
using SuperMarketDAL;

namespace SuperMarketCashier
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //屏幕居中
            this.StartPosition = FormStartPosition.CenterParent;
            //固定边框
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //不可随意改变窗体大小
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            //初始化log4net
            log4net.Config.XmlConfigurator.Configure();

        }
        //实例化IBLL
        SuperMarketIBLL.前台SuperMarketCashier.ISelesPersonManager manager = new SuperMarketBLL.前台SuperMarketCashier.SelesPersonManager();
        SuperMarketIDAL.前台SuperMarketCashier.ISelesPersonServer seles = new SuperMarketDAL.前台SuperMarketCashier.SelesPersonServer();
        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            //【一】文本框的数据验证
            //如果为0则有必须项未填写
            if (txtLogId.CheckData(@"^[1-9]\d*$","账户格式为纯数字")*txtLogPwd.CheckNullOrEmpty()!=0)
            {
                //【二】登录账号和密码封装成收银员对象
                SelesPersonSModel model = new SelesPersonSModel()
                {
                    SalesPersonId = int.Parse(txtLogId.Text),
                    LoginPwd = int.Parse(txtLogPwd.Text)
                };
                //【三】数据库中查询
                //记录一下不等于null的数据（就是获取到收银员的数据了）
                SelesPersonSModel JL = manager.SelesLogin(model);
                if (JL != null)
                {
                    //在主入口函数地方Sale声明一个属性记录数据，相当于全局变量拿到了
                    //【1】将登录对象保存到全局
                    Program.Seles = JL;

                    //【2】将登录信息记录到系统日志里面
                    int LogId=manager.BllWriteSelesLog(new LoginLogsModel()
                    {
                        LoginId = JL.SalesPersonId,
                        SPName = JL.SPName,
                        ServerName=Dns.GetHostName(),

                    });
                   
                    Program.Seles.LogId= LogId;
                    this.DialogResult = DialogResult.OK;
                    //写入日志
                    Log4net类.WriteInfo(string.Format("" + JL + ""));
                    this.Close();//关掉登录窗口
                   
                }
                else
                {
                    MessageBox.Show("登录失败","登录提示");
                }
            }
        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
