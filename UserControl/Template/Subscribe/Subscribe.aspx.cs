using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Annex.App_Code;

namespace Annex.UserControl.Template.Subscribe
{
    public partial class Subscribe : System.Web.UI.Page
    {
        /// <summary>
        /// On page load the subscriptions by all users will be loaded into a repeater inside a table using getsubs function from subscriptionclass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SubscriptionsClass subscriptionsClass = new SubscriptionsClass();
                subsrepeater.DataSource = subscriptionsClass.getsubs();
                subsrepeater.DataBind();
            }

        }
        /// <summary>
        /// this code deletes the subscription of a user by sending its command argument to deletesubs func in subscriptionclass and updates the table with new data and binds it to the repeater after deleting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnDelete_Click(object sender, EventArgs e)
        {
          
            LinkButton dltbtn = (LinkButton)sender;
            int SubscriptionID = int.Parse(dltbtn.CommandArgument);
            SubscriptionsClass subscriptionsClass = new SubscriptionsClass();
            subscriptionsClass.deletesubs(SubscriptionID);
            subsrepeater.DataSource = subscriptionsClass.getsubs();
            subsrepeater.DataBind();
        }
    }
}