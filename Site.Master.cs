using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annex
{
    public partial class Site : System.Web.UI.MasterPage
    {
        ResourceManager rm;
        CultureInfo ci;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Email"] == null)
                {
                    Response.Redirect("~/default.aspx");

                }
            
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //    rm = new ResourceManager("Resources.Resource", System.Reflection.Assembly.Load("App_GlobalResources"));
            //    ci = Thread.CurrentThread.CurrentCulture;
            //    LoadString(ci);
            //    }
            //else
            //{
            //    rm = new ResourceManager("Resources.Resource", System.Reflection.Assembly.Load("App_GlobalResources"));
            //    ci = Thread.CurrentThread.CurrentCulture;
            //    LoadString(ci);
            //}
        }
        //private void LoadString(CultureInfo ci)
        //{
        //    lblmain.InnerText = rm.GetString("Main", ci);
        //    lbldirection.InnerText = rm.GetString("Direction", ci);
        //}

        //protected void Languagesbox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Languagesbox.SelectedValue == "fr-FR")
        //    {
        //        int LanguageId = 2;
        //        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
        //        LoadString(Thread.CurrentThread.CurrentCulture);
        //    }

        //}
    }
}