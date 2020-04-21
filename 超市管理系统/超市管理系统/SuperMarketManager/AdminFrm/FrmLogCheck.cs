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
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketBLL.SuperMarketManager;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmLogCheck : Form
    {
        ISuperMarketLoginLogManager logManager = new SuperMarketLoginLogManager();
        public FrmLogCheck()
        {
            InitializeComponent();
            startTime.Focus();
            txtWhere.GotFocus += Txtwhere_GotFocus;
            txtWhere.LostFocus += Txtwhere_LostFocus;
            logList = logManager.GetLoginLog();
            InitializePage();
            dataGridView1.AutoGenerateColumns = false;
        }
        List<LoginLogsModel> logList= null;
        List<LoginLogsModel> currentPageList = null;
        private void InitializePage()
        {
            if (logList==null)
            {
                MessageBox.Show("暂无任何登录信息！");
                return;
            }
            else
            {
                pageNav.RecordCount = logList.Count;
                pageNav.CurrentPage = 1;
                pageNav.PageSize = 15;
                pageNav.SortType = SortType.ASC;
                pageNav.ExceuteSetPageEvent += PageNav_ExceuteSetPageEvent1;
                pageNav.FirstSearh();
            }
            
          
        }
        BindingSource source = new BindingSource();
        private void PageNav_ExceuteSetPageEvent1(int currentPage)
        {
            if (logList != null)
            {
                currentPageList = logList.Skip((pageNav.CurrentPage - 1) * pageNav.PageSize).Take(pageNav.PageSize).ToList();
                source.DataSource = currentPageList;
                dataGridView1.DataSource = source;
                pageNav.SetButtonEnable();
            }
        }
        private void Txtwhere_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWhere.Text))
            {
                txtWhere.Text = "姓名、账号、服务器";
                txtWhere.ForeColor=Color.FromArgb(100,100,100);
            }
        }

        private void Txtwhere_GotFocus(object sender, EventArgs e)
        {
            txtWhere.SelectAll();
            txtWhere.ForeColor = Color.Black;
        }

        #region 开始查询
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //证明条件框中未输入内容,也不需要按区间查询，查询所有数据
            if (checkBox1.Checked == false && txtWhere.Tag.ToString() == "1")
            {
                logList = logManager.GetLoginLog();
                pageNav.RecordCount = logList.Count;
                pageNav.FirstSearh();
            }
            else
            {
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                string where = "";
                int check = 0;
                //需要按照查询区间进行查询
                if (checkBox1.Checked == true)
                {
                    check = 1;
                    if (startTime.Value == endTime.Value)//等于
                    {
                        check = 2;
                        start = end = Convert.ToDateTime(startTime.Value.ToShortDateString());
                    }
                    else if (startTime.Value < endTime.Value)//小于
                    {
                        start = Convert.ToDateTime(startTime.Value.ToShortDateString());
                        //'2020-04-14 0:00:00'
                        end = Convert.ToDateTime(endTime.Value.ToShortDateString()).AddDays(1);
                    }
                    else if (startTime.Value > endTime.Value)//大于
                    {
                        check = -1;
                        start = end = Convert.ToDateTime(startTime.Value.ToShortDateString());
                    }
                    if (txtWhere.Tag.ToString() == "1")//不带条件的查询
                    {
                        where = "";
                    }
                    else
                    {
                        where = txtWhere.Text.Trim();
                    }
                }
                else//不按照区间查询但是需要按照条件查询所有的
                {
                    check = 0;
                    where = txtWhere.Text.Trim();
                }
                logList = logManager.GetLoginLogBy(start, end, where, check);
                pageNav.RecordCount = logList.Count;
                pageNav.FirstSearh();
            }
        }
        #endregion
    }
}
