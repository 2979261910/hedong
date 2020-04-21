using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = StringSecurity.MD5Encrypt(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = StringSecurity.DESEncrypt(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = StringSecurity.DESDecrypt(textBox5.Text);
        }
    }
}
