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
   

    public class LanguageController
    {
        private int _LanguageID;
        private string _LanguageTitle;
        private string _LanguageSuffix;
        private bool _DefaultLanguage;

        public int LanguageID { get { return _LanguageID; } set { _LanguageID = value; } }
        public string LanguageTitle { get { return _LanguageTitle; } set { _LanguageTitle = value; } }
        public string LanguageSuffix { get { return _LanguageSuffix; } set { _LanguageSuffix = value; } }
        public bool DefaultLanguage { get { return _DefaultLanguage; } set { _DefaultLanguage = value; } }

        /// <summary>
        /// add language
        /// </summary>
        /// <param name="LanguageTitle">Required</param>
        /// <param name="LanguageSuffix">Required</param>
        /// <param name="DefaultLanguage">Required</param>
        public void Insert(string LanguageTitle, string LanguageSuffix, bool DefaultLanguage)
        {
            if (DefaultLanguage)
            {
                ResetDefaultLanguages();
            }
            string query = "INSERT INTO Language (LanguageTitle, LanguageSuffix, DefaultLanguage) " + "VALUES(@LanguageTitle, @LanguageSuffix, @DefaultLanguage)";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LanguageTitle", LanguageTitle);
            cmd.Parameters.AddWithValue("@LanguageSuffix", LanguageSuffix);
            cmd.Parameters.AddWithValue("@DefaultLanguage", DefaultLanguage);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        /// <summary>
        /// edit lang
        /// </summary>
        /// <param name="LanguageID"></param>
        /// <param name="LanguageTitle"></param>
        /// <param name="LanguageSuffix"></param>
        /// <param name="DefaultLanguage"></param>
        public void Update(int LanguageID, string LanguageTitle, string LanguageSuffix, bool DefaultLanguage)
        {
            if (DefaultLanguage)
            {
                ResetDefaultLanguages();
            }
            string query = "UPDATE Language SET LanguageTitle = @LanguageTitle, LanguageSuffix = @LanguageSuffix, DefaultLanguage = @DefaultLanguage WHERE LanguageID = @LanguageID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.Parameters.AddWithValue("@LanguageTitle", LanguageTitle);
            cmd.Parameters.AddWithValue("@LanguageSuffix", LanguageSuffix);
            cmd.Parameters.AddWithValue("@DefaultLanguage", DefaultLanguage);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// delete lang
        /// </summary>
        /// <param name="LanguageID"></param>
        public void DeleteLanguage(int LanguageID)
        {
            if (IsDefaultLanguage(LanguageID))
            {
                ResetDefaultLanguages();
            }
            else
            {
                string query = "DELETE FROM Language WHERE LanguageID = @LanguageID";
                var connection = new SqlConnection(Global.MyConn);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        /// <summary>
        /// reset
        /// </summary>
        public void ResetDefaultLanguages()
        {
            string query = "UPDATE Language SET DefaultLanguage = 'false'";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void MakeDefault(int LanguageID)
        {
            ResetDefaultLanguages();

        }

        public bool IsDefaultLanguage(int LanguageID)
        {
            return false;
        }

        /// <summary>
        /// get languages
        /// </summary>
        /// <returns></returns>
        public DataTable GetLanguages()
        {
            string Query = "SELECT * FROM Language";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// check if data is available for each language
        /// </summary>
        /// <param name="LanguageID"></param>
        public void GetLanguage(int LanguageID)
        {
            string Query = "SELECT * FROM Language WHERE LanguageID = @LanguageID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(Query, connection);
            Cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            connection.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                LanguageID = int.Parse(reader["LanguageID"].ToString());
                LanguageTitle = reader["LanguageTitle"].ToString();
                LanguageSuffix = reader["LanguageSuffix"].ToString();
                DefaultLanguage = bool.Parse(reader["DefaultLanguage"].ToString());
            }
            connection.Close();
        }

        public DataTable GetDefaultLanguage()
        {
            string Query = "SELECT * FROM Language WHERE DefaultLanguage = 'true'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
    }
}