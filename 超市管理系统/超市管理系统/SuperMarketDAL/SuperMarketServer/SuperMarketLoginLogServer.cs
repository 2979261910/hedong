using SuperMarketIDAL.SuperMarketManager;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDAL.SuperMarketServer
{
    public class SuperMarketLoginLogServer : ISuperMarketLoginLogServer
    {
        public List<LoginLogsModel> GetLoginLog()
        {
            string procName = "GetLoginLogs";
            SqlDataReader reader = SQLHelper.GetDataReader(procName, null);
            List<LoginLogsModel> list = new List<LoginLogsModel>();
            while (reader.Read())
            {
                LoginLogsModel logs = new LoginLogsModel();
                logs.LogId = Convert.ToInt32(reader["LogId"]);
                if (string.IsNullOrEmpty(reader["ExitTime"].ToString()))
                {
                    logs.ExitTime = null;
                }
                else
                {
                    logs.ExitTime = Convert.ToDateTime(reader["ExitTime"]);
                }
                logs.LoginId = Convert.ToInt32(reader["LoginId"]);
                logs.SPName = reader["SPName"].ToString();
                logs.ServerName = reader["ServerName"].ToString();
                logs.LoginTime = Convert.ToDateTime(reader["LoginTime"]);
                list.Add(logs);
            }
            reader.Close();
            return list;
        }

        public List<LoginLogsModel> GetLoginLogBy(DateTime starttime, DateTime endTime, string wheres, int check)
        {
            string procName = "GetLoginLogBy";
            SqlParameter[] sp =
            {
                new SqlParameter("@startTime",starttime),
                new SqlParameter("@endTime",endTime),
                new SqlParameter("@where",wheres),
                new SqlParameter("@check",check)
            };
            SqlDataReader reader = SQLHelper.GetDataReader(procName, sp);
            List<LoginLogsModel> list = new List<LoginLogsModel>();
            while (reader.Read())
            {
                LoginLogsModel logs = new LoginLogsModel();
                logs.LogId = Convert.ToInt32(reader["LogId"]);
                if (string.IsNullOrEmpty(reader["ExitTime"].ToString()))
                {
                    logs.ExitTime = null;
                }
                else
                {
                    logs.ExitTime = Convert.ToDateTime(reader["ExitTime"]);
                }
                logs.LoginId = Convert.ToInt32(reader["LoginId"]);
                logs.SPName = reader["SPName"].ToString();
                logs.ServerName = reader["ServerName"].ToString();
                logs.LoginTime = Convert.ToDateTime(reader["LoginTime"]);
                list.Add(logs);
            }
            reader.Close();
            return list;
        }
    }
    
}
