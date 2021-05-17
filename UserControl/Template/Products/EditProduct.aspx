<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Annex.UserControl.Template.Products.EditProduct" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <div class="page-content-wrapper ">

            <div class="container-fluid">

                <div class="row">
                    <div class="col-sm-12">
                        <div class="page-title-box">
                            <div class="btn-group float-right">
                                <ol class="breadcrumb hide-phone p-0 m-0">
                                    <li class="breadcrumb-item"><a href="#">Annex</a></li>
                                    <li class="breadcrumb-item"><a href="#">Forms</a></li>
                                    <li class="breadcrumb-item active">Products</li>
                                </ol>
                            </div>
                            <h4 class="page-title">Edit Product</h4>
                        </div>
                    </div>
                </div>
                <!-- end page title end breadcrumb -->

                <div class="row">
                    <div class="col-12">
                        <div class="card m-b-30">
                            <div class="card-body">
                                <div class="row">
                                <div class="form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Name</label>
                                     <div class="col-sm-12">
                                       <asp:TextBox ID="ProductName" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ProductName" ErrorMessage="Please Enter a Product Name" ForeColor="Red"></asp:RequiredFieldValidator>
                                      </div>
                                </div>
                                    </div>
                                <div class="row">
                                <div class="form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Category</label>
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlCategories" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Product Type</label>
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlProductType" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                    <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Product Availability</label>
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlProductAvailability" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                    </div>
                                <br />
                                <div class="row">
                                    <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Width</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox ID="Width" runat="server" TextMode="Number" CssClass="form-control" ></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Height</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox ID="Height" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Depth</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox ID="Depth" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                    </div>
                                <br /><br />
                                <div class="row">
                                <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Old Price</label>
                                    <div class="col-sm-12">
                                       <asp:TextBox ID="OldPrice" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="OldPrice" ErrorMessage="Please Enter it's Old Price"  ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                 <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">New Price</label>
                                    <div class="col-sm-12">
                                       <asp:TextBox ID="NewPrice" runat="server" TextMode="Number" OnTextChanged="Calculate_Click" AutoPostBack="true" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="NewPrice" ErrorMessage="Please Enter it's New Price"  ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="Form-group col-4">
                                    <label  class="col-sm-12 font-weight-bold">Percentage</label>
                                    <div class="col-sm-12">
                                      <asp:TextBox ID="Percentage" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                        </div>
                                </div>
                                    </div>
                                <br />
                                <div class="row">
                                <div class="form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Language</label> 
                                    <div class="col-sm-12">
                                        <asp:DropDownList ID="ddlLanguageId" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                    </div>
                                <br />
                                <div class="row">
                                <div class="Form-group col-4">
                                    <label class="col-sm-12 font-weight-bold">Small Description</label>
                                    <div class="col-sm-12">
                                        <asp:TextBox ID="SmallDescription" runat="server" TextMode="MultiLine" MaxLength="100" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequireFieldValidator4" runat="server" ControlToValidate="SmallDescription" ErrorMessage="Please Enter a Small Description"  ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <br />
                                <div class="row">
                                 <div class="Form-group col-12">
                                    <label class="col-sm-12 font-weight-bold">Description</label>
                                    <div class="col-sm-12">
                                        <textarea class="ckeditor" runat="server" id="Description"></textarea>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Description" ErrorMessage="Please Enter a Description"  ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                    </div>
                                <br />
                                <div class="form-group row col-2">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn-primary" OnClick="Edit_Click" CssClass="btn-primary form-control"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
