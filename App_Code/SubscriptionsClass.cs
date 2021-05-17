using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{
    public class SubscriptionsClass
    {
        public int SubscriptionID { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionType { get; set; }
        /// <summary>
        /// getsubs gets all subscriptions from the database table and fills the data adapter with data table which will be bound to a repeater inside a table
        /// </summary>
        /// <returns></returns>
    public DataTable getsubs()
        {
            string query = "Select * from Subscribe";
            SqlDataAdapter da = new SqlDataAdapter(query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Deletes a certain subscription of a certain user using command argument value
        /// </summary>
        /// <param name="SubscriptionID"></param>
        public void deletesubs(int SubscriptionID)
        {
            string query = "delete from Subscribe Where SubscriptionID=@SubscriptionID";
            var connection = new SqlConnection(Global.MyConn);
            SqlCommand Cmd = new SqlCommand(query, connection);
            connection.Open();
            Cmd.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
    
}