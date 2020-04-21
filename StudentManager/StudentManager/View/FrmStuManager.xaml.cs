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
using StudentManagerModel;
using StudentManagerModel.ObjExt;
using StudentManagerBLL;

namespace StudentManager.View
{
    /// <summary>
    /// FrmStuManager.xaml 的交互逻辑
    /// </summary>
    public partial class FrmStuManager : UserControl
    {
        StudentClassManager csm = new StudentClassManager();
        StudentManagerBLL.StudentManager sm = new StudentManagerBLL.StudentManager();
        List<StudentExt> students = null;
        public FrmStuManager()
        {
            InitializeComponent();
            List<StudentClass> classes = csm.GetClasses();
            smclassCmb.ItemsSource = classes;
            smclassCmb.DisplayMemberPath = "ClassName";//设置下拉框的显示文本
            smclassCmb.SelectedValuePath = "ClassId";//设置下拉框显示文本对应的value
            smclassCmb.SelectedIndex = 0;
            //给DataGrid进行数据绑定,需要针对DG中列进行绑定对应的数据列
            RefreshDG();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// 根据输入的学号或者姓名查询，包括模糊查询功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectBySIN_Click(object sender, RoutedEventArgs e)
        {
            smclassCmb.SelectedIndex = -1;
            string target = mstxtIdorName.Text.Trim();
            List<StudentExt> liststu  = sm.GetStudentByIdOrName(target);
            smDgStudentLsit.ItemsSource = null;
            if (liststu.Count<=0)
            {
                MessageBox.Show("根据条件未查询到相关信息！", "提示");
                mstxtIdorName.Focus();
                mstxtIdorName.SelectAll();
                return;
            }
            students = liststu;
            smDgStudentLsit.ItemsSource = students;
        }
        /// <summary>
        /// 根据班级查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectByCId_Click(object sender, RoutedEventArgs e)
        {
            if (smclassCmb.SelectedIndex<0)
            {
                MessageBox.Show("请选择班级！", "提示");
                return;
            }
            students=sm.GetStudents(Convert.ToInt32(smclassCmb.SelectedValue));
            smDgStudentLsit.ItemsSource = students;
        }

        private void btnGroupBySid_Click(object sender, RoutedEventArgs e)
        {
            if (smDgStudentLsit.ItemsSource==null)
            {
                return;
            }
            //倒序：从大到小
            if ((sender as Button).Tag.ToString()=="True")
            {
                students.Sort(new StudentIdDESC(true));
                groupBySidImg.Source = new BitmapImage(new Uri("/img/ico/up.ico", UriKind.RelativeOrAbsolute));
                (sender as Button).Tag = "False";
            }
            else if ((sender as Button).Tag.ToString() == "False")
            {
                students.Sort(new StudentIdDESC(false));
                groupBySidImg.Source = new BitmapImage(new Uri("/img/ico/down.ico", UriKind.RelativeOrAbsolute));
                (sender as Button).Tag = "True";
            }
            smDgStudentLsit.ItemsSource = null;
            smDgStudentLsit.ItemsSource = students;
        }

        private void btnGroupBySName_Click(object sender, RoutedEventArgs e)
        {
            if (smDgStudentLsit.ItemsSource == null)
            {
                return;
            }
            if ((sender as Button).Tag.ToString()=="True")
            {
                students.Sort(new StudentNameDESC(true));
                groupBySNameImg.Source= new BitmapImage(new Uri("/img/ico/jiang.ico", UriKind.RelativeOrAbsolute));
                (sender as Button).Tag = "False";
            }
            else if ((sender as Button).Tag.ToString() == "False")
            {
                students.Sort(new StudentNameDESC(false));
                groupBySNameImg.Source = new BitmapImage(new Uri("/img/ico/sheng.ico", UriKind.RelativeOrAbsolute));
                (sender as Button).Tag = "True";
            }
            smDgStudentLsit.ItemsSource = null;
            smDgStudentLsit.ItemsSource = students;
        }
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateInfor_Click(object sender, RoutedEventArgs e)
        {
            StudentExt selectStu = smDgStudentLsit.SelectedItem as StudentExt;
            if (selectStu == null)
            {
                MessageBox.Show("请选择要修改的学员！", "提示");
                return;
            }
            StudentExt objStu = sm.GetStudentById(selectStu.StudentId);
            FrmUpdateStuInfor updateStuInfor = new FrmUpdateStuInfor(objStu);
            updateStuInfor.ShowDialog();
            //刷新DG中这个学员的信息
            RefreshDG();
        }

        private void RefreshDG()
        {
            students = sm.GetStudents(Convert.ToInt32(smclassCmb.SelectedValue));
            smDgStudentLsit.ItemsSource = students;
        }

        List<int> IdList = new List<int>();
        List<FrmStudentInfor> frmList = new List<FrmStudentInfor>();
        /// <summary>
        /// 当鼠标双击某个学员查看这个学员的详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smDgStudentLsit_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StudentExt selectStu = smDgStudentLsit.SelectedItem as StudentExt;
            if (selectStu==null)
            {
                return;
            }
            ///当这个学员的完整信息已经存在的话，证明已经打开了一个窗口
            ///除非是打开新的学员窗口，否则只能把之前的窗口给呈现出来
            if (IdList.Contains(selectStu.StudentId))
            {
                foreach (FrmStudentInfor item in frmList)
                {
                    if (item.StuId==selectStu.StudentId)
                    {
                        //激活窗口，
                        item.Activate();
                    }
                }
            }
            else
            {
                StudentExt objStu = sm.GetStudentById(selectStu.StudentId);
                IdList.Add(selectStu.StudentId);
                View.FrmStudentInfor studentInfor = new FrmStudentInfor(objStu);
                studentInfor.Closing += StudentInfor_Closing;
                frmList.Add(studentInfor);
                //展示窗口
                studentInfor.Show();
            }
        }
        /// <summary>
        /// 移除关闭的窗口对应的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentInfor_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int stuId = (sender as FrmStudentInfor).StuId;
            IdList.Remove(stuId);
            foreach (FrmStudentInfor item in frmList)
            {
                if (item.StuId==stuId)
                {
                    frmList.Remove(item);
                    return;
                }
            }
        }
    }
    //声明比较器
    class StudentIdDESC : IComparer<StudentExt>
    {
        ///-1，0，1
        public StudentIdDESC(bool b)
        {
            B = b;
        }
        public bool B { get; set; }
        public int Compare(StudentExt x, StudentExt y)
        {
            if (B)
            {
                return x.StudentId.CompareTo(y.StudentId);
            }
            else
            {
                return y.StudentId.CompareTo(x.StudentId);
            }
        }
    }

    class StudentNameDESC : IComparer<StudentExt>
    {
        ///-1，0，1
        public StudentNameDESC(bool b)
        {
            B = b;
        }
        public bool B { get; set; }
        public int Compare(StudentExt x, StudentExt y)
        {
            if (B)
            {
                return y.StudentName.CompareTo(x.StudentName);
            }
            else
            {
                return x.StudentName.CompareTo(y.StudentName);
            }
        }
    }
}
