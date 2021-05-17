<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="Annex.UserControl.Template.Subscribe.Subscribe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <div class="btn-group float-right">
                    <ol class="breadcrumb hide-phone p-0 m-0">
                        <li class="breadcrumb-item"><a href="home.aspx">Home</a></li>
                        <li class="breadcrumb-item"><a href="Subscribe.aspx">Subscribe</a></li>
                    </ol>
                </div>
                <h4 class="page-title">Subscribe</h4>
            </div>
        </div>
    </div>
    <div>

        <table class="table">
            <thead>
                <tr>
                    <th>Subscription ID</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Actions</th>
                       </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="subsrepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("SubscriptionID")%></td>
                            <td><%#Eval("Name")%></td>
                            <td><%#Eval("Email")%></td>
                            <td><%#Eval("Phone")%></td>
                            <td>
                                <div class="input-group-append">
                                    <button type="button" class="btn btn-primary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        <span class="sr-only">Toggle Dropdown</span>
                                        Actions
                                    </button>
                                    <div class="dropdown-menu">
                                    
                                        <li>
                                            <asp:LinkButton ID="btnDelete" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("SubscriptionID") %>' OnClick="btnDelete_Click">Delete</asp:LinkButton></li>
                                    </div>

                                </div>
                                
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                </tbody>
            </table></div>
</asp:Content>
