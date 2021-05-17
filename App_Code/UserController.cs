using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{   
    public class UserController
    {
    
        public int UserId { get; set; }
        public string Fname{ get; set; }
        public string Lname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string responsemessage { get; set; }
        /// <summary>
        /// this function is used to get all users and their data to bind to a repeater in a table using data adapter and datatable extracted from database
        /// </summary>
        /// <returns></returns>
        public DataTable getUsers()
        {

            string Query = "SELECT * FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// This Func is used to get all data of a certain user to view on ViewMore page 
        /// </summary>
        /// <param name="UserId"></param>
        public void getuserdetails ( int UserId )
        {
            string Query = "SELECT * FROM [Users] WHERE UserId = @UserId";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@UserId",UserId);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                UserId = int.Parse(reader["UserId"].ToString());
                Fname = reader["Fname"].ToString();
                Lname = reader["Lname"].ToString();
                Email = reader["Email"].ToString();
                PhoneNumber = reader["PhoneNumber"].ToString();
            }
            connection.Close();
        }
        /// <summary>
        /// This Func deletes a cerain user using his ID 
        /// </summary>
        /// <param name="UserId"></param>
        public void deleteuser(int UserId)
        {
            string query = "delete from Users Where UserId=@UserId";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@UserId", UserId);
            Cmd.CommandText=query;
            Cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// This Func Updates a user's password using his Id in a stored procedure since there is a salting, hashing , and encryption procedure.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="PasswordHash"></param>
        public void Updatepassword(int UserId,string PasswordHash)
        {
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand command = new SqlCommand("Proc_ChangePass",connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserId", UserId);
            command.Parameters.AddWithValue("@PasswordHash",PasswordHash);
            command.Parameters.Add("@responsemessage", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            string responsemessage = Convert.ToString(command.Parameters["@responsemessage"].Value);
            connection.Close();
            }
        /// <summary>
        /// This Func Unlocks a user account by setting the islocked value to 0 and attempts to 0.
        /// </summary>
        /// <param name="UserId"></param>
        public void UnlockAccount(int UserId)
        {
            string query = "Update Users set IsLocked='0',AttemptsCount='0' Where UserId=@UserId";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@UserId", UserId);
            Cmd.ExecuteNonQuery();
            connection.Close();

        }  
       
    }
}