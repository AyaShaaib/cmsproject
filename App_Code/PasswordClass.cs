using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{

    public class PasswordClass
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public void getUser(string Email)
        {
            string query = "Select * from Users Where Email=@Email";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@Email", Email);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                Fname = reader["Fname"].ToString();
                UserId = int.Parse(reader["UserId"].ToString());
                Email = reader["Email"].ToString();
            }
        }
        public void UploadCode(string Email,string Code)
        {
            string Query = "Update Users set Code=@Code WHERE Email=@Email";
            var con = new SqlConnection(Global.MyConn);
            SqlCommand command = new SqlCommand(Query, con);
            con.Open();
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Email", Email);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
    
}