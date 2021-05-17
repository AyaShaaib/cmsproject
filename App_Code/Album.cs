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
    public class AlbumController
    {
        private int _AlbumID;
        private string _EnglishAlbumName;
        private string _ArabicAlbumName;
        private string _OtherAlbumName;
        private int _AlbumOrder;
        private bool _IsPublished;

        public int AlbumID { get { return _AlbumID; } set { _AlbumID = value; } }
        public string EnglishAlbumName { get { return _EnglishAlbumName; } set { _EnglishAlbumName = value; } }
        public string ArabicAlbumName { get { return _ArabicAlbumName; } set { _ArabicAlbumName = value; } }
        public string OtherAlbumName { get { return _OtherAlbumName; } set { _OtherAlbumName = value; } }
        public int AlbumOrder { get { return _AlbumOrder; } set { _AlbumOrder = value; } }
        public bool IsPublished { get { return _IsPublished; } set { _IsPublished = value; } }

        /// <summary>
        /// Insert Function to add an album to the cms with the following fields
        /// </summary>
        /// <param name="EnglishAlbumName">Required</param>
        /// <param name="ArabicAlbumName">Required</param>
        /// <param name="OtherAlbumName">Required</param>
        /// <param name="AlbumOrder">Required</param>
        /// <param name="IsPublished"></param>
        public void Insert(string EnglishAlbumName, string ArabicAlbumName, string OtherAlbumName, int AlbumOrder, bool IsPublished)
        {
            string query = "INSERT INTO Album (EnglishAlbumName, ArabicAlbumName, OtherAlbumName, AlbumOrder, IsPublished) " + "VALUES(@EnglishAlbumName, @ArabicAlbumName, @OtherAlbumName, @AlbumOrder, @ISPublished)";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@EnglishAlbumName", EnglishAlbumName);
            cmd.Parameters.AddWithValue("@OtherAlbumName", OtherAlbumName);
            cmd.Parameters.AddWithValue("@ArabicAlbumName", ArabicAlbumName);
            cmd.Parameters.AddWithValue("@AlbumOrder", AlbumOrder);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Update function to update fields in an album in the cms 
        /// </summary>
        /// <param name="AlbumID"></param>
        /// <param name="EnglishAlbumName"> Required</param>
        /// <param name="ArabicAlbumName">Required</param>
        /// <param name="OtherAlbumName">Required</param>
        /// <param name="AlbumOrder">Required</param>
        /// <param name="IsPublished"></param>
        public void Update(int AlbumID, string EnglishAlbumName, string ArabicAlbumName, string OtherAlbumName, int AlbumOrder, bool IsPublished)
        {
            string query = "UPDATE Album SET EnglishAlbumName = @EnglishAlbumName, ArabicAlbumName = @ArabicAlbumName, OtherAlbumName = @OtherAlbumName, AlbumOrder = @AlbumOrder, IsPublished = @IsPublished WHERE AlbumID = @AlbumID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AlbumID", AlbumID);
            cmd.Parameters.AddWithValue("@EnglishAlbumName", EnglishAlbumName);
            cmd.Parameters.AddWithValue("@ArabicAlbumName", ArabicAlbumName);
            cmd.Parameters.AddWithValue("@OtherAlbumName", OtherAlbumName);
            cmd.Parameters.AddWithValue("@AlbumOrder", AlbumOrder);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Delete function to delete any album
        /// </summary>
        /// <param name="AlbumID"></param>
        public void DeleteAlbum(int AlbumID)
        {
            string query = "DELETE FROM Album WHERE AlbumID = @AlbumID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AlbumID", AlbumID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// To unpublish an album 
        /// </summary>
        /// <param name="AlbumID"></param>
        public void Unpublish(int AlbumID)
        {
            SqlConnection Con = new SqlConnection("ConnectionString");
            string query = "UPDATE Album SET IsPublished = 'false' WHERE AlbumID = @AlbumID";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        /// <summary>
        /// get published albums where we check published and unpublished album
        /// </summary>
        /// <returns> and it returns all the published albums</returns>
        public DataTable GetPublishedAlbums()
        {
            string Query = "SELECT * FROM Album WHERE IsPublished ='true'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Get All albums
        /// </summary>
        /// <returns></returns>
        public DataTable GetAlbums()
        {
            string Query = "SELECT * FROM Album";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Check album's enitities for the data
        /// </summary>
        /// <param name="AlbumID"></param>
        public void GetAlbum(int AlbumID)
        {
            string Query = "SELECT * FROM Album WHERE AlbumID = @AlbumID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@AlbumID", AlbumID);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                AlbumID = int.Parse(reader["AlbumID"].ToString());
                EnglishAlbumName = reader["EnglishAlbumName"].ToString();
                ArabicAlbumName = reader["ArabicAlbumName"].ToString();
                OtherAlbumName = reader["OtherAlbumName"].ToString();
                AlbumOrder = int.Parse(reader["AlbumOrder"].ToString());
                IsPublished = bool.Parse(reader["IsPublished"].ToString());
            }
            connection.Close();
        }
        //public void GetAlbum(int AlbumID)
        //{
        //    string Query = "SELECT * FROM Album WHERE AlbumID = @ALlbumID";
        //    var connection = new SqlConnection(Global.MyConn);
        //    SqlCommand Cmd = new SqlCommand(Query, connection);
        //    connection.Open();
        //    SqlDataReader reader = Cmd.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        AlbumID = int.Parse(reader["AlbumID"].ToString());
        //        EnglishAlbumName = reader["EnglishAlbumName"].ToString();
        //        ArabicAlbumName = reader["ArabicAlbumName"].ToString();
        //        OtherAlbumName = reader["OtherAlbumName"].ToString();
        //        AlbumOrder = int.Parse(reader["AlbumOrder"].ToString());
        //        IsPublished = bool.Parse(reader["IsPublished"].ToString());
        //    }
        //    connection.Close();
        //}

        //public int GetRootAlbums(int ParentID)
        //{
        //    if (ParentID == 0)
        //        return 0;
        //    else
        //        return 1;
        //}

        //public string GetAlbumsOfAlbum(string EnglishAlbumName, int ParentID)
        //{
        //    if (ParentID == 0)
        //        return (EnglishAlbumName);
        //    return "";
        //}

        //public string GetUnPublishedAlbums(string EnglishAlbumName, bool IsPublished)
        //{
        //    if (IsPublished)
        //        return (EnglishAlbumName);
        //    return "";
        //}
    }

}