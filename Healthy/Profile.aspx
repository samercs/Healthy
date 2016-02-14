<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Healthy.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="body">
        <div class="section">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Profile Page</h3>
                </div>
                <div class="panel-body">
                    <asp:Panel CssClass="alert" Visible="False" ID="Panel1" runat="server">
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    </asp:Panel>
                    <div class="row">
                        <div class=" col-md-6 col-md-offset-3">
                            <table class="table table-responsive table-striped">
                                <tr>
                                    <td>
                                        <strong>Name</strong>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="text-success" ID="lblName" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <strong>User Name</strong>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="text-success" ID="lblUserName" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <strong>Email</strong>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="text-success" ID="lblEmail" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <strong>Type</strong>
                                    </td>
                                    <td>
                                        <asp:Label CssClass="text-success" ID="lblType" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <a href="ChangePassword.aspx"> Change Password</a>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>
</asp:Content>
