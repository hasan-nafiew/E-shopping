using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace e_ShoppingDataLayer
{
   public class DataAccess
    {
       static string _ConnectionString = ConfigurationManager.ConnectionStrings["MyCon"].ToString();
        static SqlConnection _Connection = null;
        public static SqlConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new SqlConnection(_ConnectionString);
                    _Connection.Open();

                    return _Connection;
                }
                else if (_Connection.State != System.Data.ConnectionState.Open)
                {
                    _Connection.Open();

                    return _Connection;
                }
                else
                {
                    return _Connection;
                }
            }
        }

        static DataSet GetDataSet(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            Connection.Close();

            return ds;
        }

        public static DataSet GetDataSetSP(string sp, SqlParameter[] objParams)
        {
            SqlCommand cmd = new SqlCommand(sp, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(objParams);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            Connection.Close();

            return ds;
        }

        

        public static DataTable GetDataTable(string sql)
        {
            DataSet ds = GetDataSet(sql);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        public static DataTable GetDataTableSp(string sq)
        {
            DataSet ds = GetDataSet(sq);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

       public static DataTable GetDataTableSP(string sp,SqlParameter[] objParams)
        {
            DataSet ds = GetDataSetSP(sp,objParams);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        public static int ExecuteSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static int ExecuteSQL(string sql, SqlParameter p)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.Add(p);
            return cmd.ExecuteNonQuery();
        }

        public static int ExecuteSPSQL(string sql, SqlParameter[] objParams)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(objParams);
            return cmd.ExecuteNonQuery();
        }

        public static int ExecuteSP(string sql, SqlParameter[] objParams)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(objParams);
            return (int)cmd.ExecuteScalar();
        }

       
    }
}