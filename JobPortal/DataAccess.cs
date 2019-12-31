using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class DataAccess
    {
        public static int companySerial = 0;
        public static int jobSeekerSerial = 0;
        public static int jobSerial = 0;

        private static SqlConnection sqlcon;
        public static SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private static SqlCommand sqlcom;
        public static SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static SqlDataAdapter sda;
        public static SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;
        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            
                Sqlcon = new SqlConnection(@"Data Source=DADDY-THEPRINCE\SQLEXPRESS;Initial Catalog=JobPortalDB;Persist Security Info=True;User ID=sa;Password=P@$$w0rd");
                Sqlcon.Open();
                jobSerial = SearchMaxJobID();
                jobSeekerSerial = JobSeekerSerial();
                companySerial = CompanySerial();
            
            
        }

        public static int SearchMaxJobID()
        {
            string sql = @"select MAX(id) as id from job;";
            
            try
            {
                DataSet ds = ExecuteQuery(sql);
                return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            }
            catch
            {

            }
            return 0;

        }
        public static int JobSeekerSerial()
        {
            string sql = @"select jobseekerserial from serial;";

            try
            {
                DataSet ds = ExecuteQuery(sql);
                return Convert.ToInt32(ds.Tables[0].Rows[0]["jobseekerserial"].ToString());
            }
            catch
            {

            }
            return 0;

        }
        public static int CompanySerial()
        {
            string sql = @"select companyserial from serial;";

            try
            {
                DataSet ds = ExecuteQuery(sql);
                return Convert.ToInt32(ds.Tables[0].Rows[0]["companyserial"].ToString());
            }
            catch
            {

            }
            return 0;

        }
        public static void UpdateCompanySerial()
        {
            companySerial++;
            string sql = @"update serial set companyserial=" + companySerial + " where companyserial="+(companySerial-1)+";";

            try
            {
                ExecuteUpdateQuery(sql);
            }
            catch
            {

            }

        }
        public static void UpdateJobSeekerSerial()
        {
            jobSeekerSerial++;
            string sql = @"update serial set jobseekerserial="+ jobSeekerSerial + " where jobseekerserial="+(jobSeekerSerial-1)+";";

            try
            {
                ExecuteUpdateQuery(sql);
            }
            catch
            {

            }

        }


        private static void QueryText(string query)
        {
            Sqlcom = new SqlCommand(query, Sqlcon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }

        public static int ExecuteUpdateQuery(string sql)
        {
            QueryText(sql);
            int u = Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
