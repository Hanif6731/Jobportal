using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class JobRepo
    {
        public static string GetAllJobOfCompany(string companyid)
        {
            return @"select * from job where companyid='" + companyid + "' order by deadline desc;";
        }
        public static string SearchByTitle(string companyid, string title)
        {
            return "select * from job where companyid ='" + companyid + "' and title like '%" + title + "%';";
        }
        public static void DeleteFromJobSeekerJob(string companyid)
        {
            
                string sql = "delete from jobseekerjob where jobid in (select id from job where companyid = '" + companyid + "');";
                DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void DeleteJob(string companyid)
        {
            
            string  sql = "delete from job where companyid='" + companyid + "';";
            DataAccess.ExecuteUpdateQuery(sql);
            
        }
        public static string GetNewJobs()
        {
            return @"select * from job where deadline >='" + DateTime.Now.ToShortDateString() + "' order by deadline desc;";
        }
        public static string GetDeadlineTodayJobs()
        {
            return @"select * from job where deadline ='" + DateTime.Now.ToShortDateString() + "' order by title;";
        }
        public static string SearchByTitle(params string[] info)
        {
            int i = 0;
            return @"select * from job where title like '%" + info[i++] + "%' and deadline >='" + DateTime.Now.ToShortDateString() + "';";
        }
        public static string SearchByCategory(params string[] info)
        {
            int i = 0;
            return "select * from job where category like '%" + info[i] + "%' and deadline >='" + DateTime.Now.ToShortDateString() + "';";
        }
        public static string SearchByAddress(params string[] info)
        {
            int i = 0;
            return "select * from job where address like '%" + info[i++] + "%' and deadline >='" + DateTime.Now.ToShortDateString() + "';";
        }
        public static string SearchSpecificJob(params string[] info)
        {
            int i = 0;
            return @"select * from job where category like '%" + info[i++] + "%'" +
                " and address like '%" + info[i++] + "%'" +
                " and title like '%" + info[i++] + "%' and deadline >='" + DateTime.Now.ToShortDateString() + "';"; 
        }
        public static void DeleteJob(int JobId)
        {
            string sql = "delete from job where id=" + JobId + " ;";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void DeleteJobSeekerJob(int JobId)
        {
            string sql = "delete from jobseekerjob where jobid=" + JobId + " ;";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static string InsertJob(params string[] info)
        {
            int i = 0;
            return @"insert into job values(" + info[i++] + ",'" + info[i++] + "','" + info[i++] +
                                "','" + info[i++] + "','" + info[i++] + "'," + info[i++] + ",'" + info[i++] + "','" +
                                info[i++] + "'," + info[i++] + ",'" + info[i++] + "');";
        }
        public static string UpdateJob(params string[] info)
        {
            int i = 0;
            return @"update job set title='" + info[i++] + "', type='" + info[i++] +
                                "', category='" + info[i++] + "',description='" + info[i++] + "',vacancy=" + info[i++] + ",deadline='" + info[i++] +
                                "', address='" + info[i++] + "', salary=" + info[i++] + " where id=" + info[i++] + ";";
        }


    }
}
