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
    public partial class UpdateNews : System.Web.UI.Page
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
                

                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                

                SourceController sc = new SourceController();
                ddlSourceId.DataSource = sc.GetSources();
                ddlSourceId.DataTextField = "SourceTitle";
                ddlSourceId.DataValueField = "SourceId";

                NewsController nc = new NewsController();
                ddlAuthorId.SelectedValue = nc.Author_Id.ToString();
                ddlLanguageId.SelectedValue = nc.LanguageID.ToString();
                ddlSourceId.SelectedValue = nc.Source.ToString();

                Uri myUri = new Uri(Request.Url.ToString());
                string NewsId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (NewsId == null)
                {
                    Response.Redirect("ListNews.aspx");
                }
                nc.GetNew(int.Parse(NewsId));
                NewsTitle.Text = nc.NewsTitle;
                NewsSubtitle.Text = nc.NewsSubtitle;
                NewsDescription.Value = nc.NewsDescription;
                PublishedDate.Text = nc.Published_Date;
                First_AD.Text = nc.First_AD;
                Second_AD.Text = nc.Second_AD;
                Third_AD.Text = nc.Third_AD;
                Fourth_AD.Text = nc.Fourth_AD;
                Fifth_AD.Text = nc.Fifth_AD;
                Sixth_AD.Text = nc.Sixth_AD;
                if (nc.Break_News == false)
                {
                    Break_News.Checked = false;
                }
                else
                {
                    Break_News.Checked = true;
                }
                Youtube_Url.Text = nc.Youtube_Url;
            }


        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string NewId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            /*int CategoryId = int.Parse(Session["ID"].ToString());*/
            NewsController nc = new NewsController();
            nc.Update(int.Parse(NewId), NewsTitle.Text, NewsSubtitle.Text, NewsDescription.Value.ToString(),
                PublishedDate.Text, int.Parse(ddlAuthorId.SelectedValue), int.Parse(ddlSourceId.SelectedValue), Break_News.Checked, Youtube_Url.Text, First_AD.Text,
                Second_AD.Text,Third_AD.Text,Fourth_AD.Text, Fifth_AD.Text,int.Parse(ddlLanguageId.SelectedValue),Sixth_AD.Text);
            Response.Redirect("ListNews.aspx");
        }




    }
}