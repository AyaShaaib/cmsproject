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

namespace Annex.UserControl.Template.Languages
{
    public partial class ListLanguage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LanguageController dc = new LanguageController();
            rptLanguages.DataSource = dc.GetLanguages();
            rptLanguages.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int LanguageID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Language/EditLanguage.aspx?ID=" + LanguageID);
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int LanguageID = int.Parse(btn.CommandArgument);
            LanguageController dc = new LanguageController();
            dc.DeleteLanguage(LanguageID);
            rptLanguages.DataSource = dc.GetLanguages();
            rptLanguages.DataBind();
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddLanguage.aspx");
        }
    }
}