using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.Source
{
    public partial class EditSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SourceController sc = new SourceController();
            Uri myUri = new Uri(Request.Url.ToString());
            string SourceId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            if (SourceId == null)
            {
                Response.Redirect("ListColors.aspx");
            }
            sc.GetSource(int.Parse(SourceId));
            SourceTitle.Text = sc.SourceTitle;
            Source_Url.Text = sc.Source_Url;
            if (sc.IsPublished == false)
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
            ddlLanguageId.SelectedValue = sc.LanguageID.ToString();
           
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string SourceId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            SourceController cc = new SourceController();
            cc.Update(int.Parse(SourceId), SourceTitle.Text,Source_Url.Text, IsPublished.Checked, int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListSources.aspx");
        }
    }
}