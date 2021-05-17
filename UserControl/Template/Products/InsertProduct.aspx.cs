using Annex.App_Code;
using Category.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.Products
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CategoryController cc = new CategoryController();
                ddlCategories.DataSource = cc.GetParentCategory();
                ddlCategories.DataTextField = "CategoryName";
                ddlCategories.DataValueField = "CategoryID";
                ddlCategories.DataBind();
                ddlCategories.Items.Insert(0, new ListItem("Root Category", "0"));

                ProductTypeController pt = new ProductTypeController();
                ddlProductType.DataSource = pt.GetProductTypes();
                ddlProductType.DataTextField = "ProductType";
                ddlProductType.DataValueField = "ProductTypeId";
                ddlProductType.DataBind();
                ddlProductType.Items.Insert(0, new ListItem("Root Product Type","0"));

                ProductsController pc = new ProductsController();
                ddlProductAvailability.DataSource = pc.GetProductAvailability();
                ddlProductAvailability.DataTextField = "ProductAvailability";
                ddlProductAvailability.DataValueField = "ProductAvaiabilityId";
                ddlProductAvailability.DataBind();
                ddlProductAvailability.Items.Insert(0,new ListItem("Root Product Availability","0"));

                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                ddlLanguageId.Items.Insert(0, new ListItem("Root Language", "0"));
            }

        }
        protected void Insert_Click(object sender, EventArgs e)
        {
            ProductsController pc = new ProductsController();
            pc.Insert(ProductName.Text, int.Parse(ddlCategories.SelectedValue), SmallDescription.Text, Description.Value, float.Parse(Width.Text)
                , float.Parse(Height.Text), float.Parse(Depth.Text), 0, 0, 0, float.Parse(OldPrice.Text), float.Parse(NewPrice.Text), float.Parse(Percentage.Text)
                , int.Parse(ddlProductType.SelectedValue), int.Parse(ddlProductAvailability.SelectedValue),int.Parse(ddlProductAvailability.SelectedValue));

            Response.Redirect("ListProducts.aspx");
        }

        protected void Calculate_Click(Object sender,EventArgs e)
        {
            float percentage;
            if (OldPrice.Text != null && NewPrice != null)
            {
                percentage = (((float.Parse(NewPrice.Text) / float.Parse(OldPrice.Text)) * 100)-100)*(-1);
                Percentage.Text = percentage.ToString();
            }
        }
        
    }
}