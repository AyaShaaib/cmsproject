<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="Category.Products.ListProducts"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <div class="page-content-wrapper ">
            <div class="row">
                <div class="col-sm-12">
                    <div class="page-title-box">
                        <div class="btn-group float-right">
                            <ol class="breadcrumb hide-phone p-0 m-0">
                                <li class="breadcrumb-item"><a href="#">Annex</a></li>
                                <li class="breadcrumb-item"><a href="#">Tables</a></li>
                                <li class="breadcrumb-item active">Products</li>
                            </ol>
                        </div>
                        <div class="row col-8">
                        <h4 class="page-title col-3">List Products</h4>
                            <div class="col-4">
                        <asp:Button ID="InsertRedirect" runat="server" Text="Add Product" OnClick="Insert_Redirect" CssClass="btn-primary form-control"/>
                            </div>
                            </div>
                    </div>
                </div>
            </div>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12 col-sm-12">
                        <div class="card m-b-30">
                            <div class="card-body table-responsive">

                                <div class="">
                                    <table id="datatable" class="table table-bordered">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Name</th>
                                                <th>Category</th>
                                                <th>Small Description</th>
                                                <th>Type</th>
                                                <th>Availablilty</th>
                                                <th>Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptProducts" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%#Eval("ProductId")%></td>
                                                        <td><%#Eval("ProductName")%></td>
                                                        <td><%#Eval("CategoryName")%></td>
                                                        <td><%#Eval("SmallDescription")%></td>
                                                        <td><%#Eval("ProductType")%></td>
                                                        <td><%#Eval("ProductAvailability") %></td>
                                                        <td>
                                                            <div class="input-group-append">
                                                                <button type="button" class="btn btn-primary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                                    <span class="sr-only">Toggle Dropdown</span>
                                                                    Actions
                                                                </button>
                                                                <div class="dropdown-menu">
                                                                    <li>
                                                                        <asp:LinkButton ID="btnEdit" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("ProductId") %>' OnClick="Edit_Click">Edit</asp:LinkButton></li>
                                                                    <li>
                                                                        <asp:LinkButton ID="btnDelete" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("ProductId") %>' OnClick="Delete_Click">Delete</asp:LinkButton></li>

                                                                </div>
                                                            </div>

                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>


                                </div>
                            </div>
                        </div>



                    </div>
                    <!-- container -->

                </div>
            </div>
        </div>
    </div>
</asp:Content>
