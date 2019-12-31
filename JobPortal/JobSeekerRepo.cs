using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class JobSeekerRepo
    {
        public static string JobSeekerSignIn(params string[] info)
        {
            int i = 0;
            return "select * from jobseeker where id='" + info[i++] + "' and password='" + info[i++] + "';";
        }
        public static string SearchJobSeekerByName(string name)
        {
            return "select * from jobseeker where name like '%" + name + "%'";
        }
        public static string SearchJobSeekerByBoard(string board)
        {
            return @"select * from jobseeker where id in ( select jobseekerid from educationalqualification where board like '%" + board +"%');";
        }
        public static string SearchJobSeeker(params string[] info)
        {
            int i = 0;
            return @"select * from jobseeker where name like '%" + info[i++] + "%' and id " +
                "in ( select jobseekerid from educationalqualification where board like '%" + info[i++] +
                "%' and cgpa between " + info[i++] + " and " + info[i++] + " );";
        }
        public static string GetAppliedJobSeeker(int JobId)
        {
            return @"select * from jobseeker js, jobseekerjob jsj where js.id=jsj.jobseekerid and jsj.jobid=" + JobId + ";";
        }
        
        public static void InsertJobssekerJob(params string[] info)
        {
            int i = 0;
            string sql = "insert into jobseekerjob values ('" + info[i++]  + "'," + info[i++]  + ");";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void DeleteJobseekerjob(string id)
        {
            string sql = "delete from jobseekerjob where jobseekerid ='" + id + "';";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void DeleteJobSeeker(string id)
        {
            string sql = "delete from jobseeker where id='" + id + "' ;";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void InsertJobseeker(params string[] info)
        {
            int i = 0;
            string sql = @"insert into jobseeker values('" + info[i++] + "','" + info[i++] + "','" + info[i++] + "','" + info[i++] +
                                    "','" + info[i++] + "','" + info[i++] + "','" + info[i++] + "','" + info[i++] + "','" + info[i++] + "','" + info[i++] +
                                    "'," + info[i++] + ",'" + info[i++] + "');";

            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void UpdateJobseeker(params string[] info)
        {
            int i = 0;
            string sql = @"update jobseeker set password='" + info[i++] + "', name='" + info[i++] + "', address='" + info[i++] +
                                    "', contactno='" + info[i++] + "', email='" + info[i++] + "',gender='" + info[i++] + "', dateofbirth='" + info[i++] + 
                                    "', bloodgroup='" + info[i++] + "', skill='" + info[i++] + "', workexperience=" + info[i++] + ", photopath='" + info[i++] +
                                    "' where id='" + info[i++] + "';";

            DataAccess.ExecuteUpdateQuery(sql);
        }
    }
}
