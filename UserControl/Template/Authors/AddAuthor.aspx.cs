using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Annex.UserControl.Template.Author
{
    public partial class AddAuthor : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                ddlLanguageId.Items.Insert(0, new ListItem("Root Language", "0"));
            }
        }
           
        protected void Submit_Click(object sender, EventArgs e)
        {

        if (FileUploadAuthorPicture.HasFile)
         {
             string fileName = FileUploadAuthorPicture.FileName;
             string folderPath = Server.MapPath("~/Files/Images/");
             string image = "/Files/Images/" + fileName;
             string storeImage = folderPath + fileName;
             if (!Directory.Exists(folderPath))
             {
                 Directory.CreateDirectory(folderPath);
             }
             FileUploadAuthorPicture.SaveAs(storeImage);
             
             lblFileUploadAuthorPicture.Text = "Image upload successfully";
             lblFileUploadAuthorPicturePath.Text = Request.UrlReferrer + image;
             lblFileUploadAuthorPicture.ForeColor = System.Drawing.Color.Green;
             
         }
         else
         {
             lblFileUploadAuthorPicture.ForeColor = System.Drawing.Color.Red;
             lblFileUploadAuthorPicture.Text = "Please select Image";
         }

        AuthorController ac = new AuthorController();
                ac.Insert(txtAuthorName.Text, txtAuthorJobTitle.Text, txtAuthorAddress.Text, txtAuthorEmail.Text, txtAuthorWebsite.Text, lblFileUploadAuthorPicturePath.Text, txtAuthorLinkedIn.Text, txtAuthorFacebook.Text, txtAuthorTwitter.Text, txtAuthorInstagram.Text,int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListAuthor.aspx");
        }
    }
}