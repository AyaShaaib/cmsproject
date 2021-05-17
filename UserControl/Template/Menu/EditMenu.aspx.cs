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
    public partial class EditMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuController ac = new MenuController();
                //Check if no paratmeter exist, redirect to list page.           
                Uri myUri = new Uri(Request.Url.ToString());
                string MenuID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (MenuID == null)
                {
                    Response.Redirect("/UserControl/Template/Menus/ListMenu.aspx");
                }
                ac.GetMenu(int.Parse(MenuID));
                txtMenuTitle.Text = ac.Title;                
                lblFileUploadMenuPicturePath.Text = ac.Picture;
                ddlLanguageID.SelectedValue = ac.LanguageID.ToString();
                ddlDirectionID.SelectedValue = ac.DirectionID.ToString();
                ddlParentID.DataSource = ac.GetParentMenus();
                ddlParentID.DataTextField = "Title";
                ddlParentID.DataValueField = "MenuID";
                ddlParentID.DataBind();
                ddlParentID.Items.Insert(0, new ListItem("Root Menu", "0"));
                //ddlParentID.SelectedValue = ac.ParentID.ToString();//
                chkPublished.Checked = ac.IsPublished;
                txtMenuOrder.Text = ac.MenuOrder.ToString();
                txtMetaTitle.Text = ac.MetaTitle;
                txtMetaKeyword.Text = ac.MetaKeyword;
                MetaDescription.Value = ac.MetaDescription;

                if (FileUploadMenuPicture.HasFile)
            {
                string FileNameIcon = FileUploadMenuPicture.FileName;
                string folderPathIcon = Server.MapPath("~/Files/Images/");
                /*string Image = "/Files/Images/" + FileName;*/
                string StoreIcon = folderPathIcon + FileNameIcon;
                if (!Directory.Exists(folderPathIcon))
                {
                    Directory.CreateDirectory(folderPathIcon);
                }
                FileUploadMenuPicture.SaveAs(StoreIcon);
                lblFileUploadMenuPicture.Text = "Image upload successfully";
                lblFileUploadMenuPicturePath.Text = Request.UrlReferrer + StoreIcon;
                lblFileUploadMenuPicture.ForeColor = System.Drawing.Color.Green;

            }
            
                LanguageController lc = new LanguageController();
                ddlLanguageID.DataSource = lc.GetLanguages();
                ddlLanguageID.DataTextField = "LanguageTitle";
                ddlLanguageID.DataValueField = "LanguageID";
                ddlLanguageID.DataBind();
                ddlLanguageID.Items.Insert(0, new ListItem("Root Language", "0"));

               /* DirectionController dc = new DirectionController();
                ddlDirectionID.DataSource = dc.GetDirections();
                ddlDirectionID.DataTextField = "DirectionTitle";
                ddlDirectionID.DataValueField = "DirectionID";
                ddlDirectionID.DataBind();
                ddlDirectionID.Items.Insert(0, new ListItem("Root Direction", "0"));*/

            }

        }

        protected void Edit_Click(object sender, EventArgs e)
        {

            Uri myUri = new Uri(Request.Url.ToString());
            string MenuID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");            
            MenuController mc = new MenuController();
            mc.Update(int.Parse(MenuID), txtMenuTitle.Text, lblFileUploadMenuPicturePath.Text, int.Parse(ddlLanguageID.SelectedValue), int.Parse(ddlDirectionID.SelectedValue), int.Parse(ddlParentID.SelectedValue),
                chkPublished.Checked, int.Parse(txtMenuOrder.Text), txtMetaTitle.Text, txtMetaKeyword.Text, MetaDescription.Value.ToString());
            Response.Redirect("ListMenu.aspx");
        }
    }
}