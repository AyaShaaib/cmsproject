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
    public class MenuController
    {
            private int _MenuID;
            private string _Title;
            private string _Picture;
            private int _LanguageID;
            private int _DirectionID;
            private int _ParentID;
            private bool _IsPublished;
            private int _MenuOrder;
            private string _MetaTitle;
            private string _MetaKeyword;
            private string _MetaDescription;
            

            public int MenuID { get { return _MenuID; } set { _MenuID = value; } }
            public string Title { get { return _Title; } set { _Title = value; } }
            public string Picture { get { return _Picture; } set { _Picture = value; } }
            public int LanguageID { get { return _LanguageID; } set { _LanguageID = value; } }
            public int DirectionID { get { return _DirectionID; } set { _DirectionID = value; } }
            public int ParentID { get { return _ParentID; } set { _ParentID = value; } }
            public bool IsPublished { get { return _IsPublished; } set { _IsPublished = value; } }
            public int MenuOrder { get { return _MenuOrder; } set { _MenuOrder = value; } }
            public string MetaTitle { get { return _MetaTitle; } set { _MetaTitle = value; } }
            public string MetaKeyword { get { return _MetaKeyword; } set { _MetaKeyword = value; } }
            public string MetaDescription { get { return _MetaDescription; } set { _MetaDescription = value; } }


        /// <summary>
        /// add menu
        /// </summary>
        /// <param name="Title">Required</param>
        /// <param name="Picture"></param>
        /// <param name="LanguageID">Required</param>
        /// <param name="DirectionID">Required</param>
        /// <param name="ParentID"></param>
        /// <param name="IsPublished"></param>
        /// <param name="MenuOrder">Required</param>
        /// <param name="MetaTitle">Required</param>
        /// <param name="MetaKeyword">Required</param>
        /// <param name="MetaDescription">Required</param>
        public void Insert(string Title, string Picture, int LanguageID, int DirectionID, int ParentID, bool IsPublished, int MenuOrder, string MetaTitle, string MetaKeyword, string MetaDescription) {

            string query = "INSERT INTO Menu (Title, Picture, LanguageID, DirectionID, ParentID, IsPublished, MenuOrder, MetaTitle, MetaKeyword, MetaDescription) "
                + "VALUES (@Title, @Picture, @LanguageID, @DirectionID, @ParentID, @IsPublished, @MenuOrder, @MetaTitle, @MetaKeyword, @MetaDescription)";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            Cmd.Parameters.AddWithValue("@Title", Title);
            Cmd.Parameters.AddWithValue("@Picture", Picture);
            Cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            Cmd.Parameters.AddWithValue("@DirectionID", DirectionID);
            Cmd.Parameters.AddWithValue("@ParentID", ParentID);
            Cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            Cmd.Parameters.AddWithValue("@MenuOrder", MenuOrder);
            Cmd.Parameters.AddWithValue("@MetaTitle", MetaTitle);
            Cmd.Parameters.AddWithValue("@MetaKeyword", MetaKeyword);
            Cmd.Parameters.AddWithValue("@MetaDescription", MetaDescription);
            connection.Open();
            Cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// edit
        /// </summary>
        /// <param name="MenuID"></param>
        /// <param name="Title"></param>
        /// <param name="Picture"></param>
        /// <param name="LanguageID"></param>
        /// <param name="DirectionID"></param>
        /// <param name="ParentID"></param>
        /// <param name="IsPublished"></param>
        /// <param name="MenuOrder"></param>
        /// <param name="MetaTitle"></param>
        /// <param name="MetaKeyword"></param>
        /// <param name="MetaDescription"></param>
        public void Update(int MenuID, string Title, string Picture, int LanguageID, int DirectionID, int ParentID, bool IsPublished, int MenuOrder, string MetaTitle, string MetaKeyword, string MetaDescription)
        {
            string query = "UPDATE Menu SET Title = @Title, Picture = @Picture, LanguageID = @LanguageID,"
                + "DirectionID = @DirectionID, ParentID = @ParentID, IsPublished = @IsPublished, MenuOrder = @MenuOrder,"
                + "MetaTitle = @MetaTitle, MetaKeyword = @MetaKeyword, MetaDescription = @MetaDescription WHERE MenuID = @MenuID ";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            Cmd.Parameters.AddWithValue("@MenuID", MenuID);
            Cmd.Parameters.AddWithValue("@Title", Title);
            Cmd.Parameters.AddWithValue("@Picture", Picture);
            Cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            Cmd.Parameters.AddWithValue("@DirectionID", DirectionID);
            Cmd.Parameters.AddWithValue("@ParentID", ParentID);
            Cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            Cmd.Parameters.AddWithValue("@MenuOrder", MenuOrder);
            Cmd.Parameters.AddWithValue("@MetaTitle", MetaTitle);
            Cmd.Parameters.AddWithValue("@MetaKeyword", MetaKeyword);
            Cmd.Parameters.AddWithValue("@MetaDescription", MetaDescription);
            connection.Open();
            Cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="MenuID"></param>
        public void DeleteMenu(int MenuID)
        {
            string query = "DELETE Menu WHERE MenuID = @MenuID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            Cmd.Parameters.AddWithValue("@MenuID", MenuID);
            connection.Open();
            Cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// publishe unpublished menus
        /// </summary>
        /// <param name="MenuID"></param>
        public void Publish(int MenuID)
        {
            string query = "UPDATE Menu SET IsPublished = 'true' WHERE MenuID = @MenuID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            Cmd.Parameters.AddWithValue("@MenuID", MenuID);
            connection.Open();
            Cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// unpublish published menus
        /// </summary>
        /// <param name="MenuID"></param>
        public void Unpublish(int MenuID)
        {
            string query = "UPDATE Menu SET IsPublished = 'false' WHERE MenuID = @MenuID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            Cmd.Parameters.AddWithValue("@MenuID", MenuID);
            connection.Open();
            Cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// get all menus
        /// </summary>
        /// <returns></returns>
        public DataTable GetMenus()
        {
            string Query = "SELECT * FROM Menu";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// check menus availability
        /// </summary>
        /// <returns></returns>
        public DataTable GetParentMenus()
        {
            string Query = "select * from Menu where ParentID = 0";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            connection.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetPublishedMenus()
        {
            string Query = "SELECT * FROM Menu WHERE IsPublished ='true'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetUnPublishedMenus()
        {
            string Query = "SELECT Title FROM Menu WHERE IsPublished = 'false'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void GetMenu(int MenuID)
        {
            string Query = "SELECT * FROM Menu WHERE MenuID = @MenuID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            Cmd.Parameters.AddWithValue("@MenuID", MenuID);
            connection.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                MenuID = int.Parse(reader["MenuID"].ToString());
                Title = reader["Title"].ToString();
                Picture = reader["Picture"].ToString();
                LanguageID = int.Parse(reader["LanguageID"].ToString());
                DirectionID = int.Parse(reader["DirectionID"].ToString());
                ParentID = int.Parse(reader["ParentID"].ToString());
                IsPublished = bool.Parse(reader["IsPublished"].ToString());
                MenuOrder = int.Parse(reader["MenuOrder"].ToString());
                MetaTitle = reader["MetaTitle"].ToString();
                MetaKeyword = reader["MetaKeyword"].ToString();
                MetaDescription = reader["MetaDescription"].ToString();
            }
            connection.Close();
        }
    }
}