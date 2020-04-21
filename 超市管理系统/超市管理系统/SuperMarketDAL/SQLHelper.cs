using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;//倒入配制文件
using System.Data.SqlClient;
using System.Data;

namespace SuperMarketDAL
{
     class SQLHelper
    {
        static string Constr = ConfigurationManager.ConnectionStrings["Constr"].ConnectionString;
        //增删改
        public static int ExecuteNonQuery(string ProcName,SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(Constr);
           

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = ProcName;
            if (sp!=null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                con.Open();
                int a = com.ExecuteNonQuery();
                return a;
            }
            catch (Exception)
            {
                return -1;
                /*//记入系统日志
                throw ex;*/
            }
            finally 
            {
                con.Close();
            }
        }
        public static Object ExecuteScalar(string ProcName, SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(Constr);


            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = ProcName;
            if (sp != null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                con.Open();
                object a = com.ExecuteScalar();
                return a;
            }
            catch (Exception)
            {
                return null;
                /*//记入系统日志
                throw ex;*/
            }
            finally
            {
                con.Close();
            }
        }

        public static SqlDataReader GetDataReader(string ProcName, SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(Constr);


            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = ProcName;
            if (sp != null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                con.Open();
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                return null;
                //记入系统日志
                throw ex;
            }
        }
        public static DataTable GetDataTable(string ProcName, SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(Constr);


            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = ProcName;
            if (sp != null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return null;
                /*//记入系统日志
                throw ex;*/
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 处理一个事务
        /// </summary>
        /// <returns></returns>
        public static bool UpdateByTran(List<string> procList, List<SqlParameter[]> pslist)
        {
            SqlConnection sqlcon = new SqlConnection(Constr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;
            try
            {
                sqlcon.Open();
                cmd.Transaction = sqlcon.BeginTransaction();
                int index = 0;
                foreach (string procName in procList)
                {
                    cmd.CommandText = procName;
                    if (pslist[index] != null)
                    {
                        cmd.Parameters.AddRange(pslist[index]);
                    }
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    index++;
                }
                cmd.Transaction.Commit();//所有的存储过程执行完没有异常提交
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                return false;
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                sqlcon.Close();
            }
        }
    }
}
