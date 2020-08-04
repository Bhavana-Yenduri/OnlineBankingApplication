using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace OnlineBankingSystem
{
    public class DbClass
    {
    //    static String constring = "Data Source=localhost;Initial Catalog=raju;uid=raju; password=raju;";


    //    SqlConnection con = new SqlConnection(constring);

    //    SqlCommand cmd = new SqlCommand();

    //    cmd.Connection = con;


        public DataSet viewTransactions()
        {
            //String constring = "DataSource=DESKTOP-H31D7FE;InitialCatlog=raju;username=raju; password=raju;";

            String constring = "Data Source=localhost;Initial Catalog=raju;uid=raju; password=raju;";


            SqlConnection con = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "usp_viewtransactions";

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(ds);

            return ds;


        }

        public int GetCurrentBalance()
        {
            String constring = "Data Source=localhost;Initial Catalog=raju;uid=raju; password=raju;";


            SqlConnection con = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;


            cmd = new SqlCommand("usp_GetCurrentBalance", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@bal", SqlDbType.Int);

            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);

            con.Open();

            int n = cmd.ExecuteNonQuery();


             return Convert.ToInt32(cmd.Parameters["@bal"].Value);
        }

        public int AddTransaction(int amount,string des)
        {

        String constring = "Data Source=localhost;Initial Catalog=raju;uid=raju; password=raju;";


        SqlConnection con = new SqlConnection(constring);

        SqlCommand cmd = new SqlCommand();

        cmd.Connection = con;


            cmd = new SqlCommand("usp_addTransaction", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@amount", amount);

            cmd.Parameters.AddWithValue("@des", des);


            con.Open();

            int n = cmd.ExecuteNonQuery();

            return n;

        }

    }



}