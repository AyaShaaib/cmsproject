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
    public class WidgetController
    {
        private int _WidgetID;
        private string _WidgetTitle;
        private bool _IsPublished;

        public int WidgetID { get { return _WidgetID; } set { _WidgetID = value; } }
        public string WidgetTitle { get { return _WidgetTitle; } set { _WidgetTitle = value; } }
        public bool IsPublished { get { return _IsPublished; } set { _IsPublished = value; } }


        /// <summary>
        /// add widget
        /// </summary>
        /// <param name="WidgetTitle">required</param>
        /// <param name="IsPublished"></param>
        public void Insert(string WidgetTitle, bool IsPublished)
        {
            string query = "INSERT INTO Widget (WidgetTitle, IsPublished) " + "VALUES(@WidgetTitle, @IsPublished)";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@WidgetTitle", WidgetTitle);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// edit
        /// </summary>
        /// <param name="WidgetID"></param>
        /// <param name="WidgetTitle"></param>
        /// <param name="IsPublished"></param>
        public void Update(int WidgetID, string WidgetTitle, bool IsPublished)
        {
            string query = "UPDATE Widget SET WidgetTitle = @WidgetTitle, IsPublished = @IsPublished WHERE WidgetID = @WidgetID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@WidgetID", WidgetID);
            cmd.Parameters.AddWithValue("@WidgetTitle", WidgetTitle);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="WidgetID"></param>
        public void DeleteWidget(int WidgetID)
        {
                string query = "DELETE FROM Widget WHERE WidgetID = @WidgetID";
                var connection = new SqlConnection(Global.MyConn);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@WidgetID", WidgetID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
        }

        public DataTable GetWidgets()
        {
            string Query = "SELECT * FROM Widget";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// check if data is available
        /// </summary>
        /// <param name="WidgetID"></param>
        public void GetWidget(int WidgetID)
        {
            string Query = "SELECT * FROM Widget WHERE WidgetID = @WidgetID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@WidgetID", WidgetID);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                WidgetID = int.Parse(reader["WidgetID"].ToString());
                WidgetTitle = reader["WidgetTitle"].ToString();
                IsPublished = bool.Parse(reader["IsPublished"].ToString());
            }
            connection.Close();
        }

    }
}