using SuperMarketBLL.SuperMarketManager;
using SuperMarketCommon;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmUpdateAdmin : Form
    {
        ISuperMarketAdminManager adminManager = new SuperMarketAdminManager();
        public FrmUpdateAdmin(SysAdmins admins)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblLogId.Text = admins.LoginId.ToString();
            this.Text = $"修改【{admins.AdminName}】信息";
            txtAdmName.Text = admins.AdminName;
            txtAdmPwd.Text = admins.LoginPwd;
            cmbAdminRole.SelectedIndex = admins.Roleld - 1;
            CurrentAdmin = admins;
            txtAdmName.GotFocus += TxtAdmName_GotFocus;
            txtAdmPwd.GotFocus += TxtAdmName_GotFocus;
            txtAdmName.Focus();
        }

        private void TxtAdmName_GotFocus(object sender, EventArgs e)
        {
            SuperTextbox text = sender as SuperTextbox;
            text.SelectAll();
        }
        public SysAdmins CurrentAdmin { get; set; }

        #region 确认修改
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtAdmName.CheckNullOrEmpty() * txtAdmPwd.CheckData(@"^\w{6,}$", "密码必须为6位字母、数字、下划线组合") == 0)
            {
                return;
            }
            else
            {
                CurrentAdmin.AdminName = txtAdmName.Text.Trim();
                CurrentAdmin.LoginPwd = txtAdmPwd.Text.Trim();
                CurrentAdmin.Roleld = cmbAdminRole.SelectedIndex + 1;
                CurrentAdmin = adminManager.UpdateAdmin(CurrentAdmin);
                if (CurrentAdmin == null)
                {
                    MessageBox.Show("修改失败！", "提示");
                }
                else
                {
                    MessageBox.Show("修改成功！", "提示");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        #endregion

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
