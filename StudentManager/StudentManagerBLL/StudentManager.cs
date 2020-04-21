using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagerDAL;
using StudentManagerModel.ObjExt;
using StudentManagerModel;

namespace StudentManagerBLL
{
    /// <summary>
    /// 学生管理的业务逻辑
    /// </summary>
    public class StudentManager
    {
        StudentServer server = new StudentServer();
        public List<StudentExt> GetStudents(int cid)
        {
            return server.GetStudents(cid);
        }

        public List<StudentExt> GetStudentByIdOrName(string target)
        {
            return server.GetStudentByIdOrName(target);
        }

        public StudentExt GetStudentById(int id)
        {
            return server.GetStudentById(id);
        }

        public bool UpdateStudentInfor(StudentExt student)
        {
            if (server.UpdateStudentInfor(student)<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
