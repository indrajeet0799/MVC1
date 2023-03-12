<%@ Page Title="" Language="C#" MasterPageFile="~/First.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPshopmanagement.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 100%;
        height: 333px;
    }
    .auto-style6 {
        width: 543px;
    }
    .auto-style7 {
        width: 466px;
        text-align: right;
    }
    .auto-style8 {
        width: 466px;
        height: 68px;
    }
    .auto-style9 {
        width: 557px;
    }
    .auto-style10 {
        width: 557px;
        height: 68px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<table class="auto-style5">
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbltype" runat="server" Text="Type"></asp:Label>
        </td>
        <td class="auto-style9">
            <asp:DropDownList ID="drpType" runat="server" Width="152px">
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Customer</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lblEmailID" runat="server" Text="EmailID"></asp:Label>
        </td>
        <td class="auto-style9">
            <asp:TextBox ID="txtEmailid" runat="server" Width="282px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
        </td>
        <td class="auto-style9">
            <asp:TextBox ID="txtpass" runat="server" Width="285px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style10">
            <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" Height="45px" Width="147px" />
        </td>
    </tr>
</table>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
