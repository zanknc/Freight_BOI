using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Import_Freight_BOI.Models.TSQL
{
    public class mgrSQLConnect
    {
        private readonly IConfiguration configuration;
        private DataSet ds = new DataSet();

        private string strSQL = "";

        public mgrSQLConnect(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DataTable GetDatatables(string Sql)
        {
            var constr = configuration.GetConnectionString("CONN");
            var dt = new DataTable();


            try
            {
                var query = Sql;

                var ds = new DataSet();
                using (var con = new SqlConnection(constr))
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        var adpterdata = new SqlDataAdapter();
                        adpterdata.SelectCommand = new SqlCommand(query, con);
                        adpterdata.Fill(dt);
                        con.Close();
                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                var dsa = e;
                return dt;
            }
        }

        public DataTable GetDataTableCmd(SqlCommand objCmd)
        {
            DataTable objDataTbl;
            SqlDataAdapter objDataAdp;
            //SqlConnection Con;        

            var constr = configuration.GetConnectionString("CONN");
            try
            {
                // make result DataTable instance
                objDataTbl = new DataTable();
                using (var connection = new SqlConnection(constr))
                {

                    objDataAdp = new SqlDataAdapter();
                    objCmd.Connection = connection;
                    objDataAdp.SelectCommand = objCmd;
                    objDataAdp.Fill(objDataTbl);


                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    return objDataTbl;

                }


            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }


        public DataSet GetDataSets(string SQL)
        {
            try
            {

                DataSet dtSet;
                dtSet = new DataSet();
                var con = configuration.GetConnectionString("CONN");
                using(var Connect = new SqlConnection(con))
                {
                    //using(var cmd = new SqlCommand())
                    //{
                    //    cmd.CommandText = "";
                        Connect.Open();
                        var DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = new SqlCommand(SQL, Connect);
                        DataAdapter.Fill(dtSet);
                        Connect.Close();
                    //}

                }


                return dtSet;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int ExcuteProc(String Str)
        {
            int excproc = 0;

            try
            {

                var conn = configuration.GetConnectionString("CONN");
               
                using(var con = new SqlConnection(conn))
                {
                    using(var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = Str;
                        con.Open();
                        excproc = cmd.ExecuteNonQuery();
                        con.Close();
                       
                    }
                }

                return excproc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }





    }

}