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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Configuration;

namespace StudentManager
{
    /// <summary>
    /// FrmMain.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        List<int> list = new List<int>();
        public FrmMain()
        {
            InitializeComponent();
            #region//登录窗体验证
            //FrmLogin login = new FrmLogin();
            //login.ShowDialog();
            //if (login.DialogResult != true)
            //{
            //    Environment.Exit(0);
            //}
            #endregion
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
            //try
            //{
            //    statusAdminLb.Content = "操作管理员【" + App.CurrentAdmin.AdminName + "】";
            //    statusVersionLb.Content = "版本号：" + ConfigurationManager.AppSettings["version"].ToString();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string week = "星期天";
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    week = "星期天";
                    break;
                case DayOfWeek.Monday:
                    week = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    week = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    week = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    week = "星期四";
                    break;
                case DayOfWeek.Friday:
                    week = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    week = "星期六";
                    break;
                default:
                    break;
            }
            statusTimeLb.Content = string.Format("{0}年{1}月{2}日    {3}:{4}:{5}    {6}", now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, week);
        }

        DispatcherTimer timer = null;
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void updatePwd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void adakaMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void queryaMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void selectsMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void checksMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void writesMenu_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 学生信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smMenu_Click(object sender, RoutedEventArgs e)
        {
            Gird_Content.Children.Clear();
            View.FrmStuManager frmStudent = new View.FrmStuManager();
            Gird_Content.Children.Add(frmStudent);
        }

        private void addsMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void inlinehMenu_Click(object sender, RoutedEventArgs e)
        {
            //Gird_Content.Children.Clear();
            //View.FrmWebBrowser webBrowser = new View.FrmWebBrowser();
            //Gird_Content.Children.Add(webBrowser);
            System.Diagnostics.Process.Start("explorer.exe",ConfigurationManager.AppSettings["webadd"].ToString());
        }

        private void lianxiMenu_Click(object sender, RoutedEventArgs e)
        {
            //弹框：请拨打电话：89564386
            //弹框：请联系QQ：xxxxxxx
            //System.Diagnostics.Process.Start("TeamViewer14.exe");
        }
        /// <summary>
        /// 快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key== Key.Escape)
                {
                    this.WindowState = WindowState.Minimized; 
                }
                else if (e.Key== Key.S)
                {
                    menuStuMan.IsSubmenuOpen = true;
                }
                else if (e.Key== Key.Z)
                {
                    smMenu_Click(null,null);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
