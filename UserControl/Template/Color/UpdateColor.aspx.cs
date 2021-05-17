using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.Color
{
    public partial class UpdateColor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ColorController cc = new ColorController();
                Uri myUri = new Uri(Request.Url.ToString());
                string ColorId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (ColorId == null)
                {
                    Response.Redirect("ListColors.aspx");
                }
                cc.GetColor(int.Parse(ColorId));
                Color.Text = cc.Color;
                if (cc.IsPublished == false)
                {
                    IsPublished.Checked = false;
                }
                else
                {
                    IsPublished.Checked = true;
                }
                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                ddlLanguageId.SelectedValue = cc.LanguageID.ToString();
               
            }
        }
        protected void Edit_Click(object sender,EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string ColorId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            ColorController cc = new ColorController();
            cc.Update(int.Parse(ColorId),Color.Text, IsPublished.Checked,int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListColors.aspx");
        }
    }
}