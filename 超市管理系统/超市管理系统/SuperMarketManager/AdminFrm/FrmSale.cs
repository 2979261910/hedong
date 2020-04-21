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
    public partial class FrmSale : Form
    {
        ISuperMarketAdminManager adminManager = new SuperMarketAdminManager();
        public FrmSale()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            InitializeSale();
            source.CurrentChanged += Source_CurrentChanged;
        }
        public SelesPersonSModel Person { get; set; }
        private void Source_CurrentChanged(object sender, EventArgs e)
        {
            Person = source.Current as SelesPersonSModel;
        }

        private void InitializeSale()
        {
            list = adminManager.GetSales();
            source.DataSource = list;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        List<SelesPersonSModel> list = null;
        BindingSource source = new BindingSource();

        #region 添加
        private void btnAddSysAdm_Click(object sender, EventArgs e)
        {
            FrmAddSale addSale = new FrmAddSale();
            addSale.ShowDialog();
            InitializeSale();
        }
        #endregion

       #region 修改
        private void btnUpdateSysAdm_Click(object sender, EventArgs e)
        {
            FrmUpdateSale updateSale = new FrmUpdateSale(Person);
            if (updateSale.ShowDialog() == DialogResult.OK)
            {
                InitializeSale();
            }
        }
        #endregion

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
