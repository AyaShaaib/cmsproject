using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{
    public class RolesClass
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public bool Enabled { get; set; }
        public DataTable getallroles()
        {
            string query = "Select * from Role";
            SqlDataAdapter da = new SqlDataAdapter(query, Global.MyConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}