using Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{
    public class ProductType
    {
    }
    public class ProductTypeController
    {
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }
        public string ProductTypePicture { get; set; }
        public int LanguageID { get; set; }

        //Insert a new product type
        public void Insert(string ProductType, string ProductTypePicture, int LanguageID)
        {
            string query = "INSERT INTO [ProductType] values(@ProductType,@ProductTypePicture,@LanguageId)";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductType", ProductType);
            cmd.Parameters.AddWithValue("@ProductTypePicture", ProductTypePicture);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //update a producttype holding specific id
        public void Update(int ProductTypetId, string ProductType, string ProductTypePicture, int LanguageID)
        {
            string query = "UPDATE [ProductType] set ProductType=@ProductType,ProductTypePicture=@ProductTypePicture,LanguageID=@LanguageID";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("ProductTypeId", ProductTypeId);
            cmd.Parameters.AddWithValue("@ProductType", ProductType);
            cmd.Parameters.AddWithValue("@ProductTypePicture", ProductTypePicture);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //delete a producttype holding specific id
        public void Delete(int ProductTypeId)
        {
            string query = "Delete from [ProductType] where ProductTypeId=ProductTypeId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductTypeId", ProductTypeId);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        //get all the records from producttype table
        public DataTable GetProductTypes()
        {
            string query = "select * from [ProductType] left join Language on ProductType.LanguageID=Language.LanguageID";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //get a single record for a product type holding a specific id
        public void GetProductType(int ProductTypeId)
        {

            SqlDataReader dr = null;
            string query = "Select * from [ProductType] where ProductTypeId=@ProductTypeId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductTypeId", ProductTypeId);
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ProductType = dr["ProductType"].ToString();
                ProductTypePicture = dr["ProductTypePicture"].ToString();

            }
            connection.Close();
        }
    }
}