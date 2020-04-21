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

namespace SuperMarketManager.ProducFrm
{
    public partial class FrmUpdateProduct : Form
    {
        ISuperMarketProductManager productManager = new SuperMarketProductManager();
        List<ProductCategory> categories = null;
        BindingSource source1 = new BindingSource();
        BindingSource source2 = new BindingSource();
        List<ProductUnit> units = null;
        public Produts CurrentProduct { get; set; }
        public FrmUpdateProduct(Produts produts)
        {
            InitializeComponent();
            txtProductName.Focus();
            categories = productManager.GetCategories();
            units = productManager.GetUnit();
            if (categories.Count == 0 || units.Count == 0)
            {
                return;
            }
            source1.DataSource = categories;
            cmbCategory.DataSource = source1;
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.SelectedIndex = produts.CategoryId - 1;

            source2.DataSource = units;
            cmbUnit.DataSource = source2;
            cmbUnit.ValueMember = "Id";
            cmbUnit.DisplayMember = "Unit";
            cmbUnit.SelectedIndex = ((from item in units where item.Unit == produts.Unit select item.Id).FirstOrDefault() - 1);

            txtProductId.Text = produts.ProductId;
            txtProductName.Text = produts.ProductName;
            txtUnitPrice.Text = produts.UnitPrice.ToString("F2");
            CurrentProduct = produts;
            txtProductId.GotFocus += TxtProductId_GotFocus;
            txtProductName.GotFocus += TxtProductId_GotFocus;
            txtUnitPrice.GotFocus += TxtProductId_GotFocus;
        }

        private void TxtProductId_GotFocus(object sender, EventArgs e)
        {
            SuperTextbox text = sender as SuperTextbox;
            text.SelectAll();
        }

        #region 确认
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtProductId.CheckData(@"^\d{6,}$", "商品编格式错误") * txtProductName.CheckNullOrEmpty() * txtUnitPrice.CheckData(@"^\d*(.\d\d?)+$", "单价格式错误！") != 0)
            {
                CurrentProduct.ProductId = txtProductId.Text.Trim();
                CurrentProduct.ProductName = txtProductName.Text.Trim();
                CurrentProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
                CurrentProduct.CategoryId = (from item in categories where item.CategoryId == Convert.ToInt32(cmbCategory.SelectedValue) select item.CategoryId).FirstOrDefault();
                CurrentProduct.Unit = (from uitem in units where uitem.Id == cmbUnit.SelectedIndex + 1 select uitem.Unit).FirstOrDefault();
                if (productManager.UpdateProduct(CurrentProduct))
                {
                    MessageBox.Show("修改商品成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改商品失败！");
                }
            }
        }
        #endregion

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
