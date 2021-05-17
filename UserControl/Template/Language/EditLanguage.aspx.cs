using Annex.App_Code;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Annex.UserControl.Template.Languages
{
    public partial class EditLanguage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!IsPostBack)
            {
                LanguageController lc = new LanguageController();
                Uri myUri = new Uri(Request.Url.ToString());
                string LanguageID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
                if (LanguageID == null)   
                {
                    Response.Redirect("/UserControl/Template/Language/ListLanguage.aspx");
                }
                lc.GetLanguage(int.Parse(LanguageID));
                txtLanguageTitle.Text = lc.LanguageTitle;
                txtLanguageSuffix.Text = lc.LanguageSuffix;
                chkDefault.Checked = lc.DefaultLanguage;
            }
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.ToString());
            string LanguageID = HttpUtility.ParseQueryString(myUri.Query).Get("ID");
            LanguageController lc = new LanguageController();
            lc.Update(int.Parse(LanguageID), txtLanguageTitle.Text, txtLanguageSuffix.Text, chkDefault.Checked);
            Response.Redirect("ListLanguage.aspx");
        }
    }
}