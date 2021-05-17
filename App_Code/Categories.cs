using Annex;
using System.Data;
using System.Data.SqlClient;

namespace Category.App_Code
{
    public class CategoryController
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentId { get; set; }
        public bool IsPublished { get; set; }
        public int OrderNum { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
        public string LanguageID{ get; set; }
       
        //Insert function is used to insert new category including its information in sql
        public void Insert(string CategoryName,int ParentId,bool IsPublished,int OrderNum,string Image,string Icon,int LanguageID) { 
            string query = "INSERT INTO [Categories] VALUES(@CategoryName,@ParentId,@IsPublished,@OrderNum,@Image,@Icon,@LanguageID)";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@ParentId", ParentId);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
            cmd.Parameters.AddWithValue("@Image", Image);
            cmd.Parameters.AddWithValue("@Icon", Icon);
            cmd.Parameters.AddWithValue("@LanguageID",LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();

            
        }

        //Update function is used to update category's information 
        public void Update(int CategoryID,string CategoryName,int ParentId,bool IsPublished,int OrderNum,string Image,string Icon,int LanguageID){
            string query = "UPDATE [Categories] set CategoryName=@CategoryName,ParentId=@ParentId,IsPublished=@IsPublished,OrderNum=@OrderNum," +
                "Image=@Image,Icon=@Icon,LanguageID=@LanguageID where CategoryId=@CategoryID";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@ParentId", ParentId);
            cmd.Parameters.AddWithValue("@IsPublished", IsPublished);
            cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
            cmd.Parameters.AddWithValue("@Image", Image);
            cmd.Parameters.AddWithValue("@Icon",Icon);
            cmd.Parameters.AddWithValue("@LanguageID",LanguageID);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        //Delete function is used to delete record form category table holding specific id
        public void Delete(int CategoryId) {
            string query = "Delete from [Categories] where CategoryId=@CategoryId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //GetCategories function is user to return all the records from category table joined to other tables to display names instead of ids
        public DataTable GetCategories() {
            string query = "select * from [Categories]  left join Language on Categories.LanguageID=Language.LanguageID";
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

        //GetParentCategory is used to get the category's records holding id=0
        public DataTable GetParentCategory()
        {
            string query = "select * from [Categories] where ParentId = 0";
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

        //GetCategory function used to get one category holding a specific id
        public void GetCategory(int CategoryID)
        {
            SqlDataReader dr = null;
            string query = "select * from [Categories] where CategoryId=@CategoryId";
            var connection = new SqlConnection(Global.MyConn);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CategoryName = dr["CategoryName"].ToString();
                ParentId = int.Parse(dr["ParentId"].ToString());
                IsPublished = bool.Parse(dr["IsPublished"].ToString());
                OrderNum = int.Parse(dr["OrderNum"].ToString());
                Image = dr["Image"].ToString();
                Icon = dr["Icon"].ToString();
                LanguageID = dr["LanguageID"].ToString();
            }
            connection.Close();
        }
       
    }
}