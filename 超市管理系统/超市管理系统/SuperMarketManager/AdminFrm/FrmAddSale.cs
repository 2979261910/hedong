using SuperMarketBLL.SuperMarketManager;
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
    public partial class FrmAddSale : Form
    {
        public FrmAddSale()
        {
            InitializeComponent();
            txtAdmName.Focus();
            txtAdmPwd.GotFocus += TxtAdmPwd_GotFocus;
        }
        ISuperMarketAdminManager adminManager = new SuperMarketAdminManager();
        private void TxtAdmPwd_GotFocus(object sender, EventArgs e)
        {
            txtAdmPwd.SelectAll();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtAdmName.CheckNullOrEmpty() * txtAdmPwd.CheckData(@"^\w{6,}$", "密码必须为6位字母、数字、下划线组合") == 0)
            {
                return;
            }
            else
            {
                SelesPersonSModel person = new SelesPersonSModel()
                {
                    LoginPwd =Convert.ToInt32(txtAdmPwd.Text.Trim()),
                    SPName = txtAdmName.Text.Trim()
                };
                person = adminManager.InsertSales(person);
                if (person == null)
                {
                    MessageBox.Show("添加营业员失败！", "提示");
                }
                else
                {
                    if (MessageBox.Show($"添加营业员成功！\r\n编号：【{person.SalesPersonId}】\r\n是否继续添加", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtAdmName.Text = "";
                        txtAdmPwd.Text = "123456";
                        return;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
