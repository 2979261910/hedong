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
using StudentManagerModel.ObjExt;
using Common;
using System.IO;

namespace StudentManager.View
{
    /// <summary>
    /// FrmStudentInfor.xaml 的交互逻辑
    /// </summary>
    public partial class FrmStudentInfor : Window
    {
        //构造函数
        public FrmStudentInfor(StudentExt stu)
        {
            InitializeComponent();
            StuId = stu.StudentId;
            this.Title = stu.StudentName + "-信息";
            lblAddress.Content = stu.StudentAddress;
            lblAge.Content = stu.Age;
            lblBirthday.Content = stu.Birthday.ToString("yyyy-MM-dd");
            lblCardNo.Content = stu.CardNo;
            lblClassName.Content = stu.ClassName;
            lblGender.Content = stu.Gender;
            lblName.Content = stu.StudentName;
            lblPhoneNumber.Content = stu.PhoneNumber;
            lblStuId.Content = stu.StudentId;
            lblStuNoId.Content = stu.StudentIdNo;
            if (string.IsNullOrEmpty(stu.StuImage))
            {
                stuImg.Source = new BitmapImage(new Uri("/img/bg/zwzp.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                //如果学员的Iamge字段中能够查询到数据，那么就可以直接将这个数据反序列化成BitmapImage对象
                common.BitmapImg image = SerializeObjectTostring.DeserializeObject(stu.StuImage) as common.BitmapImg;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = new MemoryStream(image.Buffer);
                bitmap.EndInit();
                stuImg.Source = bitmap;
            }
        }
        /// <summary>
        /// 这个属性用它来记录当前窗口中绑定的学员信息是谁的
        /// </summary>
        public int StuId { get; set; }
    }
}
