using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Category.App_Code;

namespace Category
{
    public partial class ListCategory : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CategoryController cc = new CategoryController();
                rptCategories.DataSource = cc.GetCategories();
                rptCategories.DataBind();
            }
        }

        protected void SelectListOfCategories_Click(object sender, EventArgs e)
        {
            
        }

        protected void CategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void IsPublished_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int CategoryId = int.Parse(b.CommandArgument);
            CategoryController cc = new CategoryController();
            cc.Delete(CategoryId);
            rptCategories.DataSource = cc.GetCategories();
            rptCategories.DataBind();
        }
        protected void Edit_Click(object sender,EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            /*Session["ID"] = int.Parse(b.CommandArgument);*/
            int CategoryId = int.Parse(b.CommandArgument);
            Response.Redirect("UpdateCategory.aspx?ID="+CategoryId);
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("InsertCategory.aspx");
        }
    }
}