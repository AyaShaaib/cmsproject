using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Annex.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            RouteTable.Routes.MapPageRoute("Login", "Login", "~/Default.aspx");
            RouteTable.Routes.MapPageRoute("Home", "Home", "~/UserControl/Template/User/home.aspx");

            RouteTable.Routes.MapPageRoute("List Albums", "ListAlbum", "~/UserControl/Template/Albums/ListAlbum.aspx");
            RouteTable.Routes.MapPageRoute("Add Albums", "AddAlbum", "~/UserControl/Template/Albums/AddAlbum.aspx");
            RouteTable.Routes.MapPageRoute("Edit Albums", "EditAlbum/{ID}", "~/UserControl/Template/Albums/EditAlbum.aspx");

            RouteTable.Routes.MapPageRoute("AfterLoginUsingGoogle", "AfterLoginUsingGoogle", "~/UserControl/Template/Authentication/AfterLoginUsingGoogle.aspx");
            RouteTable.Routes.MapPageRoute("FacebookAuthentication", "FacebookAuthentication", "~/UserControl/Template/Authentication/FacebookAuthentication.aspx");
            RouteTable.Routes.MapPageRoute("GoogleAuthentication", "GoogleAuthentication", "~/UserControl/Template/Authentication/GoogleAuthentication.aspx");
            RouteTable.Routes.MapPageRoute("reCaptcha", "reCaptcha", "~/UserControl/Template/Authentication/reCaptcha.aspx");

            RouteTable.Routes.MapPageRoute("List Authors", "ListAuthor", "~/UserControl/Template/Authors/ListAuthor.aspx");
            RouteTable.Routes.MapPageRoute("Add Author", "AddAuthor", "~/UserControl/Template/Authors/AddAuthor.aspx");
            RouteTable.Routes.MapPageRoute("Edit Author", "EditAuthor/{ID}", "~/UserControl/Template/Authors/EditAuthor.aspx");

            RouteTable.Routes.MapPageRoute("List Category", "ListCategory", "~/UserControl/Template/Category/ListCategory.aspx");
            RouteTable.Routes.MapPageRoute("Insert Category", "AddCategory", "~/UserControl/Template/Category/InsertCategory.aspx");
            RouteTable.Routes.MapPageRoute("Update Category", "EditCategory/{ID}", "~/UserControl/Template/Category/UpdateCategory.aspx");

            RouteTable.Routes.MapPageRoute("List Color", "ListColors", "~/UserControl/Template/Color/ListColors.aspx");
            RouteTable.Routes.MapPageRoute("Insert Color", "AddColor", "~/UserControl/Template/Color/InsertColor.aspx");
            RouteTable.Routes.MapPageRoute("Update Color", "EditColor/{ID}", "~/UserControl/Template/Color/UpdateColor.aspx");

            RouteTable.Routes.MapPageRoute("List Content", "ListContent", "~/UserControl/Template/Content/ListContent.aspx");
            RouteTable.Routes.MapPageRoute("Add Content", "AddContent", "~/UserControl/Template/Content/AddContent.aspx");
            RouteTable.Routes.MapPageRoute("Edit Content", "EditContent/{ID}", "~/UserControl/Template/Content/EditContent.aspx");

            RouteTable.Routes.MapPageRoute("List Direction", "ListDirection", "~/UserControl/Template/Directions/ListDirection.aspx");
            RouteTable.Routes.MapPageRoute("Add Direction", "AddDirection", "~/UserControl/Template/Directions/AddDirection.aspx");
            RouteTable.Routes.MapPageRoute("Edit Direction", "EditDirection/{ID}", "~/UserControl/Template/Directions/EditDirection.aspx");

            RouteTable.Routes.MapPageRoute("List Language", "ListLanguage", "~/UserControl/Template/Language/ListLanguage.aspx");
            RouteTable.Routes.MapPageRoute("Add Language", "AddLanguage", "~/UserControl/Template/Language/AddLanguage.aspx");
            RouteTable.Routes.MapPageRoute("Edit Language", "EditLanguage/{ID}", "~/UserControl/Template/Language/EditLanguage.aspx");

            RouteTable.Routes.MapPageRoute("List Menu", "ListMenu", "~/UserControl/Template/Menu/ListMenu.aspx");
            RouteTable.Routes.MapPageRoute("Add Menu", "AddMenu", "~/UserControl/Template/Menu/AddMenu.aspx");
            RouteTable.Routes.MapPageRoute("Edit Menu", "EditMenu/{ID}", "~/UserControl/Template/Menu/EditMenu.aspx");

            RouteTable.Routes.MapPageRoute("List News", "ListNews", "~/UserControl/Template/News/ListNews.aspx");
            RouteTable.Routes.MapPageRoute("Insert News", "AddNews", "~/UserControl/Template/News/InsertNews.aspx");
            RouteTable.Routes.MapPageRoute("Update News", "EditNews/{ID}", "~/UserControl/Template/News/UpdateNews.aspx");

            RouteTable.Routes.MapPageRoute("List Products", "ListProduct", "~/UserControl/Template/Products/ListProduct.aspx");
            RouteTable.Routes.MapPageRoute("Insert Products", "AddProduct", "~/UserControl/Template/Products/InsertProduct.aspx");
            RouteTable.Routes.MapPageRoute("Edit Products", "EditProduct/{ID}", "~/UserControl/Template/Products/EditProduct.aspx");

            RouteTable.Routes.MapPageRoute("List ProductType", "ListProductTypes", "~/UserControl/Template/ProductType/ListProductTypes.aspx");
            RouteTable.Routes.MapPageRoute("Add ProductType", "AddProductType", "~/UserControl/Template/ProductType/AddProductType.aspx");
            RouteTable.Routes.MapPageRoute("Edit ProductType", "EditProductType/{ID}", "~/UserControl/Template/ProductType/EditProductType.aspx");

            RouteTable.Routes.MapPageRoute("List Roles", "ListRoles", "~/UserControl/Template/Roles/ListRoles.aspx");

            RouteTable.Routes.MapPageRoute("Settings", "Settings", "~/UserControl/Template/Settings/Settings.aspx");

            RouteTable.Routes.MapPageRoute("List Source", "ListSources", "~/UserControl/Template/Source/ListSources.aspx");
            RouteTable.Routes.MapPageRoute("Add Source", "AddSource", "~/UserControl/Template/Source/AddSource.aspx");
            RouteTable.Routes.MapPageRoute("Edit Source", "EditSource/{ID}", "~/UserControl/Template/Source/EditSource.aspx");

            RouteTable.Routes.MapPageRoute("Subscribe", "Subscribe", "~/UserControl/Template/Subscribe/Subscribe.aspx");

            RouteTable.Routes.MapPageRoute("FileUpload", "FileUpload", "~/UserControl/Template/Upload/FileUpload.aspx");

            RouteTable.Routes.MapPageRoute("List Users", "ListUsers", "~/UserControl/Template/Users/ListUsers.aspx");
            RouteTable.Routes.MapPageRoute("Recover Password", "RecoverPassword", "~/UserControl/Template/Users/RecoverPassword.aspx");
            RouteTable.Routes.MapPageRoute("Register", "Register", "~/UserControl/Template/Users/Register.aspx");
            RouteTable.Routes.MapPageRoute("ViewMore", "ViewMore", "~/UserControl/Template/Users/ViewMore.aspx");

            RouteTable.Routes.MapPageRoute("List Widget", "ListWidget", "~/UserControl/Template/Widget/ListWidget.aspx");
            RouteTable.Routes.MapPageRoute("Add Widget", "AddWidget", "~/UserControl/Template/Widget/AddWidget.aspx");
            RouteTable.Routes.MapPageRoute("Edit Widget", "EditWidget/{ID}", "~/UserControl/Template/Widget/EditWidget.aspx");
        }
    }
}