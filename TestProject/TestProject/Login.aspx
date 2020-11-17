<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestProject.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="w-100">
        <tr>
            <td class="text-center">
                <asp:Image ID="imgABCLogo" runat="server" ImageUrl="~/Images/köle.png" Height="195px" Width="195px" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">Login ID:
                <asp:TextBox ID="txtLoginID" runat="server" TextMode="Email" ToolTip="e-mail address"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">Password:
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:RadioButton ID="rdoAdmin" runat="server" Text="System Administrator" GroupName="Role" />
&nbsp;
                <asp:RadioButton ID="rdoStudent" runat="server" Text="Student" GroupName="Role" />
&nbsp;
                <asp:RadioButton ID="rdoMentor" runat="server" Text="Mentor" GroupName="Role" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="155px" OnClick="btnLogin_Click" />
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    
</asp:Content>
