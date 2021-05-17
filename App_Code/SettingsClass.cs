using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{
    public class SettingsClass
    {
		//public string SenderEmail { get; set; }
		//public string RecieverEmail { get; set; }
		//public string FacebookLink { get; set; }
		//public string TwitterLink { get; set; }
		//public string InstagramLink { get; set; }
		//public string YoutubeLink { get; set; }
		//public string Smtp { get; set; }
		//public string SenderPassword { get; set; }
		public void AddSettings(string Facebook, string Insta, string Twitter, string Youtube, string SenderEm, string SenderPa, string RecieverEm, string smtpport)
		{
            SqlConnection con = new SqlConnection(Global.MyConn);
            SqlCommand command = new SqlCommand("Proc_AddSettings", con);
            //string ins = "Insert into[users](name,email,password,phone)values('"+reg_name.Text+"','"+reg_email.Text+"','"+reg_password.Text+"','"+reg_phone.Text+"')";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            command.Parameters.AddWithValue("@SenderEmail", SenderEm);
            command.Parameters.AddWithValue("@SenderPassword", SenderPa);
            command.Parameters.AddWithValue("@RecieverEmail", RecieverEm);
            command.Parameters.AddWithValue("@FacebookLink", Facebook);
            command.Parameters.AddWithValue("@InstagramLink",Insta);
            command.Parameters.AddWithValue("@TwitterLink", Twitter);
            command.Parameters.AddWithValue("@YoutubeLink", Youtube);
            command.Parameters.AddWithValue("@Smtp", smtpport);
            command.Parameters.Add("@responsemessage", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            //SqlDataReader rd = com.ExecuteReader();
            //con.Open();
            //command.ExecuteNonQuery();
            con.Close();
        }
	}
}