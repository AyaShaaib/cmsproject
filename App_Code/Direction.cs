using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Annex.App_Code
{
    
    public class DirectionController{

        private int _DirectionID;
        private string _DirectionTitle;
        private bool _DefaultDirection;

        public int DirectionID { get { return _DirectionID; } set { _DirectionID = value; } }
        public string DirectionTitle { get { return _DirectionTitle; } set { _DirectionTitle = value; } }
        public bool DefaultDirection { get { return _DefaultDirection; } set { _DefaultDirection = value; } }

        /// <summary>
        /// Add Direction
        /// </summary>
        /// <param name="DirectionTitle">Required</param>
        /// <param name="DefaultDirection">Required</param>
        public void Insert(string DirectionTitle, bool DefaultDirection)
        {
            if (DefaultDirection)
            {
                ResetDefaultDirections();
            }
            string query = "INSERT INTO Direction (DirectionTitle, DefaultDirection) " + "VALUES(@DirectionTitle, @DefaultDirection)";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DirectionTitle", DirectionTitle);
            cmd.Parameters.AddWithValue("@DefaultDirection", DefaultDirection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// edit dirrection
        /// </summary>
        /// <param name="DirectionID"></param>
        /// <param name="DirectionTitle"></param>
        /// <param name="DefaultDirection"></param>
        public void Update(int DirectionID, string DirectionTitle, bool DefaultDirection)
        {
            if (DefaultDirection)
            {
                ResetDefaultDirections();
            }
            string query = "UPDATE Direction SET DirectionTitle = @DirectionTitle, DefaultDirection = @DefaultDirection WHERE DirectionID = @DirectionID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DirectionID", DirectionID);
            cmd.Parameters.AddWithValue("@DirectionTitle", DirectionTitle);
            cmd.Parameters.AddWithValue("@DefaultDirection", DefaultDirection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// delete direction
        /// </summary>
        /// <param name="DirectionID"></param>
        public void DeleteDirection(int DirectionID)
        {
            if (IsDefaultDirection(DirectionID))
            {
                ResetDefaultDirections();
            }
            else
            {
                string query = "DELETE FROM Direction WHERE DirectionID = @DirectionID";
                var connection = new SqlConnection(Global.MyConn);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DirectionID", DirectionID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        /// <summary>
        /// reset default directions 
        /// </summary>
        public void ResetDefaultDirections()
        {
            string query = "UPDATE Direction SET DefaultDirection = 'false'";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.ExecuteNonQuery();
            connection.Close();
        }

        public bool IsDefaultDirection(int DirectionID)
        {
            return false;
        }

        public void MakeDefault(int DirectionID)
        {
            ResetDefaultDirections();
        }
        /// <summary>
        /// get directions
        /// </summary>
        /// <returns></returns>
        public DataTable GetDirections()
        {
            string Query = "SELECT * FROM Direction";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// check availability
        /// </summary>
        /// <param name="DirectionID"></param>
        public void GetDirection(int DirectionID) 
        { 
            string Query = "SELECT * FROM Direction WHERE DirectionID = @DirectionID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@DirectionID", DirectionID);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                DirectionID = int.Parse(reader["DirectionID"].ToString());
                DirectionTitle = reader["DirectionTitle"].ToString();
                DefaultDirection = bool.Parse(reader["DefaultDirection"].ToString());
            }
            connection.Close();
        }

        public DataTable GetDefaultDirections()
        {
            string Query = "SELECT * FROM Language WHERE DefaultDirection = 'true'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}