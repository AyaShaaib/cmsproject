using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Category.App_Code;

namespace Category.Products
{
    public partial class ListProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {
                ProductsController cc = new ProductsController();
                rptProducts.DataSource = cc.GetProducts();
                rptProducts.DataBind();
                
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int ProductId = int.Parse(b.CommandArgument);
            ProductsController cc = new ProductsController();
            cc.Delete(ProductId);
            rptProducts.DataSource = cc.GetProducts();
            rptProducts.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int ProductId = int.Parse(b.CommandArgument);
            Response.Redirect("EditProduct.aspx?ID=" + ProductId);
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }
    }
}