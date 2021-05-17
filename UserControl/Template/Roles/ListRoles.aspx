<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListRoles.aspx.cs" Inherits="Annex.UserControl.Template.Roles.ListRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <div class="btn-group float-right">
                    <ol class="breadcrumb hide-phone p-0 m-0">
                        <li class="breadcrumb-item"><a href="home.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="ListRoles.aspx">Role's List</a></li>
                    </ol>
                </div>
                <h4 class="page-title">Roles List</h4>
            </div>
        </div>
    </div>
<div>
        <table class="table">
            <thead>
                <tr>
                    <th>Role ID</th>
                    <th>Role Name</th>
                    <th>Enabled</th>
                    <th>More Actions</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="RolesRepeater" runat="server">
                    <ItemTemplate>
                        <tr class=" col-sm-1">
                            <td><%#Eval("RoleID")%></td>
                            <td><%#Eval("RoleName")%></td>
                            <%--<td><%# Eval("Enabled").ToString()%></td>--%>
                                <td><%# ((bool)Eval("Enabled") == true ? "<i class='fa fa-check'></i>" : "<i class='fa fa-times'></i>" )%></td>
                            <td>
                                <div class="input-group-append">
                                    <button type="button" class="btn btn-primary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        <span class="sr-only">Toggle Dropdown</span>
                                        Actions
                                    </button>
                                    <div class="dropdown-menu">
                                        <li>
                                            <asp:LinkButton ID="CreateRole" runat="server" CssClass="dropdown-item" >Add Role</asp:LinkButton></li>
                                        <li>
                                            <asp:LinkButton ID="btnMoreinfo" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("RoleID") %>' OnClick="btnMoreinfo_Click">More Information</asp:LinkButton></li>
                                        <li>
                                            <asp:LinkButton ID="btnDelete" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("RoleID") %>' OnClick="btnDelete_Click">Delete</asp:LinkButton></li>
                                    </div>

                                </div>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>

        </table>

    </div>
</asp:Content>
