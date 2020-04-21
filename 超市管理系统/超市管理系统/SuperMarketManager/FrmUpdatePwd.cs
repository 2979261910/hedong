using SuperMarketBLL.SuperMarketManager;
using SuperMarketIBLL.SuperMarketManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManager
{
    public partial class FrmUpdatePwd : Form
    {
        public FrmUpdatePwd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        ISuperMarketAdminManager manager = new SuperMarketAdminManager();

        #region 修改密码
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.CheckNullOrEmpty() * txtNewPwd.CheckNullOrEmpty() * txtRePwd.CheckNullOrEmpty() != 0)
            {
                if (txtOldPwd.Text.Trim().Equals(Program.CurrentAdmin.LoginPwd))
                {
                    txtOldPwd.SetError(string.Empty);
                    //重复密码和新密码一致可以进行修改密码
                    if (txtNewPwd.Text.Trim().Equals(txtRePwd.Text.Trim()))
                    {
                        Program.CurrentAdmin.LoginPwd = txtNewPwd.Text.Trim();
                        if (manager.AdminUpdatePwd(Program.CurrentAdmin))
                        {
                            MessageBox.Show("密码修改成功！请重新登录", "提示");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("密码修改失败！请稍后重试", "提示");
                        }
                    }
                    else
                    {
                        txtRePwd.SetError("重复密码和新密码输入不一致！");
                    }
                }
                else
                {
                    txtOldPwd.SetError("原密码错误！");
                }
            }
        }

        #endregion


        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
