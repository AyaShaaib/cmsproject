<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListUsers.aspx.cs" Inherits="Annex.UserControl.Template.User.ListUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function openModal() {
            $('[id*=myModal]').modal('show');
        }
    </script>

    <div>

        <table class="table">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                   <th>Locked</th>
                    <th>Action</th>

                </tr>
            </thead>
            <%-- Using the repeater to fill the table with bound data from the datatable in getUsers function in UserController --%>
            <tbody>
                <asp:Repeater ID="UsersRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("UserId")%></td>
                            <td><%#Eval("Fname")%> <%#Eval("Lname")%> </td>
                            <td><%#Eval("Email")%></td>
                            <td><%#Eval("PhoneNumber")%></td>
                       <%-- if the account islocked value is set to true then the icon will be a checkmark if not it will be a cross --%>
                           <td> <%# ((bool)Eval("IsLocked") == true ? "<i class='fa fa-check'></i>" : "<i class='fa fa-times'></i>" )%></td>
                            <td>
                                <div class="input-group-append">
                                    <button type="button" class="btn btn-primary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        <span class="sr-only">Toggle Dropdown</span>
                                        Actions
                                    </button>
                                    <div class="dropdown-menu">
                                        <li>
                                            <%-- The more info btn that redirects the user to Viewmore page and extract the Id using command argument --%>
                                            <asp:LinkButton ID="btnMoreinfo" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("UserId") %>' OnClick="btnMoreinfo_Click">More Information</asp:LinkButton></li>
                                        <li>
                                            <%-- The delete button that delete a user using the id extracted using command argument and Usercontroller deleteuser func --%>
                                            <asp:LinkButton ID="btnDelete" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("UserId") %>' OnClick="btnDelete_Click">Delete</asp:LinkButton></li>
                                   <li>
                                       <%-- this button is used to unlock the acconts that are locked after attempting to sign in 4 times and failed--%>
                                            <asp:LinkButton ID="Unlock" runat="server" CssClass="dropdown-item" CommandArgument='<%#Eval("UserId") %>' OnClick="Unlock_Click">Unlock Account</asp:LinkButton></li>
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
