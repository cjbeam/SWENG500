using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Data
{
    public interface IBaseDataService
    {
        SqlConnection GetSQLConnection();
        DataSet GetDataSet(SqlCommand sqlComm, SqlConnection sqlConn);
        DataTable GetDataTable(SqlCommand sqlComm, SqlConnection sqlConn);
        void ExecuteNonQuery(SqlCommand sqlComm, SqlConnection sqlConn);
    }

    public class BaseDataService
    {
        public SqlConnection GetSQLConnection()
        {
            string conn =
                "Data Source=toneanalyzer.database.windows.net;" +
                "Initial Catalog=ToneAnalyzer;" +
                "User id=sweng500;" +
                "Password=sweng!23;";
            return new SqlConnection(conn);
        }
        public DataSet GetDataSet(SqlCommand sqlComm, SqlConnection sqlConn)
        {
            SqlTransaction sqlTrans = sqlConn.BeginTransaction("GetDataSet");
            DataSet ds = new DataSet();

            try
            {
                sqlComm.Connection = sqlConn;
                sqlComm.Transaction = sqlTrans;
                sqlComm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sqlComm);
                da.Fill(ds);
                ds.Dispose();
                sqlComm.Dispose();
                sqlTrans.Commit();
            }
            finally
            {
                sqlConn.Close();
            }
            return ds;
        }
        public DataTable GetDataTable(SqlCommand sqlComm, SqlConnection sqlConn)
        {
            SqlTransaction sqlTrans = sqlConn.BeginTransaction("GetDataTable");
            DataTable dt = new DataTable();

            try
            {
                sqlComm.Connection = sqlConn;
                sqlComm.Transaction = sqlTrans;
                sqlComm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sqlComm);
                da.Fill(dt);
                dt.Dispose();
                sqlComm.Dispose();
                sqlTrans.Commit();
            }
            finally
            {
                sqlConn.Close();
            }
            return dt;
        }
        public void ExecuteNonQuery(SqlCommand sqlComm, SqlConnection sqlConn)
        {
            SqlTransaction sqlTrans = sqlConn.BeginTransaction("ExecuteNonQuery");

            try
            {
                sqlComm.Connection = sqlConn;
                sqlComm.Transaction = sqlTrans;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.ExecuteNonQuery();
                sqlComm.Dispose();
                sqlTrans.Commit();
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
