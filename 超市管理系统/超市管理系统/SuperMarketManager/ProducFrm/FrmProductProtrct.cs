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

namespace SuperMarketManager.ProducFrm
{
   
    public partial class FrmProductProtrct : Form
    {
        ISuperMarketProductManager productManager = new SuperMarketProductManager();
        public FrmProductProtrct()
        {
            InitializeComponent();
            dgvProductList.AutoGenerateColumns = false;
            categories = productManager.GetCategories();
            toolCmbType.Items.Add("所有");
            foreach (ProductCategory item in categories)
            {
                toolCmbType.Items.Add(item.CategoryName);
            }
            toolCmbType.SelectedIndex = 0;
            list = productManager.GetAllProduct();
            InitializeProduct();
            source.CurrentChanged += Source_CurrentChanged;
            toolTxtWhere.TextChanged += ToolTxtWhere_TextChanged;
            toolTxtWhere.GotFocus += ToolTxtWhere_GotFocus;
            toolTxtWhere.LostFocus += ToolTxtWhere_LostFocus;
        }
        private void ToolTxtWhere_LostFocus(object sender, EventArgs e)
        {
            toolTxtWhere.ForeColor = Color.Black;
        }

        private void ToolTxtWhere_GotFocus(object sender, EventArgs e)
        {
            toolTxtWhere.SelectAll();
            toolTxtWhere.ForeColor = Color.FromArgb(100, 100, 100);
        }

        private void ToolTxtWhere_TextChanged(object sender, EventArgs e)
        {
            toolTxtWhere.Tag = "1";
        }

        public Produts CurrentProduct { get; set; }

        private void Source_CurrentChanged(object sender, EventArgs e)
        {
            CurrentProduct = source.Current as Produts;
        }

        List<ProductCategory> categories = null;
        List<Produts> list = null;
        BindingSource source = new BindingSource();
        private void InitializeProduct()
        {
            source.DataSource = list;
            dgvProductList.DataSource = null;
            dgvProductList.DataSource = source;
        }


        #region 商品入库
        private void toolBtnInto_Click(object sender, EventArgs e)
        {
            FrmIntoProduct intoProduct = new FrmIntoProduct();
            intoProduct.ShowDialog();
            InitializeProduct();
        }
        #endregion

        #region 添加商品
        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddProduct addProduct = new FrmAddProduct();
            addProduct.ShowDialog();
            InitializeProduct();
        }
        #endregion

        #region 修改商品
        private void toolBtnQuery_Click(object sender, EventArgs e)
        {
            var selectIndex = from item in categories where item.CategoryName == toolCmbType.SelectedItem.ToString() select item.CategoryId;
            int index = 0;
            string where = toolTxtWhere.Text.Trim();
            //没有选择条件
            if (toolTxtWhere.Tag.ToString() == "0" && selectIndex.FirstOrDefault() == 0)
            {
                list = productManager.GetAllProduct();
                InitializeProduct();
                return;
            }
            else if (toolTxtWhere.Tag.ToString() == "0" && selectIndex.FirstOrDefault() != 0)
            {
                where = "";
                index = selectIndex.FirstOrDefault();
            }
            else if (toolTxtWhere.Tag.ToString() != "0" && selectIndex.FirstOrDefault() == 0)
            {
                where = toolTxtWhere.Text.Trim();
                index = 0;
            }
            else if (toolTxtWhere.Tag.ToString() != "0" && selectIndex.FirstOrDefault() != 0)
            {
                where = toolTxtWhere.Text.Trim();
                index = selectIndex.FirstOrDefault();
            }
            list = productManager.GetProductsWithWhere(index, where);
            InitializeProduct();

            toolTxtWhere.Text = "商品编号、商品名称";
            toolCmbType.SelectedIndex = 0;
            toolTxtWhere.Tag = "0";
        }
        #endregion

        #region 提交查询
        private void btnRefreshDiscount_Click(object sender, EventArgs e)
        {
            if (txtDiscount.CheckData(@"^\d(.\d)?$", "输入有误") != 0)
            {
                if (CurrentProduct != null)
                {
                    if (productManager.SetProductDiscount(CurrentProduct.ProductId, Convert.ToSingle(txtDiscount.Text.Trim())))
                    {
                        CurrentProduct.Discount = Convert.ToSingle(txtDiscount.Text.Trim());
                        InitializeProduct();
                        txtDiscount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("修改商品折扣失败！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("请选择要更改折扣的商品！", "提示");
                }
            }
        }
        #endregion

        #region 更新折扣
        private void toolBtnUpdate_Click(object sender, EventArgs e)
        {
            if (list.Count == 0 || CurrentProduct == null)
            {
                MessageBox.Show("请选择要修改的商品！");
                return;
            }
            FrmUpdateProduct updateProduct = new FrmUpdateProduct(CurrentProduct);
            if (updateProduct.ShowDialog() == DialogResult.OK)
            {
                list = productManager.GetAllProduct();
                InitializeProduct();
            }
        }
        #endregion
    }
}
