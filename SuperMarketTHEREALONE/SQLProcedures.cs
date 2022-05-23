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
        public static string connstr = "Data Source=DESKTOP-J23P8GB\\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;

        public static void InsertUsers(string name,string surname, string email, string password, int age, string address, int phoneNumber)
        {
            cmd = new SqlCommand("InsertUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, (50));
            sp[0].Value = name;
            sp[1] = new SqlParameter("@UserSurname", SqlDbType.NVarChar, (50));
            sp[1].Value = surname;
            sp[2] = new SqlParameter("@UserEmail", SqlDbType.NVarChar, (50));
            sp[2].Value = email;
            sp[3] = new SqlParameter("@UserPassword", SqlDbType.NVarChar, (50));
            sp[3].Value = password;
            sp[4] = new SqlParameter("@UserAge", SqlDbType.Int);
            sp[4].Value = age;
            sp[5] = new SqlParameter("@UserAddress", SqlDbType.NVarChar, (50));
            sp[5].Value = address;
            sp[6] = new SqlParameter("@UserPhoneNumber", SqlDbType.Int);
            sp[6].Value = phoneNumber;
            cmd.Parameters.AddRange(sp);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();   
        }
        public static void SelectUsers(string email, string password)
        {

        }
    }   
}
