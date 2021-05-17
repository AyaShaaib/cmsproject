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
    public partial class ListMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuController dc = new MenuController();
            rptMenus.DataSource = dc.GetMenus();
            rptMenus.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int MenuID = int.Parse(btn.CommandArgument);
            Response.Redirect("/UserControl/Template/Menu/EditMenu.aspx?ID=" + MenuID);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int MenuID = int.Parse(btn.CommandArgument);
            MenuController dc = new MenuController();
            dc.DeleteMenu(MenuID);
            rptMenus.DataSource = dc.GetMenus();
            rptMenus.DataBind();
        }
        protected void Insert_Redirect(object sender, EventArgs e)
        {
            Response.Redirect("AddMenu.aspx");
        }
    }
}