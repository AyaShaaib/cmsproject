using Annex;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Category.App_Code
{
    public class Products
    {
    }
    public class ProductsController
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
        public string SmallDescription { get; set; }
        public string Description { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Depth { get; set; }
        public int AlbumId { get; set; }
        public string Color { get; set; }
        public int SupplierId { get; set; }
        public float OldPrice { get; set; }
        public float NewPrice { get; set; }
        public float Percentage { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductAvailabilityId { get; set; }
        public int LanguageID { get; set; }

        //Insert new product including its related information
        public void Insert(string ProductName,int ProductCategoryId,string SmallDescription,string Description,float Width,float Height,float Depth
            ,int AlbumId,int SupplierId,int BrandId,float OldPrice,float NewPrice,float Percentage
            ,int ProductTypeId,int ProductAvailabilityId,int LanguageID)
        {
            string query = "Insert into [Products](ProductName,ProductCategoryId,SmallDescription,Description,Width,Height,Depth,Image,AlbumId" +
                ",SupplierId,BrandId,OldPrice,NewPrice,Percentage,ProductTypeId,ProductAvailabilityId,LanguageID) values " +
                "(@ProductName,@ProductCategoryId,@SmallDescription,@Description,@Width,@Height,@Depth" +
                ",@AlbumId,@SupplierId,@BrandId,@OldPrice,@NewPrice,@Percentage,@ProductTypeId,@ProductAvailabilityId" +
                ",@LanguageID)";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductName",ProductName);
            cmd.Parameters.AddWithValue("@ProductCategoryId", ProductCategoryId);
            cmd.Parameters.AddWithValue("@SmallDescription",SmallDescription);
            cmd.Parameters.AddWithValue("@Description",Description);
            cmd.Parameters.AddWithValue("@Width",Width);
            cmd.Parameters.AddWithValue("@Height",Height);
            cmd.Parameters.AddWithValue("@Depth",Depth);
            cmd.Parameters.AddWithValue("@AlbumId", AlbumId);
            cmd.Parameters.AddWithValue("@SupplierId",SupplierId);
            cmd.Parameters.AddWithValue("@BrandId",BrandId);
            cmd.Parameters.AddWithValue("@OldPrice",OldPrice);
            cmd.Parameters.AddWithValue("@NewPrice",NewPrice);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@ProductTypeId", ProductTypeId);
            cmd.Parameters.AddWithValue("@ProductAvailabilityId",ProductAvailabilityId);
            cmd.Parameters.AddWithValue("@LanguageID",LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //update a Product record holding specific id 
        public void Update(int ProductId, string ProductName, int ProductCategoryId, string SmallDescription, string Description, float Width, 
            float Height, float Depth ,  int AlbumId,int BrandId, int SupplierId,float OldPrice,float NewPrice
            ,float Percentage,int ProductTypeId,int ProductAvailabilityId,int LanguageID)
        {
            string query = "Update [Products] set ProductName=@ProductName,ProductCategoryId=@ProductCategoryId,SmallDescription=@SmallDescription" +
                ",Description=@Description,Width=@Width,Height=@Height,Depth=@Depth,AlbumId=@AlbumId" +
                ",SupplierId=@SupplierId,BrandId=@BrandId,@OldPrice=OldPrice,NewPrice=@NewPrice,Percentage=@Percentage,ProductTypeId=@ProductTypeId" +
                ",ProductAvailabilityId=@ProductAvailabilityId,LanguageID=@LanguageID where ProductId=@ProductId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@ProductCategoryId", ProductCategoryId);
            cmd.Parameters.AddWithValue("@SmallDescription", SmallDescription);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Width", Width);
            cmd.Parameters.AddWithValue("@Height", Height);
            cmd.Parameters.AddWithValue("@Depth", Depth);
            cmd.Parameters.AddWithValue("@AlbumId", AlbumId);
            cmd.Parameters.AddWithValue("@SupplierId", SupplierId);
            cmd.Parameters.AddWithValue("@BrandId",BrandId);
            cmd.Parameters.AddWithValue("@OldPrice",OldPrice);
            cmd.Parameters.AddWithValue("@NewPrice", NewPrice);
            cmd.Parameters.AddWithValue("@Percentage", Percentage);
            cmd.Parameters.AddWithValue("@ProductTypeId", ProductTypeId);
            cmd.Parameters.AddWithValue("@ProductAvailabilityId", ProductAvailabilityId);
            cmd.Parameters.AddWithValue("@LanguageID",LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        //delete specific product already created holding specific id
        public void Delete(int ProductId)
        {
            string query = "Delete from [Products] where ProductId=@ProductId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        //get all the products from Products table joined to other tables to display names instead of ids
        public DataTable GetProducts()
        {
            string query = "select * from Products" +
                " left join ProductType on Products.ProductTypeId = ProductType.ProductTypeId " +
                "left join ProductAvailability on Products.ProductAvailabilityId = ProductAvailability.ProductAvaiabilityId " +
                "left join Categories on Products.ProductCategoryId = Categories.CategoryId left join Language on " +
                "Products.LanguageID=Language.LanguageID";
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

        //get a record of product holding specific id
        public void GetProduct(int ProductId)
        {
            SqlDataReader dr = null;
            string query = "Select * from [Products] where ProductId=@ProductId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ProductId",ProductId);
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ProductName = dr["ProductName"].ToString();
                ProductCategoryId = int.Parse(dr["ProductCategoryId"].ToString());
                SmallDescription = dr["SmallDescription"].ToString();
                Description = dr["Description"].ToString();
                Width = float.Parse(dr["Width"].ToString());
                Height = float.Parse(dr["Height"].ToString());
                Depth = float.Parse(dr["Depth"].ToString());
                AlbumId = int.Parse(dr["AlbumId"].ToString());
                OldPrice = float.Parse(dr["OldPrice"].ToString());
                NewPrice = float.Parse(dr["NewPrice"].ToString());
                Percentage = float.Parse(dr["Percentage"].ToString());
                ProductTypeId = int.Parse(dr["ProductTypeId"].ToString());
                ProductAvailabilityId = int.Parse(dr["ProductAvailabilityId"].ToString());
                LanguageID = int.Parse(dr["LanguageID"].ToString());
            }
            connection.Close();
        }

        //get the records from productavailability table 
        public DataTable GetProductAvailability()
        {
            string query = "select * from [ProductAvailability]";
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
    }
}