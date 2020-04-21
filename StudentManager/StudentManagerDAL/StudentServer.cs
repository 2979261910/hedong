using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagerModel.ObjExt;
using StudentManagerModel;
using StudentManagerDAL;
using System.Data.SqlClient;

namespace StudentManagerDAL
{
    /// <summary>
    /// 学生管理的数据访问服务
    /// </summary>
    public class StudentServer
    {
        public List<StudentExt> GetStudents(int cid)
        {
            string sql = "SELECT StudentId,StudentName,Gender,Birthday,StudentIdNo,CardNo,StuImage,Age,PhoneNumber,StudentAddress,StudentClass.ClassName FROM Students INNER JOIN StudentClass ON StudentClass.ClassId=Students.ClassId WHERE StudentClass.ClassId=" + cid;
            SqlDataReader reader = DBHelper.SQLHelper.GetReader(sql);
            List<StudentExt> list = DataReturnObj(reader);
            reader.Close();
            return list;
        }

        private static List<StudentExt> DataReturnObj(SqlDataReader reader)
        {
            List<StudentExt> list = new List<StudentExt>();
            while (reader.Read())
            {
                list.Add(new StudentExt()
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    Age = Convert.ToInt32(reader["Age"]),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    CardNo = reader["CardNo"].ToString(),
                    ClassName = reader["ClassName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    StudentAddress = reader["StudentAddress"].ToString(),
                    StudentIdNo = reader["StudentIdNo"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    StuImage = reader["StuImage"].ToString()
                });
            }

            return list;
        }

        /// <summary>
        /// 根据ID或者名称模糊查询
        /// </summary>
        /// <returns></returns>
        public List<StudentExt> GetStudentByIdOrName(string target)
        {
            string sql = string.Format("SELECT StudentId,StudentName,Gender,Birthday,StudentIdNo,CardNo,StuImage,Age,PhoneNumber,StudentAddress,StudentClass.ClassName FROM Students INNER JOIN StudentClass ON StudentClass.ClassId=Students.ClassId WHERE StudentId LIKE '%{0}%' OR StudentName LIKE '%{0}%'",target);
            SqlDataReader reader = DBHelper.SQLHelper.GetReader(sql);
            List<StudentExt> list = DataReturnObj(reader);
            reader.Close();
            return list;
        }

        public StudentExt GetStudentById(int id)
        {
            string sql = string.Format("SELECT StudentId,StudentName,Gender,Birthday,StudentIdNo,CardNo,StuImage,Age,PhoneNumber,StudentAddress,Students.ClassId,StudentClass.ClassName FROM Students INNER JOIN StudentClass ON StudentClass.ClassId=Students.ClassId WHERE StudentId = {0}", id);
            SqlDataReader reader = DBHelper.SQLHelper.GetReader(sql);
            StudentExt student = null;
            while (reader.Read())
            {
                student = new StudentExt()
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    Age = Convert.ToInt32(reader["Age"]),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    CardNo = reader["CardNo"].ToString(),
                    ClassName = reader["ClassName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    StudentAddress = reader["StudentAddress"].ToString(),
                    StudentIdNo = reader["StudentIdNo"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    StuImage = reader["StuImage"].ToString(),
                    ClassId =Convert.ToInt32(reader["ClassId"])
                };
            }
            return student;
        }


        public int UpdateStudentInfor(StudentExt student)
        {
            string sql = string.Format("UPDATE Students SET StudentName='{0}',Gender='{1}',Birthday='{2}',StudentIdNo='{3}',CardNo='{4}',StuImage='{5}',Age={6},PhoneNumber='{7}',StudentAddress='{8}',ClassId={9} WHERE StudentId={10}", student.StudentName, student.Gender, student.Birthday, student.StudentIdNo, student.CardNo, student.StuImage, student.Age, student.PhoneNumber, student.StudentAddress, student.ClassId, student.StudentId);
            return DBHelper.SQLHelper.ExecuteNonQuery(sql);
        }
    }
}
