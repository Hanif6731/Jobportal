using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class EducationalQualificationRepo
    {
        
        public static void InsertEducationInfo(params string[] info  )
        {
            int i = 0;
            string sql = @"insert into educationalqualification values('" + info[i++] + "','" + info[i++] + "','" +
                                info[i++] + "','" + info[i++] + "'," + info[i++] + ",'" + info[i++] + "','" + info[i++] + "');";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void UpdateEducationInfo(params string[] info)
        {
            int i = 0;
            string sql = @"update educationalqualification set degree='" + info[i++] + "', major='" + info[i++] + "', passingyear='" +
                                    info[i++] + "', institutionname='" + info[i++] + "', cgpa=" + info[i++] + ", board='" + info[i++] + "' where jobseekerid='" + info[i++] + "' and" +
                                    " degree= '" + info[i++] + "';";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void DeleteEducationInfo(string jId,string Degree)
        {
            string sql = "delete from educationalqualification where jobseekerid='" + jId + "' and degree='" + Degree + "' ;";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void DeleteEducationInfo(string jId)
        {
            string sql = "delete from educationalqualification where jobseekerid='" + jId + "';";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static string GetAll(string id)
        {
            return "select * from educationalqualification where jobseekerid ='" + id + "';";
        }
    }
}
