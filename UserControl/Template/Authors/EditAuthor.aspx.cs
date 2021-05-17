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

namespace Annex.UserControl.Template.Author
{
    public partial class EditAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                AuthorController ac = new AuthorController();
                //Check if no paratmeter exist, redirect to list page.           
                Uri myUri = new Uri(Request.Url.ToString());
                string AuthorID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (AuthorID == null)
                {
                    Response.Redirect("/UserControl/Template/Authors/ListAuthor.aspx");
                }
                ac.GetAuthor(int.Parse(AuthorID));
                txtAuthorName.Text = ac.AuthorName;
                txtAuthorJobTitle.Text = ac.AuthorJobTitle;
                txtAuthorAddress.Text = ac.AuthorAddress;
                txtAuthorEmail.Text = ac.AuthorEmail;
                txtAuthorWebsite.Text = ac.AuthorWebsite;
                lblFileUploadAuthorPicturePath.Text = ac.AuthorPicture;
                txtAuthorLinkedIn.Text = ac.AuthorLinkedIn;
                txtAuthorFacebook.Text = ac.AuthorFacebook;
                txtAuthorTwitter.Text = ac.AuthorTwitter;
                txtAuthorInstagram.Text = ac.AuthorInstagram;
                ddlLanguageId.SelectedValue = ac.LanguageID.ToString();

                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                ddlLanguageId.Items.Insert(0, new ListItem("Select Language", "0"));
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {

            if (FileUploadAuthorPicture.HasFile)
            {
                string fileName = FileUploadAuthorPicture.FileName;
                string folderPath = Server.MapPath("/Files/Images/");
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
            Uri myUri = new Uri(Request.Url.ToString());
            string AuthorID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            AuthorController ac = new AuthorController();
            ac.Update(int.Parse(AuthorID), txtAuthorName.Text, txtAuthorJobTitle.Text, txtAuthorAddress.Text, txtAuthorEmail.Text, txtAuthorWebsite.Text, lblFileUploadAuthorPicturePath.Text, txtAuthorLinkedIn.Text, txtAuthorFacebook.Text, txtAuthorTwitter.Text, txtAuthorInstagram.Text,int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListAuthor.aspx");
        }
    }
}