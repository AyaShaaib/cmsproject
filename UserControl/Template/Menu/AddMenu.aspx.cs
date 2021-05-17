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

namespace Annex.UserControl.Template.Menu
{
    public partial class AddMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LanguageController lc = new LanguageController();
                ddlLanguageID.DataSource = lc.GetLanguages();
                ddlLanguageID.DataTextField = "LanguageTitle";
                ddlLanguageID.DataValueField = "LanguageID";
                ddlLanguageID.DataBind();
                ddlLanguageID.Items.Insert(0, new ListItem("Root Language", "0"));

                DirectionController dc = new DirectionController();
                ddlDirectionID.DataSource = dc.GetDirections();
                ddlDirectionID.DataTextField = "DirectionTitle";
                ddlDirectionID.DataValueField = "DirectionID";
                ddlDirectionID.DataBind();
                ddlDirectionID.Items.Insert(0, new ListItem("Root Direction", "0"));

                MenuController cc = new MenuController();
                ddlParentID.DataSource = cc.GetParentMenus();
                ddlParentID.DataTextField = "Title";
                ddlParentID.DataValueField = "MenuID";
                ddlParentID.DataBind();
                ddlParentID.Items.Insert(0, new ListItem("Root Menu", "0"));
                int num = 0;
                chkPublished.Checked = true;
                txtMenuOrder.Text = num.ToString();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (FileUploadMenuPicture.HasFile)
            {
                string fileName = FileUploadMenuPicture.FileName;
                string folderPath = Server.MapPath("~/Files/Images/");
                string image = "/Files/Images/" + fileName;
                string storeImage = folderPath + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                FileUploadMenuPicture.SaveAs(storeImage);

                lblFileUploadMenuPicture.Text = "Image upload successfully";
                lblFileUploadMenuPicturePath.Text = Request.UrlReferrer + image;
                lblFileUploadMenuPicture.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblFileUploadMenuPicture.ForeColor = System.Drawing.Color.Red;
                lblFileUploadMenuPicture.Text = "Please select Image";
            }

            MenuController ac = new MenuController();
            ac.Insert(txtMenuTitle.Text, lblFileUploadMenuPicturePath.Text, int.Parse(ddlLanguageID.SelectedValue), int.Parse(ddlDirectionID.SelectedValue), int.Parse(ddlParentID.SelectedValue),
                chkPublished.Checked, int.Parse(txtMenuOrder.Text), txtMetaTitle.Text, txtMetaKeyword.Text, MetaDescription.Value.ToString());
            Response.Redirect("ListMenu.aspx");
        }
    }
}