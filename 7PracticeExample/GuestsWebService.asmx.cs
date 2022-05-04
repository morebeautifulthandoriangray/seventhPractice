using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _7PracticeExample
{
    /// <summary>
    /// Summary description for GuestsWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GuestsWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void AddGuest(String phone, String name, String email, Boolean agree)
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["GuestDatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                string sql = string.Format("INSERT INTO Guests" +
                                           "(Phone, Name, Email, Agreement) VALUES (@Phone, @Name, @Email, @Agree)");
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Agree", agree);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
