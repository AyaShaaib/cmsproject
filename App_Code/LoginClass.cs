using System;
using System.Data;
using System.Data.SqlClient;

namespace Annex
{

    public class LoginClass
    {
        public int UserId { get; set; }
        public int AttemptsCount { get; set; }
        public string IsLocked { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// This Function accesses a stored procedure since our password is stored hashed,salted and encrypted 
        /// It hashes the password and salt it and checks wethere  this account exists after checking it returns a response message that has either (1,0,-1)
        /// 1: exists 
        /// 0:wrong pass or email
        /// -1: invalid account
        /// </summary>
        /// <param name="usremail"></param>
        /// <param name="usrpassword"></param>
        /// <returns></returns>
        public int LoginMethod(string usremail, string usrpassword)
        {
            SqlConnection con = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand("Proc_UserLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Email", usremail);
            cmd.Parameters.AddWithValue("@Password", usrpassword);
            cmd.Parameters.Add("@responsemessage", SqlDbType.Int, 255).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            String responsemessage = Convert.ToString(cmd.Parameters["@responsemessage"].Value);
            return int.Parse(responsemessage);
        }
        /// <summary>
        /// This Func gets the attempts by a user to access his/her account but failed by using the email 
        /// </summary>
        /// <param name="Email"></param>
        public void getattempts(string Email)
        {
            string query = "Select * from Users Where Email=@Email";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@Email", Email);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                AttemptsCount = int.Parse(reader["AttemptsCount"].ToString());
                UserId = int.Parse(reader["UserId"].ToString());
                Email = reader["Email"].ToString();
            }
        }
        /// <summary>
        /// This Function is called when the user reaches the 4th attempt of logging in but fails and when called it sets the Islocked param to 1 which locks the account
        /// </summary>
        /// <param name="usremail"></param>
        public void lockaccount(string usremail)
        {
            string query = "Update Users set IsLocked='1' Where Email=@Email";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@Email",usremail);
            //Cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            Cmd.ExecuteNonQuery();
            connection.Close();

        }
        /// <summary>
        /// This Func updates the attempts by the user everytime failing to login or when the admin resets it and unlock the account
        /// </summary>
        /// <param name="AttemptsCount"></param>
        /// <param name="usremail"></param>
        public void updateAttempts(int AttemptsCount,string usremail)
        {
            string query = "Update Users set AttemptsCount=@AttemptsCount Where Email=@Email";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@Email", usremail);
            Cmd.Parameters.AddWithValue("@AttemptsCount", AttemptsCount);
            Cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// This Func Checks if the account is locked on a login attempt 
        /// </summary>
        /// <param name="usremail"></param>
        public void checkiflocked(string usremail)
        {
            string query = "Select * from Users where Email=@Email";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@Email", usremail);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                IsLocked = reader["IsLocked"].ToString();
                UserId = int.Parse(reader["UserId"].ToString());
                Email = reader["Email"].ToString();
            }


        }
    }
}