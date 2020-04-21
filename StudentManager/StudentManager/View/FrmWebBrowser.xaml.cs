using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace StudentManager.View
{
    /// <summary>
    /// FrmWebBrowser.xaml 的交互逻辑
    /// </summary>
    public partial class FrmWebBrowser : UserControl
    {
        public FrmWebBrowser()
        {
            InitializeComponent();
            web.Source = new Uri(ConfigurationManager.AppSettings["webadd"].ToString());
        }
    }
}
