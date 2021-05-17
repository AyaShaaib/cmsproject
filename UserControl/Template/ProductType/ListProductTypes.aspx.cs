using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.ProductType
{
    public partial class ListProductTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductTypeController pt = new ProductTypeController();
                rptProductType.DataSource = pt.GetProductTypes();
                rptProductType.DataBind();

            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int ProductTypeId = int.Parse(b.CommandArgument);
            ProductTypeController pt = new ProductTypeController();
            pt.Delete(ProductTypeId);
            rptProductType.DataSource = pt.GetProductTypes();
            rptProductType.DataBind();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int ProductTypeId = int.Parse(b.CommandArgument);
            Response.Redirect("EditProductType.aspx?ID=" + ProductTypeId);
        }
        protected void Insert_Redirect(object sender,EventArgs e)
        {
            Response.Redirect("AddProductType.aspx");
        }
        }
    }