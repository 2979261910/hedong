using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StudentManagerModel;
using Common;
using StudentManagerBLL;

namespace StudentManager
{
    /// <summary>
    /// FrmLogin.xaml 的交互逻辑
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtLogId.Focus();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //数据验证
            if (txtLogId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入登录账号！","登录提示");
                txtLogId.Focus();
                return;
            }
            if (DataValidate.IsInteger(txtLogId.Text.Trim())==false)
            {
                MessageBox.Show("请输入正确账号！(纯数字格式)", "登录提示");
                txtLogId.Focus();
                return;
            }
            if (txtLogPwd.Password.Length==0)
            {
                MessageBox.Show("请输入登录密码！", "登录提示");
                txtLogPwd.Focus();
                return;
            }
            //输入的账号密码
            Admins admin = new Admins()
            {
                LoginId = Convert.ToInt32(txtLogId.Text.Trim()),
                //LoginPwd = txtLogPwd.Password
            };
            //和后台交互查询，判断登录信息是否正确
            try
            {
                Admins mainuse = new AdminManager().GetAdmins(admin);
                if (mainuse==null)
                {
                    MessageBox.Show("用户账号不存在！", "提示信息");
                    txtLogId.Focus();
                }
                else
                {
                    if (mainuse.LoginPwd==txtLogPwd.Password)
                    {
                        //保存登录信息
                        App.CurrentAdmin = mainuse;
                        this.DialogResult = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户密码错误！", "提示信息");
                        txtLogPwd.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("服务器连接异常，登录失败！请检查您的网络！");
            }
        }
    }
}
