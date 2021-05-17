<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewMore.aspx.cs" Inherits="Annex.UserControl.Template.User.ViewMore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <table class="table">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Phone Number</th>
                <th>Change Password</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <asp:Label runat="server" ID="txtId"></asp:Label></td>
                <td>
                    <asp:Label runat="server" ID="txtname"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="txtEmail"></asp:Label></td>
                <td>
                    <asp:Label runat="server" ID="txtPhone"></asp:Label></td>
                <td>
                    <asp:LinkButton data-toggle="modal" data-target="#myModal" runat="server" ID="changepassbtn" Text="Change Password" CssClass="btn btn-primary" OnClick="changepassbtn_Click"></asp:LinkButton></td>
            </tr>
        </tbody>
    </table>
</div>
    <!-- The Modal -->
    <div class="modal fade" id="myModal">
        <div class="modal-dialog">
            <div class="modal-content">

                <!-- Modal Header -->
                <div class="modal-header">
                    <h4 class="modal-title">Change Password</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>

                <!-- Modal body -->
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-6 font-16">New Password :</div>
                        <div class="col-lg-6"><asp:TextBox runat="server" placeholder="Password" ID="txtpass" TextMode="Password"></asp:TextBox></div>
                    </div>
                    <br/>
                    <div class="row">
                        <div class="col-lg-6 font-16">Confirm Password :</div>
                        <div class="col-lg-6"><asp:TextBox runat="server" placeholder="Confrim Password" TextMode="Password"></asp:TextBox></div>
                    </div>
                    <br/>
                    <div class="row">
                        <div class="col-lg-6"><asp:Button CssClass="btn btn-primary" Text="Confirm" runat="server" ID="confirmpasschange" OnClick="confirmpasschange_Click"></asp:Button></div>
                    </div>

                </div>

                <!-- Modal footer -->
                <div class="modal-footer">
                    <asp:Button type="button" class="btn btn-primary" data-dismiss="modal" runat="server" Text="Close"></asp:Button>
                </div>

            </div>

        </div>
    </div>
</asp:Content>
