using Annex;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Category.App_Code
{
    public class News
    {
    }
    public class NewsController
    {
        public int NewsId{get;set;}
        public string NewsTitle { get; set; }
        public string NewsSubtitle { get; set; }
        public string NewsDescription { get; set; }
        public string Creation_Date { get; set; }
        public string Published_Date { get; set; }
        public int Author_Id { get; set; }
        public int Source { get; set; }
        public bool Break_News { get; set; }
        public string Youtube_Url { get; set; }
        public string First_AD { get; set; }
        public string Second_AD { get; set; }
        public string Third_AD { get; set; }
        public string Fourth_AD { get; set; }
        public string Fifth_AD { get; set; }
        public string Sixth_AD { get; set; }
        public int LanguageID { get; set; }

        //Insert new News including its related information
        public void Insert(string NewsTitle,string NewsSubtitle,string NewsDescription,string Creation_Date,string Published_Date,
            int Author_Id,int Source,bool Break_News,string Youtube_Url,string First_AD,string Second_AD,string Third_AD,string Fourth_AD,
            string Fifth_AD,int LanguageID,string Sixth_AD)
        {
            string query = "INSERT INTO [News] values (@NewsTitle,@NewsSubtitle,@NewsDescription,@Creation_Date,@Published_Date,@Author_Id," +
                "@Source,@Break_News,@Youtube_Url,@First_AD,@Second_AD,@Third_AD,@Fourth_AD,@Fifth_AD,@LanguageID,@Sixth_AD)";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NewsTitle", NewsTitle);
            cmd.Parameters.AddWithValue("@NewsSubtitle", NewsSubtitle);
            cmd.Parameters.AddWithValue("@NewsDescription", NewsDescription);
            cmd.Parameters.AddWithValue("@Creation_Date", Creation_Date);
            cmd.Parameters.AddWithValue("@Published_Date",Published_Date);
            cmd.Parameters.AddWithValue("@Author_ID", Author_Id);
            cmd.Parameters.AddWithValue("@Source", Source);
            cmd.Parameters.AddWithValue("@Break_News",Break_News);
            cmd.Parameters.AddWithValue("@Youtube_Url",Youtube_Url);
            cmd.Parameters.AddWithValue("@First_AD",First_AD);
            cmd.Parameters.AddWithValue("@Second_AD", Second_AD);
            cmd.Parameters.AddWithValue("@Third_AD", Third_AD);
            cmd.Parameters.AddWithValue("@Fourth_AD", Fourth_AD);
            cmd.Parameters.AddWithValue("@Fifth_AD", Fifth_AD);
            cmd.Parameters.AddWithValue("@LanguageID",LanguageID);
            cmd.Parameters.AddWithValue("@Sixth_AD",Sixth_AD);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        //update a News record holding a specific id
        public void Update(int NewsId,string NewsTitle, string NewsSubtitle, string NewsDescription, string Published_Date,
            int Author_Id, int Source, bool Break_News, string Youtube_Url, string First_AD, string Second_AD, string Third_AD, string Fourth_AD,
            string Fifth_AD,int LanguageID,string Sixth_AD)
        {
            string query = "Update [News] set NewsTitle=@NewsTitle,NewsSubtitle=@NewsSubtitle,NewsDescription=@NewsDescription" +
                ",Published_date=@Published_Date,Author_Id=@Author_Id,Source=@Source,Break_News=@Break_News,Youtube_Url=@Youtube_Url" +
                ",First_AD=@First_AD,Second_AD=@Second_AD,Third_Ad=@Third_AD,Fourth_Ad=@Fourth_AD,Fifth_AD=Fifth_Ad,LanguageID=@LanguageID,Sixth_AD" +
                "=@Sixth_AD where NewsId=@NewId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NewId", NewsId);
            cmd.Parameters.AddWithValue("@NewsTitle", NewsTitle);
            cmd.Parameters.AddWithValue("@NewsSubtitle", NewsSubtitle);
            cmd.Parameters.AddWithValue("@NewsDescription", NewsDescription);
            cmd.Parameters.AddWithValue("@Published_Date", Published_Date);
            cmd.Parameters.AddWithValue("@Author_ID", Author_Id);
            cmd.Parameters.AddWithValue("@Source", Source);
            cmd.Parameters.AddWithValue("@Break_News", Break_News);
            cmd.Parameters.AddWithValue("@Youtube_Url", Youtube_Url);
            cmd.Parameters.AddWithValue("@First_AD", First_AD);
            cmd.Parameters.AddWithValue("@Second_AD", Second_AD);
            cmd.Parameters.AddWithValue("@Third_AD", Third_AD);
            cmd.Parameters.AddWithValue("@Fourth_AD", Fourth_AD);
            cmd.Parameters.AddWithValue("@Fifth_AD", Fifth_AD);
            cmd.Parameters.AddWithValue("@LanguageID",LanguageID);
            cmd.Parameters.AddWithValue("@Sixth_AD",Sixth_AD);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //delete a News record holding specific id
        public void Delete(int NewsId)
        {
            string query = "Delete from [News] where NewsId=@NewsId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NewsId",NewsId);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //return all the records from News table joined to other tables to display names instead of ids
        public DataTable GetNews()
        {
            string query = "select * from News left join Author on News.Author_Id=Author.AuthorId left join Source on News.Source =" +
                " Source.SourceId left join Language on News.LanguageID=Language.LanguageID";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //get a specific News holding specific id
        public void GetNew(int NewID)
        {
            SqlDataReader dr = null;
            string query = "Select * from [News] where NewsId=@NewsId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NewsId",NewID);
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NewsTitle = dr["NewsTitle"].ToString();
                NewsSubtitle = dr["NewsSubtitle"].ToString();
                NewsDescription = dr["NewsDescription"].ToString();
                Creation_Date = dr["Creation_Date"].ToString();
                Published_Date = dr["Published_Date"].ToString();
                Author_Id = int.Parse(dr["Author_Id"].ToString());
                Source = int.Parse(dr["Source"].ToString());
                Break_News = bool.Parse(dr["Break_News"].ToString());
                Youtube_Url = dr["Youtube_Url"].ToString();
                First_AD = dr["First_AD"].ToString();
                Second_AD = dr["Second_AD"].ToString();
                Third_AD = dr["Third_AD"].ToString();
                Fourth_AD = dr["Fourth_AD"].ToString();
                Fifth_AD = dr["Fifth_AD"].ToString();
                Sixth_AD = dr["Sixth_AD"].ToString();
            }
            connection.Close();
        }
    }
}