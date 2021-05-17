using Annex.App_Code;
using Category.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.News
{
    public partial class InsertNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AuthorController ac = new AuthorController();
                ddlAuthorId.DataSource = ac.GetAuthors();
                ddlAuthorId.DataTextField = "AuthorName";
                ddlAuthorId.DataValueField = "AuthorID";
                ddlAuthorId.DataBind();
                ddlAuthorId.Items.Insert(0, new ListItem("Root Author", "0"));
                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                ddlLanguageId.Items.Insert(0, new ListItem("Root Language", "0"));
                SourceController sc = new SourceController();
                ddlSourceId.DataSource = sc.GetSources();
                ddlSourceId.DataTextField = "SourceTitle";
                ddlSourceId.DataValueField = "SourceId";
                ddlSourceId.Items.Insert(0,new ListItem("Root Source","0"));
                Break_News.Checked = true;
            }
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            NewsController nc = new NewsController();
            nc.Insert(NewsTitle.Text, NewsSubtitle.Text, NewsDescription.Value.ToString(),DateTime.Now.ToString(), PublishedDate.Text,
                int.Parse(ddlAuthorId.SelectedValue), int.Parse(ddlSourceId.SelectedValue), Break_News.Checked, Youtube_Url.Text, First_AD.Text, Second_AD.Text,
                Third_AD.Text, Fourth_AD.Text, Fifth_AD.Text,int.Parse(ddlLanguageId.SelectedValue),Sixth_AD.Text);
            Response.Redirect("ListNews.aspx");
        }
    }
}