using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.ProductType
{
    public partial class EditProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductTypeController pt = new ProductTypeController();
                Uri myUri = new Uri(Request.Url.ToString());
                string ProductTypeId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (ProductTypeId == null)
                {
                    Response.Redirect("ListProductTypes.aspx");
                }
                pt.GetProductType(int.Parse(ProductTypeId));
                ProductType.Text = pt.ProductType;
                lblFileUploadProductTypePicturePath.Text = pt.ProductTypePicture;
                LanguageController lc = new LanguageController();
                ddlLanguageId.DataSource = lc.GetLanguages();
                ddlLanguageId.DataTextField = "LanguageTitle";
                ddlLanguageId.DataValueField = "LanguageID";
                ddlLanguageId.DataBind();
                ddlLanguageId.SelectedValue = pt.LanguageID.ToString();
               
            }

        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string ProductTypeId = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            ProductTypeController pt = new ProductTypeController();
            pt.Update(int.Parse(ProductTypeId), ProductType.Text, lblFileUploadProductTypePicturePath.Text, int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListProductTypes.aspx");
        }
    }
}