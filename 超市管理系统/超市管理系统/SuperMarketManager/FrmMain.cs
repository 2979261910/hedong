using SuperMarketCommon;
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
using SuperMarketIBLL.前台SuperMarketCashier;
using SuperMarketBLL.前台SuperMarketCashier;
using SuperMarketModel;

namespace SuperMarketManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += FrmMain_FormClosing;
            this.FormClosed += FrmMain_FormClosed;
            toollblUser.Text = $"【{Program.CurrentAdmin.AdminName}】";
            //将主窗体设置为MDI容器
            this.IsMdiContainer = true;
        }

        Form currentMDIChild = null;

        #region  负责开启功能窗体
        void ShowMDIChild(Form mdiForm)
        {

            if (currentMDIChild != null)
            {
                currentMDIChild.Close();
            }
            currentMDIChild = mdiForm;
            mdiForm.MdiParent = this;
            mdiForm.Parent = panel2;
            mdiForm.Left = panel1.Width / 2 - mdiForm.Width / 2+50;
            mdiForm.Top = panel1.Height / 2 - mdiForm.Height / 2-50;
            mdiForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            mdiForm.Show();
        }
        #endregion

        #region 更新系统时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            toollblTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        #endregion

        #region 关闭系统
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ISelesPersonManager saleManager = new SelesPersonManager();
            LogHelper.Info($"[{Program.CurrentAdmin.LoginId}]退出程序！");
            saleManager.WriteSalesExitLog(Program.CurrentAdmin.LoginLogId);
        }
        #endregion

        #region 修改密码
        private void toolMenuUpdatePwd_Click(object sender, EventArgs e)
        {
            FrmUpdatePwd pwd = new FrmUpdatePwd();
            DialogResult Restart = pwd.ShowDialog();
            //密码修改成功，意味着需要重新登录
            if (Restart == DialogResult.OK)
            {
                LogHelper.Info($"[{Program.CurrentAdmin.LoginId}]成功修改密码");

                this.Close();//主线程关闭
                //修改密码之后重启

            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath, "restart");
        }

        #endregion

        #region 添加商品
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct addProduct = new FrmAddProduct();
            addProduct.FormClosed += AddProduct_FormClosed;
            ShowMDIChild(addProduct);
        }
        #endregion

        #region 商品入库功能
        Produts currentProduct = null;
        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAddProduct frmAdd = sender as FrmAddProduct;
            if (frmAdd.DialogResult == DialogResult.OK)
            {
                currentProduct = frmAdd.Tag as Produts;
                frmAdd.DialogResult = DialogResult.Cancel;
                btnIntoProduct_Click(frmAdd, null);
            }
        }

        private void btnIntoProduct_Click(object sender, EventArgs e)
        {
            FrmIntoProduct intoProduct = new FrmIntoProduct();
            if (currentProduct != null)
            {
                intoProduct.txtProductId.Text = currentProduct.ProductId;
                intoProduct.txtProductName.Text = currentProduct.ProductName;
            }
            ShowMDIChild(intoProduct);
            currentProduct = null;
        }

        #endregion

        #region 关于我们
        private void btnCancelMember_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wanghanghang.blog.csdn.net");
        }
        #endregion

        #region 添加会员
        private void AddMember_Click(object sender, EventArgs e)
        {
            FrmAddMember frm = new FrmAddMember();
            ShowMDIChild(frm);
        }
        #endregion

        #region 查看日志
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AdminFrm.FrmLogCheck frmLog = new AdminFrm.FrmLogCheck();
            ShowMDIChild(frmLog);
        }
        #endregion

        #region 用户管理

            #region 系统用户管理
            private void UserManager_Click(object sender, EventArgs e)
            {
                AdminFrm.FrmSale sale = new AdminFrm.FrmSale();
                ShowMDIChild(sale);
            }
            #endregion

            #region 收银员管理
            private void ToolUser_Click(object sender, EventArgs e)
            {
                //如果当前角色是超级管理员才可以禁用其他普通管理员，否则无权限
                if (Program.CurrentAdmin.Roleld == 1)
                {
                    AdminFrm.FrmAdmin admin = new AdminFrm.FrmAdmin();
                    ShowMDIChild(admin);
                }
                else
                {
                    MessageBox.Show("您无权限操作该功能！", "提示");
                }
            }
        #endregion

        #endregion

        #region 商品维护
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ProducFrm.FrmProductProtrct productProtrct = new ProducFrm.FrmProductProtrct();
            ShowMDIChild(productProtrct);
        }
        #endregion
     
    }
}
