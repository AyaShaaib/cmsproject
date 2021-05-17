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
    public partial class EditProduct : System.Web.UI.Page
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
                ProductTypeController pt = new ProductTypeController();
                ddlProductType.DataSource = pt.GetProductTypes();
                ddlProductType.DataTextField = "ProductType";
                ddlProductType.DataValueField = "ProductTypeId";
                ddlProductType.DataBind();
                ProductsController pc = new ProductsController();
                ddlProductAvailability.DataSource = pc.GetProductAvailability();
                ddlProductAvailability.DataTextField = "ProductAvailability";
                ddlProductAvailability.DataValueField = "ProductAvaiabilityId";
                ddlProductAvailability.DataBind();

                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();

                ddlCategories.SelectedValue = pc.ProductCategoryId.ToString();
                ddlProductType.SelectedValue = pc.ProductTypeId.ToString();
                ddlProductAvailability.SelectedValue = pc.ProductAvailabilityId.ToString();
                ddlLanguageId.SelectedValue = pc.LanguageID.ToString();

                Uri myUri = new Uri(Request.Url.ToString());
                string ProductId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (ProductId == null)
                {
                    Response.Redirect("InsertProduct.aspx");
                }
                pc.GetProduct(int.Parse(ProductId));
                ProductName.Text = pc.ProductName.ToString();
                SmallDescription.Text = pc.SmallDescription.ToString();
                Description.Value = pc.Description.ToString();
                Width.Text = pc.Width.ToString();
                Height.Text = pc.Height.ToString();
                Depth.Text = pc.Depth.ToString();
                OldPrice.Text = pc.OldPrice.ToString();
                NewPrice.Text = pc.NewPrice.ToString();
                Percentage.Text = pc.Percentage.ToString();
            }
            
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string ProductId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            ProductsController pc = new ProductsController();
            pc.Update(int.Parse(ProductId),ProductName.Text,int.Parse(ddlCategories.SelectedValue),SmallDescription.Text,Description.Value.ToString()
                ,int.Parse(Width.Text),int.Parse(Height.Text),int.Parse(Depth.Text),0,0,0,float.Parse(OldPrice.Text),
                float.Parse(NewPrice.Text),float.Parse(Percentage.Text),int.Parse(ddlProductType.SelectedValue),
                int.Parse(ddlProductAvailability.SelectedValue),int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListProducts.aspx");
        }

        protected void Calculate_Click(Object sender, EventArgs e)
        {
            float percentage;
            if (OldPrice.Text != null && NewPrice != null)
            {
                percentage = (((float.Parse(NewPrice.Text) / float.Parse(OldPrice.Text)) * 100) - 100) * (-1);
                Percentage.Text = percentage.ToString();
            }
        }
    }
}