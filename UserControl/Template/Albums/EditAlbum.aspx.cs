using Annex.App_Code;
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


namespace Annex.UserControl.Template.Albums
{
    public partial class EditAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlbumController ac = new AlbumController();
                //Check if no paratmeter exist, redirect to list page.           
                Uri myUri = new Uri(Request.Url.ToString());
                string AlbumID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (AlbumID == null)
                {
                    Response.Redirect("ListAlbum.asspx");
                }
                ac.GetAlbum(int.Parse(AlbumID));
                txtEnglishAlbumName.Text = ac.EnglishAlbumName;
                txtArabicAlbumName.Text = ac.ArabicAlbumName;
                txtOtherAlbumName.Text = ac.OtherAlbumName;
                txtAlbumOrder.Text = ac.AlbumOrder.ToString();
                chkPublished.Checked = ac.IsPublished;
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string AlbumID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            AlbumController ac = new AlbumController();
            ac.Update(int.Parse(AlbumID), txtEnglishAlbumName.Text, txtArabicAlbumName.Text, txtOtherAlbumName.Text, int.Parse(txtAlbumOrder.Text), chkPublished.Checked);
            Response.Redirect("ListAlbum.aspx");
        }

    }
}
