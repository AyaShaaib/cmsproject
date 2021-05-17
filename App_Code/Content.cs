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

    public class ContentController 
    {
        private int _ContentID;
        private string _ContentTitle;
        private string _ContentSubTitle;
        private string _PublishedDate;
        private bool _IsPublished;
        private int _MenuID;
        private int _LanguageID;
        private int _AlbumID;
        private string _StartDateTime;
        private string _EndDateTime;
        private int _AuthorID;
        private int _ContentCategoryID;       
        private string _MetaTitle;
        private string _MetaKeyword;
        private string _MetaDescription;
        private string _UploadContentImage;
        private string _UploadContentFile;
        private string _UploadThumbnailContentImage;
        private string _Summary;
        private string _CustomText1; 
        private string _CustomText2;
        private string _CustomText3;
        private string _Description;


        public int ContentID { get { return _ContentID; } set { _ContentID = value; } }
        public string ContentTitle { get { return _ContentTitle; } set { _ContentTitle = value; } }
        public string ContentSubTitle { get { return _ContentSubTitle; } set { _ContentSubTitle = value; } }
        public string PublishedDate { get { return _PublishedDate; } set { _PublishedDate = value; } }
        public bool IsPublished { get { return _IsPublished; } set { _IsPublished = value; } }
        public int MenuID { get { return _MenuID; } set { _MenuID = value; } }
        public int LanguageID { get { return _LanguageID; } set { _LanguageID = value; } }
        public int AlbumID { get { return _AlbumID; } set { _AlbumID = value; } }
        public string StartDateTime { get { return _StartDateTime; } set { _StartDateTime = value; } }
        public string EndDateTime { get { return _EndDateTime; } set { _EndDateTime = value; } }
        public int ContentCategoryID { get { return _ContentCategoryID; } set { _ContentCategoryID = value; } }
        public int AuthorID { get { return _AuthorID; } set { _AuthorID = value; } }
        public string MetaTitle { get { return _MetaTitle; } set { _MetaTitle = value; } }
        public string MetaKeyword { get { return _MetaKeyword; } set { _MetaKeyword = value; } }
        public string MetaDescription { get { return _MetaDescription; } set { _MetaDescription = value; } }
        public string Summary { get { return _Summary; } set { _Summary = value; } }
        public string CustomText1 { get { return _CustomText1; } set { _CustomText1 = value; } }
        public string CustomText2 { get { return _CustomText2; } set { _CustomText2 = value; } }
        public string CustomText3 { get { return _CustomText3; } set { _CustomText3 = value; } }
        public string UploadContentImage { get { return _UploadContentImage; } set { _UploadContentImage = value; } }
        public string UploadContentFile { get { return _UploadContentFile; } set { _UploadContentFile = value; } }
        public string UploadThumbnailContentImage { get { return _UploadThumbnailContentImage; } set { _UploadThumbnailContentImage  = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }


        /// <summary>
        /// Add Content
        /// </summary>
        /// <param name="ContentTitle">Required</param>
        /// <param name="ContentSubTitle">Required</param>
        /// <param name="PublishedDate">Required</param>
        /// <param name="IsPublished"></param>
        /// <param name="LanguageID">Required</param>
        /// <param name="MenuID">Required</param>
        /// <param name="AlbumID">Required</param>
        /// <param name="StartDateTime">Required</param>
        /// <param name="EndDateTime">Required</param>
        /// <param name="AuthorID">Required</param>
        /// <param name="ContentCategoryID">Required</param>
        /// <param name="MetaTitle">Required</param>
        /// <param name="MetaKeyword">Required</param>
        /// <param name="MetaDescription">Required</param>
        /// <param name="UploadContentImage">Required</param>
        /// <param name="UploadContentFile">Required</param>
        /// <param name="UploadThumbnailContentImage">Required</param>
        /// <param name="Summary">Required</param>
        /// <param name="CustomText1">Required</param>
        /// <param name="CustomText2">Required</param>
        /// <param name="CustomText3">Required</param>
        /// <param name="Description">Required</param>
        public void Insert (string ContentTitle, string ContentSubTitle, DateTime PublishedDate, bool IsPublished, int LanguageID, 
            int MenuID, int AlbumID, DateTime StartDateTime, DateTime EndDateTime, int AuthorID, int ContentCategoryID,
            string MetaTitle, string MetaKeyword, string MetaDescription, string UploadContentImage,
            string UploadContentFile, string UploadThumbnailContentImage, string Summary,  string CustomText1,
            string CustomText2, string CustomText3, string Description)
        {
            string query = "INSERT INTO Content (ContentTitle, ContentSubTitle, PublishedDate, IsPublished, MenuID,"
                + "LanguageID, AlbumID, StartDateTime, EndDateTime, AuthorID, ContentCategoryID, MetaTitle,MetaKeyword, MetaDescription,"
                + "UploadContentImage, UploadContentFile, UploadThumbnailContentImage, Summary,"
                + "CustomText1, CustomText2, CustomText3, Description) VALUES (@ContentTitle, @ContentSubTitle, @PublishedDate,"
                + "@IsPublished, @LanguageID, @MenuID, @AlbumID, @StartDateTime, @EndDateTime, @AuthorID, @ContentCategoryID, @MetaTitle,"
                + "@MetaKeyword, @MetaDescription, @UploadContentImage, @UploadContentFile, @UploadThumbnailContentImage,"
                +"@Summary, @CustomText1, @CustomText2, @CustomText3, @Description)";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ContentTitle", ContentTitle);
            cmd.Parameters.AddWithValue("@ContentSubTitle", ContentSubTitle);
            cmd.Parameters.AddWithValue("@PublishedDate", PublishedDate);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            cmd.Parameters.AddWithValue("@MenuID", MenuID);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.Parameters.AddWithValue("@AlbumID", AlbumID);
            cmd.Parameters.AddWithValue("@StartDateTime", StartDateTime);
            cmd.Parameters.AddWithValue("@EndDateTime", EndDateTime);
            cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
            cmd.Parameters.AddWithValue("@ContentCategoryID", ContentCategoryID);            
            cmd.Parameters.AddWithValue("@MetaTitle", MetaTitle);
            cmd.Parameters.AddWithValue("@MetaKeyword", MetaKeyword);
            cmd.Parameters.AddWithValue("@MetaDescription", MetaDescription);
            cmd.Parameters.AddWithValue("@UploadContentImage", UploadContentImage);
            cmd.Parameters.AddWithValue("@UploadContentFile", UploadContentFile);
            cmd.Parameters.AddWithValue("@UploadThumbnailContentImage", UploadThumbnailContentImage);
            cmd.Parameters.AddWithValue("@Summary", Summary);
            cmd.Parameters.AddWithValue("@CustomText1", CustomText1);
            cmd.Parameters.AddWithValue("@CustomText2", CustomText2);
            cmd.Parameters.AddWithValue("@CustomText3", CustomText3);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Update content
        /// </summary>
        /// <param name="ContentID"></param>
        /// <param name="ContentTitle"></param>
        /// <param name="ContentSubTitle"></param>
        /// <param name="PublishedDate"></param>
        /// <param name="IsPublished"></param>
        /// <param name="LanguageID"></param>
        /// <param name="MenuID"></param>
        /// <param name="AlbumID"></param>
        /// <param name="StartDateTime"></param>
        /// <param name="EndDateTime"></param>
        /// <param name="AuthorID"></param>
        /// <param name="ContentCategoryID"></param>
        /// <param name="MetaTitle"></param>
        /// <param name="MetaKeyword"></param>
        /// <param name="MetaDescription"></param>
        /// <param name="UploadContentImage"></param>
        /// <param name="UploadContentFile"></param>
        /// <param name="UploadThumbnailContentImage"></param>
        /// <param name="Summary"></param>
        /// <param name="CustomText1"></param>
        /// <param name="CustomText2"></param>
        /// <param name="CustomText3"></param>
        /// <param name="Description"></param>
        public void Update(int ContentID, string ContentTitle, string ContentSubTitle, DateTime PublishedDate, bool IsPublished,
            int LanguageID, int MenuID, int AlbumID, DateTime StartDateTime, DateTime EndDateTime, int AuthorID, int ContentCategoryID,
            string MetaTitle, string MetaKeyword, string MetaDescription, string UploadContentImage,
            string UploadContentFile, string UploadThumbnailContentImage, string Summary, string CustomText1,
            string CustomText2, string CustomText3, string Description) 
        {
            string query = "UPDATE Content  SET " +
                "ContentTitle = @ContentTitle," +
                " ContentSubTitle = @ContentSubTitle,"
                 + " PublishedDate = @PublishedDate," +
                 " IsPublished = @IsPublished," +
                 " MenuID = @MenuID," +
                 " LanguageID = @LanguageID," +
                 " AlbumID = @AlbumID,"
                 + " StartDateTime = @StartDateTime," +
                 " EndDateTime = @EndDateTime," +
                 " AuthorID = @AuthorID,"
                 + " ContentCategoryID = @ContentCategoryID,  MetaTitle = @MetaTitle, MetaKeyword = @MetaKeyword,"
                 + " MetaDescription = @MetaDescription, UploadContentImage = @UploadContentImage, UploadContentFile = @UploadContentFile,"
                 + " UploadThumbnailContentImage = @UploadThumbnailContentImage, Summary = @Summary, CustomText1 = @CustomText1,"
                 + " CustomText2 = @CustomText2, CustomText3 = @CustomText3, Description = @Description WHERE ContentID = @ContentID";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ContentID", ContentID);
            cmd.Parameters.AddWithValue("@ContentTitle", ContentTitle);
            cmd.Parameters.AddWithValue("@ContentSubTitle", ContentSubTitle);
            cmd.Parameters.AddWithValue("@PublishedDate", PublishedDate);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            cmd.Parameters.AddWithValue("@MenuID", MenuID);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.Parameters.AddWithValue("@AlbumID", AlbumID);
            cmd.Parameters.AddWithValue("@StartDateTime", StartDateTime);
            cmd.Parameters.AddWithValue("@EndDateTime", EndDateTime);
            cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
            cmd.Parameters.AddWithValue("@ContentCategoryID", ContentCategoryID);           
            cmd.Parameters.AddWithValue("@MetaTitle", MetaTitle);
            cmd.Parameters.AddWithValue("@MetaKeyword", MetaKeyword);
            cmd.Parameters.AddWithValue("@MetaDescription", MetaDescription);
            cmd.Parameters.AddWithValue("@UploadContentImage", UploadContentImage);
            cmd.Parameters.AddWithValue("@UploadContentFile", UploadContentFile);
            cmd.Parameters.AddWithValue("@UploadThumbnailContentImage", UploadThumbnailContentImage);
            cmd.Parameters.AddWithValue("@Summary", Summary);
            cmd.Parameters.AddWithValue("@CustomText1", CustomText1);
            cmd.Parameters.AddWithValue("@CustomText2", CustomText2);
            cmd.Parameters.AddWithValue("@CustomText3", CustomText3);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        /// <summary>
        /// delete content
        /// </summary>
        /// <param name="ContentID"></param>
        public void DeleteContent(int ContentID)
        {
                string query = "DELETE FROM Content WHERE ContentID = @ContentID";
                var connection = new SqlConnection(Global.MyConn);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ContentID", ContentID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
        }

        /// <summary>
        ///get data form database
        /// </summary>
        /// <returns></returns>
        public DataTable GetContents()
        {
            string query = "SELECT * FROM [Content]";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            /**string Query = "SELECT * FROM Content";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;**/

        }

        /// <summary>
        /// check data availability
        /// </summary>
        /// <param name="ContentID"></param>
        public void GetContent(int ContentID)
        {
            string Query = "SELECT * FROM Content WHERE ContentID = @ContentID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@ContentID", ContentID);
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                ContentID = int.Parse(reader["ContentID"].ToString());
                ContentTitle = reader["ContentTitle"].ToString();
                ContentSubTitle = reader["ContentSubTitle"].ToString();
                PublishedDate = reader["PublishedDate"].ToString();
                IsPublished = bool.Parse(reader["IsPublished"].ToString());
                MenuID = int.Parse(reader["MenuID"].ToString());
                LanguageID = int.Parse(reader["LanguageID"].ToString());
                AlbumID = int.Parse(reader["AlbumID"].ToString());
                StartDateTime = reader["StartDateTime"].ToString();
                EndDateTime = reader["EndDateTime"].ToString();
                AuthorID = int.Parse(reader["AuthorID"].ToString());
                ContentCategoryID = int.Parse(reader["ContentCategoryID"].ToString());               
                MetaTitle = reader["MetaTitle"].ToString();
                MetaKeyword = reader["MetaKeyword"].ToString();
                MetaDescription = reader["MetaDescription"].ToString();
                UploadContentImage = reader["UploadContentImage"].ToString();
                UploadContentFile = reader["UploadContentFile"].ToString();
                UploadThumbnailContentImage = reader["UploadThumbnailContentImage"].ToString();
                Summary = reader["Summary"].ToString();
                CustomText1 = reader["CustomText1"].ToString();
                CustomText2 = reader["CustomText2"].ToString();
                CustomText3 = reader["CustomText3"].ToString();
                Description = reader["Description"].ToString();
            }
            connection.Close();
        }
    }
}