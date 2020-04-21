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
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketModel;

namespace SuperMarketManager
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
            txtmemberName.Focus();
        }
        ISuperMarketMemberManager memberManager = new SuperMarketMemberManager();
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtmemberName.CheckNullOrEmpty()*txtmembertel.CheckDataD(@"^1\d{10}$","手机号格式有误！")!=0)
            {
                if (memberManager.GetMemberByIdPhone(txtmembertel.Text.Trim())!=null)
                {
                    MessageBox.Show("改账号已经被注册","提示");
                    return;
                }
                SMMembers members = new SMMembers()
                {
                    MemberName = txtmemberName.Text.Trim(),
                    PhoneNumber = txtmembertel.Text.Trim(),
                    MemberAddress = string.IsNullOrEmpty( txtAddress.Text.Trim())?"地址不详":txtAddress.Text.Trim()

                };
                members = memberManager.AddMember(members);
                if (members!=null)
                {
                    if (MessageBox.Show($"注册成功！ 会员账号是【{members.MemberId}】\r\n是否继续注册？","提示",MessageBoxButtons.YesNo)==DialogResult.OK)
                    {
                        txtmemberName.Text = "";
                        txtmembertel.Text = "";
                        txtAddress.Text ="";
                        txtmemberName.Focus();
                    }
                   
                }
                else
                {
                    MessageBox.Show("注册失败请稍后重新试");
                }
            }
        }

        #region 取消注册
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
