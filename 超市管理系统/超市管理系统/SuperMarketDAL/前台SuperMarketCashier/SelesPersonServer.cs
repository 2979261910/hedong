using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketIDAL;
using SuperMarketModel;
using System.Data.SqlClient;
using System.Data;

namespace SuperMarketDAL.前台SuperMarketCashier
{
    public class SelesPersonServer : SuperMarketIDAL.前台SuperMarketCashier.ISelesPersonServer
    {
        //登录收银员的方法
        public SelesPersonSModel SelesLogin(SelesPersonSModel seles)
        {
            string str = "SelesLogeIn";
            SqlParameter[] sp = 
            {
                new SqlParameter("@LoginId", SqlDbType.Int),
                new SqlParameter("@LoginPwd", SqlDbType.NVarChar,50)
            };
            sp[0].Value = seles.SalesPersonId;
            sp[1].Value = seles.LoginPwd;
            SqlDataReader reader = SQLHelper.GetDataReader(str, sp);
            SelesPersonSModel model = null;
            while (reader.Read())//reader拿到数据库里面的值
            {
                model = new SelesPersonSModel()
                {
                    SalesPersonId = Convert.ToInt32(reader["SalesPersonId"]),//reader里面对应的值是数据库里面的值
                    LoginPwd = int.Parse(reader["LoginPwd"].ToString()),
                    SPName = reader["SPName"].ToString()
                };
            }
            return model;
        }

        /// <summary>
        /// 日志记录成功返回本次日志ID号
        /// </summary>
        /// <param name="loginLogs"></param>
        /// <returns></returns>
        public int WriteSelesLog(LoginLogsModel loginLogs)
        {
            string str = "WriteLog";
            SqlParameter[] sp =
           {
                new SqlParameter("@LoginId", SqlDbType.Int),
                new SqlParameter("@SPName", SqlDbType.NVarChar,50),
                new SqlParameter("@ServerName",SqlDbType.NVarChar,100)
            };
            sp[0].Value = loginLogs.LoginId;
            sp[1].Value = loginLogs.SPName;
            sp[2].Value = loginLogs.ServerName;
            //int a=SQLHelper.ExecuteNonQuery(str,sp);
            object a = SQLHelper.ExecuteScalar(str, sp);//拿单一结果
            if (a==null)
            {
                return -1;
            }
            return int.Parse(a.ToString());
        }


        public int WriteSelesExitLog(int loginID)
        {
            string str = "ExitSysWriteLog";
            SqlParameter[] sp =
           {
                new SqlParameter("@LogId", SqlDbType.Int)
            };
            sp[0].Value = loginID;
            int a=SQLHelper.ExecuteNonQuery(str,sp);
            return a;
        }

        public DateTime GetSysTime()
        {
            string procName = "GetSysTime";
            return Convert.ToDateTime(SQLHelper.ExecuteScalar(procName, null));
        }

       
    }
}
