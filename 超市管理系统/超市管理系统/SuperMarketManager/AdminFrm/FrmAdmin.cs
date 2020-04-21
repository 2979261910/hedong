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
    public partial class FrmAdmin : Form
    {
        ISuperMarketAdminManager adminManager = new SuperMarketAdminManager();

        public FrmAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoGenerateColumns = false;
            InitializeUser();
            source.CurrentChanged += Source_CurrentChanged;
        }

        private void Source_CurrentChanged(object sender, EventArgs e)
        {
            currentAdm = source.Current as SysAdmins;
        }

        List<SysAdmins> adminList = null;
        BindingSource source = new BindingSource();

        //用户主要有后台系统管理员，前台收银员
        private void InitializeUser()
        {
            adminList = adminManager.GetAdmins();
            source.DataSource = adminList;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }
        SysAdmins currentAdm = null;
        
        #region 添加
        private void btnAddSysAdm_Click(object sender, EventArgs e)
        {
            FrmAddAdmin addAdmin = new FrmAddAdmin();
            addAdmin.ShowDialog();
            InitializeUser();
        }
        #endregion

        #region 修改
        private void btnUpdateSysAdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || currentAdm == null)
            {
                MessageBox.Show("请选择要修改的用户！");
                return;
            }
            FrmUpdateAdmin updateAdmin = new FrmUpdateAdmin(currentAdm);
            if (updateAdmin.ShowDialog() == DialogResult.OK)
            {
                InitializeUser();
            }
        }
        #endregion

        #region 禁用
        private void btnStopSysAdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || currentAdm == null || currentAdm.Roleld == 1)
            {
                return;
            }
            currentAdm.AdminStatus = 0;
            if (adminManager.SetSysStatus(currentAdm))
            {
                InitializeUser();
            }
        }
        #endregion

        #region 启用
        private void btnStartSysAdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || currentAdm == null || currentAdm.Roleld == 1)
            {
                return;
            }
            currentAdm.AdminStatus = 1;
            if (adminManager.SetSysStatus(currentAdm))
            {
                InitializeUser();
            }
        }
        #endregion

        #region 关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
