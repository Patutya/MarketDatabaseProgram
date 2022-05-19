using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SuperMarketTHEREALONE
{
    internal class SQLProcedures
    {
        public static string connstr = "Data Source=KIU-PC\\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;

        public static void InsertUsers(string name,string surname, string email, string password, int age, string address, int phoneNumber)
        {
            cmd = new SqlCommand("InsertUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@UserName", name);
            sp[1] = new SqlParameter("@UserSurname", surname);
            sp[2] = new SqlParameter("@UserEmail", email);
            sp[3] = new SqlParameter("@UserPassword", password);
            sp[4] = new SqlParameter("@UserAge", age);//     3/10 ide sucks"
            sp[5] = new SqlParameter("@UserAddress", address);
            sp[6] = new SqlParameter("@UserPhoneNumber",phoneNumber);
            cmd.Parameters.AddRange(sp);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();   
        }
    }
}
