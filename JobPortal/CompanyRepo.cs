using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class CompanyRepo
    {
        public static string GetAll()
        {
            return @"select * from company order by id;";
        }
        public static void DeleteCompany(string Id)
        {
            
            string sql = "delete from company where id='" + Id + "' ;";
            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static string CompanySignIn(params string[] info)
        {
            int i = 0;
            return "select * from company where id='" + info[i++] + "' and password='" + info[i++] + "';";
        }
        public static DataSet GetAll(string id)
        {
            string sql = "select * from company where id='" + id + "';";
            return DataAccess.ExecuteQuery(sql);
        }
        public static void InsertCompany(params string[] info)
        {
            int i = 0;
            string sql = @"insert into company values('" + info[i++] + "','" + info[i++] + "','" + info[i++] + "','" + info[i++] +
                                    "','" + info[i++] + "','" + info[i++] + "','" + info[i++] + "');";

            DataAccess.ExecuteUpdateQuery(sql);
        }
        public static void UpdateCompany(params string[] info)
        {
            int i = 0;
            string sql = @"update company set password='" + info[i++] + "', name='" + info[i++] + "', address='" +
                                    info[i++] + "',email='" + info[i++] + "', contactno='" + info[i++] + "', logopath='" + info[i++] + "'" +
                                    "where id='" + info[i++] + "';";

            DataAccess.ExecuteUpdateQuery(sql);
        }

    }
}
