using Annex.App_Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex.UserControl.Template.ProductType
{
    public partial class AddProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LanguageController lc = new LanguageController();
            ddlLanguageId.DataSource = lc.GetLanguages();
            ddlLanguageId.DataTextField = "LanguageTitle";
            ddlLanguageId.DataValueField = "LanguageID";
            ddlLanguageId.DataBind();
            ddlLanguageId.Items.Insert(0, new ListItem("Root Language", "0"));
        }
        protected void Insert_Click(object sender, EventArgs e)
        {
            if (FileUploadProductTypePicture.HasFile)
            {
                string FileName = FileUploadProductTypePicture.FileName;
                string folderPath = Server.MapPath("~/Files/Images/");
                string StoreImage = folderPath + FileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                FileUploadProductTypePicture.SaveAs(StoreImage);
                lblFileUploadProductTypePicture.Text = "Image upload successfully";
                lblFileUploadProductTypePicturePath.Text = Request.UrlReferrer + StoreImage;
                lblFileUploadProductTypePicture.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblFileUploadProductTypePicture.ForeColor = System.Drawing.Color.Red;
                lblFileUploadProductTypePicture.Text = "Please select Image";
            }
            ProductTypeController pc = new ProductTypeController();
            pc.Insert(ProductType.Text, lblFileUploadProductTypePicturePath.Text, int.Parse(ddlLanguageId.SelectedValue));
            Response.Redirect("ListProductTypes.aspx");
        }
    }
}