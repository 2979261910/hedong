using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketBLL.SuperMarketManager;
using SuperMarketCommon;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketModel;

namespace SuperMarketManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        ISuperMarketAdminManager adminManager = new SuperMarketAdminManager();

        #region 管理员登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginId.CheckDataD(@"^\d+$","账号输入有误！")*txtLoginPwd.CheckNullOrEmpty()!=0)
            {
                SysAdmins sys = new SysAdmins()
                {
                    LoginId = Convert.ToInt32(txtLoginId.Text.Trim()),
                    LoginPwd = txtLoginPwd.Text.Trim()
                };

                try
                {
                    sys = adminManager.AdminLogin(sys);
                    LogHelper.Info($"账号[{sys.LoginId}]开始登录");
                    if (sys != null)
                    {
                        if (sys.AdminStatus == 1)
                        {
                            LogHelper.Info($"[{sys.LoginId}]登录成功！");
                            Program.CurrentAdmin = sys;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            LogHelper.Info($"[{sys.LoginId}]账号被禁用");
                            MessageBox.Show("当前管理员账号已被禁用！", "登录提示");
                        }
                    }
                    else
                    {
                        LogHelper.Info($"[{sys.LoginId}]账号或密码错误登录失败");
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error($"[{sys.LoginId}]登录发生异常", ex);
                    return;
                }
            }
        }
        #endregion

        #region 退出登录
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
