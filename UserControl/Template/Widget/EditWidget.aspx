<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditWidget.aspx.cs" Inherits="Annex.UserControl.Template.Widget.EditWidget" %>
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
                                <li class="breadcrumb-item active">Widget</li>
                            </ol>
                        </div>
                        <h4 class="page-title">Add Widget</h4>
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
                                        <tr>
                                            <th>#</th>
                                            <th>Widget Name</th>
                                            <th>Status</th>
                                            <th>Actions</th>
                                        </tr>
                                        <tr>
                                            <td><%#Eval("WidgetID")%></td>
                                            <td>
                                                <asp:TextBox ID="txtWidgetTitle" runat="server"></asp:TextBox></td>
                                            <td>
                                                <asp:CheckBox ID="chkPublished" runat="server" /></td>
                                            <td>
                                                <asp:Button Text="edit" ID="btnEdit" runat="server" OnClick="Edit_Click" /></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
