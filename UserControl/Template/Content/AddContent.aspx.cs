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
using Category.App_Code;

namespace Annex.UserControl.Template.Content
{
    public partial class AddContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                MenuController mc = new MenuController();
                ddlMenuID.DataSource = mc.GetParentMenus();
                ddlMenuID.DataTextField = "Title";
                ddlMenuID.DataValueField = "MenuID";
                ddlMenuID.DataBind();
                ddlMenuID.Items.Insert(0, new ListItem("Root Menus", "0"));

                AlbumController ac = new AlbumController();
                ddlAlbumID.DataSource = ac.GetAlbums();
                ddlAlbumID.DataTextField = "EnglishAlbumName";
                ddlAlbumID.DataValueField = "AlbumID";
                ddlAlbumID.DataBind();
                ddlAlbumID.Items.Insert(0, "Select Albums");

                LanguageController lc = new LanguageController();
                ddlLanguageID.DataSource = lc.GetLanguages();
                ddlLanguageID.DataTextField = "LanguageTitle";
                ddlLanguageID.DataValueField = "LanguageID";
                ddlLanguageID.DataBind();
                ddlLanguageID.Items.Insert(0, "Select Languages");

                CategoryController cc = new CategoryController();
                ddlCategoryID.DataSource = cc.GetParentCategory();
                ddlCategoryID.DataTextField = "CategoryName";
                ddlCategoryID.DataValueField = "CategoryID";
                ddlCategoryID.DataBind();
                ddlCategoryID.Items.Insert(0, new ListItem("Root Category", "0"));

                AuthorController auc = new AuthorController();
                ddlAuthorID.DataSource = auc.GetAuthors();
                ddlAuthorID.DataTextField = "AuthorName";
                ddlAuthorID.DataValueField = "AuthorID";
                ddlAuthorID.DataBind();
                ddlAuthorID.Items.Insert(0, "List Authors");

                chkPublished.Checked = true;
            }
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            if (FileUploadContentImage.HasFile) //ContentImage
            {
                string fileName = FileUploadContentImage.FileName;
                string folderPath = Server.MapPath("~/Files/Images/");
                string storeImage = folderPath + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                FileUploadContentImage.SaveAs(storeImage);

                lblFileUploadContentImage.Text = "Image upload successfully";
                lblFileUploadContentImagePath.Text = HttpContext.Current.Request.Url.Host + storeImage;
                lblFileUploadContentImage.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblFileUploadContentImage.ForeColor = System.Drawing.Color.Red;
                lblFileUploadContentImage.Text = "Please select Image";
            }

            if (FileUploadContentFile.HasFile) //ContentFile
            {
                string fileName = FileUploadContentFile.FileName;
                string folderPath = Server.MapPath("~/Files/Images/");
                string storeImage = folderPath + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                FileUploadContentImage.SaveAs(storeImage);

                lblFileUploadContentFile.Text = "File upload successfully";
                lblFileUploadContentFilePath.Text = HttpContext.Current.Request.Url.Host + storeImage;
                lblFileUploadContentFile.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblFileUploadContentFile.ForeColor = System.Drawing.Color.Red;
                lblFileUploadContentFile.Text = "Please select File";
            }

            if (FileUploadThumbnailContent.HasFile) //Thumbnail
            {
                string fileName = FileUploadThumbnailContent.FileName;
                string folderPath = Server.MapPath("~/Files/Images/");
                string storeImage = folderPath + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                FileUploadThumbnailContent.SaveAs(storeImage);

                lblFileUploadThumbnailContent.Text = "Image upload successfully";
                lblFileUploadThumbnailContentPath.Text = HttpContext.Current.Request.Url.Host + storeImage;
                lblFileUploadThumbnailContent.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblFileUploadThumbnailContent.ForeColor = System.Drawing.Color.Red;
                lblFileUploadThumbnailContent.Text = "Please select Image";
            }
            ContentController ccc = new ContentController();
            ccc.Insert(txtContentTitle.Text, txtContentSubTitle.Text, DateTime.Parse(PublishedDate.Text), chkPublished.Checked,
                int.Parse(ddlLanguageID.SelectedValue), int.Parse(ddlMenuID.SelectedValue), int.Parse(ddlAlbumID.SelectedValue),
                DateTime.Parse(txtStartDateTime.Text), DateTime.Parse(txtEndDateTime.Text), int.Parse(ddlAuthorID.SelectedValue),
                int.Parse(ddlCategoryID.SelectedValue), txtMetaTitle.Text, txtMetaKeyword.Text, MetaDescription.Value,
                lblFileUploadContentImagePath.Text, lblFileUploadContentFilePath.Text, lblFileUploadThumbnailContentPath.Text,
                txtSummary.Text, txtCustomText1.Text, txtCustomText2.Text, txtCustomText3.Text, Description.Value.ToString());
            Response.Redirect("ListContent.aspx");
        }
    }
}