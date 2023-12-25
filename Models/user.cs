using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Debatron_v1._0.Models
{
    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
        public string Bio { get; set; }
        /*public bool LoginProcess(string e, string p)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("SELECT* FROM User where Email = @UserEmail && Password == @pass", con);
            cmd.Parameters.AddWithValue("UserEmail", e);
            cmd.Parameters.AddWithValue("pass", p);
            bool found = false;

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    if (rd.HasRows)
                        found = true;
                    else
                        found = false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return found;
        }*/
    }
}
