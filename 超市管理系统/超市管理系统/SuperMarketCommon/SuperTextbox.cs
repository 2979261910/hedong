using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//Regex

namespace SuperMarketCommon
{
    public partial class SuperTextbox : TextBox
    {
        public SuperTextbox()
        {
            InitializeComponent();
        }

        public SuperTextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        /// <summary>
        /// TextBox里面的内容不能为空
        /// </summary>
        /// <returns></returns>
        public int CheckNullOrEmpty() 
        {
            Text.Replace("\r\n", "");
            if (string.IsNullOrEmpty(this.Text))
            {
                this.errorProvider1.SetError(this,"必填项不能为空");
                return 0;
            }
            else
            {
                errorProvider1.SetError(this, string.Empty);
                return 1;
            }
        }
        //
        public int CheckData(string a,string b) 
        {
            if (CheckNullOrEmpty()==0)
            {
                return 0;
            }
            Regex regex = new Regex(a);
            Text.Replace("\r\n", "");
            if (regex.IsMatch(this.Text))
            {
                errorProvider1.SetError(this, string.Empty);
                return 1;
            }
            else
            {
                errorProvider1.SetError(this, b);//表示只读string.Empty,this的值
                return 0;
            }
        }
        public int CheckDataD(string pattern, string msg)
        {
            if (CheckNullOrEmpty() == 0)
            {
                return 0;
            }
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(this.Text))
            {
                errorProvider1.SetError(this, string.Empty);
                return 1;
            }
            else
            {
                errorProvider1.SetError(this, msg);
                return 0;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        /// <param name="msg"></param>
        public void SetError(string msg)
        {
            if (!string.IsNullOrEmpty(msg))
            {
                errorProvider1.SetError(this, msg);
                return;
            }
        }
    }
}
