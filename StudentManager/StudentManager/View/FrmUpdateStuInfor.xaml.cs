using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StudentManagerModel;
using StudentManagerModel.ObjExt;
using StudentManagerBLL;
using Common;
using System.IO;

namespace StudentManager.View
{
    /// <summary>
    /// FrmUpdateStuInfor.xaml 的交互逻辑
    /// </summary>
    public partial class FrmUpdateStuInfor : Window
    {
        StudentClassManager csm = new StudentClassManager();
        StudentManagerBLL.StudentManager manager = new StudentManagerBLL.StudentManager();

        common.BitmapImg image = null;
        public StudentExt student { get; set; }
        public FrmUpdateStuInfor(StudentExt stu)
        {
            InitializeComponent();
            student = stu;
            txtAddress.Text = stu.StudentAddress;
            txtAge.Text = stu.Age.ToString();
            txtCardNo.Text = stu.CardNo;
            txtName.Text = stu.StudentName;
            txtPhoneNumber.Text = stu.PhoneNumber;
            txtStuNoId.Text = stu.StudentIdNo;
            if (stu.Gender == "男")
            {
                radBoy.IsChecked = true;
            }
            else
            {
                radGirl.IsChecked = true;
            }
            datePkBirthday.DisplayDate = stu.Birthday;
            datePkBirthday.SelectedDate = stu.Birthday;
            if (string.IsNullOrEmpty(stu.StuImage))
            {
                stuImg.Source= new BitmapImage(new Uri("/img/bg/zwzp.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                //如果学员的Iamge字段中能够查询到数据，那么就可以直接将这个数据反序列化成BitmapImage对象
                image= SerializeObjectTostring.DeserializeObject(stu.StuImage) as common.BitmapImg;
                img.Buffer = image.Buffer;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = new MemoryStream(image.Buffer);
                bitmap.EndInit();
                stuImg.Source = bitmap;
            }
            List<StudentClass> classes = csm.GetClasses();
            cmbClassName.ItemsSource = classes;
            cmbClassName.DisplayMemberPath = "ClassName";
            cmbClassName.SelectedValuePath = "ClassId";
            cmbClassName.SelectedIndex = stu.ClassId-1;
        }

        private void btnCancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSureUpdate_Click(object sender, RoutedEventArgs e)
        {
            //改变数据之前的最终验证
            if (CheckInfor())
            {
                student.Age = Convert.ToInt32(txtAge.Text);
                student.Birthday = datePkBirthday.DisplayDate;
                student.CardNo = txtCardNo.Text;
                student.ClassId = (int)cmbClassName.SelectedValue;
                student.Gender = (radBoy.IsChecked == true ? "男" : "女");
                student.PhoneNumber = txtPhoneNumber.Text;
                student.StudentAddress = (string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text);
                student.StudentIdNo = txtStuNoId.Text;
                //判断是否重新选择了Image
                if (stuImg.Source == new BitmapImage(new Uri("/img/bg/zwzp.jpg", UriKind.RelativeOrAbsolute)))
                {
                    student.StuImage = null;
                }
                //判断数据库中的图片是否和目前的上传图片一样
                else
                {
                    //证明未修改图片,目前的图片和原来数据库中的一致
                    if (image!=null&&img.Buffer==image.Buffer)
                    {
                        student.StuImage = Common.SerializeObjectTostring.SerializeObject(image);
                    }
                    else
                    {
                        student.StuImage = Common.SerializeObjectTostring.SerializeObject(img);
                    }
                    
                }
                if (manager.UpdateStudentInfor(student))
                {
                    System.Windows.MessageBox.Show("修改成功！", "提示");
                    this.Close();
                }
                else
                {
                    System.Windows.MessageBox.Show("修改失败，请稍后再试！", "提示");
                }
            }
        }
       
        private void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                System.Windows.MessageBox.Show("姓名不能为空！");
                txtName.Focus();
            }
        }
        bool CheckInfor()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                System.Windows.MessageBox.Show("姓名不能为空！");
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                System.Windows.MessageBox.Show("年龄不能为空！");
                txtAge.Focus();
                return false;
            }
            else if (!DataValidate.IsInteger(txtAge.Text))
            {
                System.Windows.MessageBox.Show("年龄必须是纯数字！");
                txtAge.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCardNo.Text))
            {
                System.Windows.MessageBox.Show("打卡号不能为空！");
                txtCardNo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStuNoId.Text))
            {
                System.Windows.MessageBox.Show("身份证号不能为空！");
                txtStuNoId.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                System.Windows.MessageBox.Show("联系方式不能为空！");
                txtPhoneNumber.Focus();
                return false;
            }
            return true;
        }

        private void txtAge_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                System.Windows.MessageBox.Show("年龄不能为空！");
                txtAge.Focus();
            }
            else if (!DataValidate.IsInteger(txtAge.Text))
            {
                System.Windows.MessageBox.Show("年龄必须是纯数字！");
                txtAge.Focus();
            }
        }

        private void txtCardNo_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCardNo.Text))
            {
                System.Windows.MessageBox.Show("打卡号不能为空！");
                txtCardNo.Focus();
            }
        }

        private void txtStuNoId_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStuNoId.Text))
            {
                System.Windows.MessageBox.Show("身份证号不能为空！");
                txtStuNoId.Focus();
            }
        }

        private void txtPhoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                System.Windows.MessageBox.Show("联系方式不能为空！");
                txtPhoneNumber.Focus();
            }
        }
        common.BitmapImg img = new common.BitmapImg();
        private void btnUploadPic_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog();
            fileDialog.Filter = "图像文件(*.jpg;*.jpeg;*.gif;*.png;*.bmp)|*.jpg;*.jpeg;*.gif;*.png,*.bmp";
            if (fileDialog.ShowDialog()==true)
            {
                string path = fileDialog.FileName;
                stuImg.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                stuImg.Stretch = Stretch.UniformToFill;
                img.Buffer = File.ReadAllBytes(path);
            }
        }

        private void btnOpenVideo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
