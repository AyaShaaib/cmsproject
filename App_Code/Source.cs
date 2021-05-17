using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{
    public class SourceController
    {
        public int SourceId { get; set; }
        public string SourceTitle { get; set; }
        public string Source_Url { get; set; }
        public bool IsPublished { get; set; }
        public int LanguageID { get; set; }

        public void Insert(string SourceTitle,string Source_Url,bool IsPublished,int LanguageID)
        {
            string query = "Insert into [Source] values (@SourceTitle,@Source_Url,@IsPublished,@LanguageID)";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SourceTitle", SourceTitle);
            cmd.Parameters.AddWithValue("@Source_Url", Source_Url);
            cmd.Parameters.AddWithValue("@IsPublished",IsPublished);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(int SourceId,string SourceTitle,string Source_Url, bool IsPublished, int LanguageID)
        {
            string query = "UPDATE [Source] set SourceTitle=@SourceTitle,Source_Url=@Source_Url,IsPublished=@IsPublished,LanguageID=@LanguageID" +
                " where SourceId=@SourceId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SourceId",SourceId);
            cmd.Parameters.AddWithValue("@SourceTitle",SourceTitle);
            cmd.Parameters.AddWithValue("@Source_Url",Source_Url);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int SourceId)
        {
            string query = "Delete from [Source] where SourceId=@SourceId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SourceId",SourceId);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetSources()
        {
            string query = "select * from [Source] left join Language on Source.LanguageID=Language.LanguageID";
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

        public void GetSource(int SourceId)
        {

            SqlDataReader dr = null;
            string query = "Select * from [Source] where SourceId=@SourceId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SourceId",SourceId);
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SourceTitle = dr["SourceTitle"].ToString();
                Source_Url = dr["Source_Url"].ToString();
                IsPublished = bool.Parse(dr["IsPublished"].ToString());
                LanguageID = int.Parse(dr["LanguageId"].ToString());
            }
            connection.Close();
        }
    }
}