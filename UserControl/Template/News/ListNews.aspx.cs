using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Category.App_Code;

namespace Category.News
{
    public partial class ListNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NewsController nc = new NewsController();
                rptNews.DataSource = nc.GetNews();
                rptNews.DataBind();
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int NewsId = int.Parse(b.CommandArgument);
            NewsController ns = new NewsController();
            ns.Delete(NewsId);
            rptNews.DataSource = ns.GetNews();
            rptNews.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            /*Session["ID"] = int.Parse(b.CommandArgument);*/
            int NewsId = int.Parse(b.CommandArgument);
            Response.Redirect("UpdateNews.aspx?ID=" + NewsId);
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("InsertNews.aspx");
        }
    }
}