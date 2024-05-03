using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace AdoNET.Helpers
{
    public class SqlHelper
    {
        const string connectionString = "Server=CA-R214-PC03\\SQLEXPRESS;Database=Spotify;Trusted_Connection=True;";
        public static DataTable ExecuteQuery(string query)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            using SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static int Execute(string query)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            using SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteNonQuery();
        }
        //Bu class-da olmali deyil bashqa help-er yaradib extension etmek meqsedeuygundur ezizim)))
        public static string HashPassword(string password)
        {
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.Default.GetBytes(password)));
        }
    }
}
