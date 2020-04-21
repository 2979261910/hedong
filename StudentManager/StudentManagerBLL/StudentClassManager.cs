using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagerModel;
using StudentManagerDAL;

namespace StudentManagerBLL
{
    public class StudentClassManager
    {
        StudentClassServer server = new StudentClassServer();
        public List<StudentClass> GetClasses()
        {
            return server.GetClasses();
        }
    }
}
