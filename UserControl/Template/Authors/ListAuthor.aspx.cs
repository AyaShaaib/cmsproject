using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Annex.App_Code;

namespace Annex.UserControl.Template.Author
{
    public partial class ListAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthorController ac = new AuthorController();
            rptAuthors.DataSource = ac.GetAuthors();
            rptAuthors.DataBind();

        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int AuthorID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Authors/EditAuthor.aspx?ID=" + AuthorID);
        }


        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int AuthorID = int.Parse(btn.CommandArgument);
            AuthorController ac = new AuthorController();
            ac.DeleteAuthor(AuthorID);
            rptAuthors.DataSource = ac.GetAuthors();
            rptAuthors.DataBind();
        }
        
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddAuthor.aspx");
        }
    }

}    

