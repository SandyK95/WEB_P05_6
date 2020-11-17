<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorChange.aspx.cs" Inherits="TestProject.Change" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            width: 206px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3" colspan="3"><strong>Change Password</strong></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">New Password:</td>
            <td>
                <asp:TextBox ID="txtNewPwd" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfNewPassword" runat="server" ControlToValidate="txtNewPwd" ErrorMessage="Please enter password" ForeColor="Red">*</asp:RequiredFieldValidator>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Confirm Password:</td>
            <td>
                <asp:TextBox ID="txtConfirmPwd" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="cvConfirmPassword" runat="server" ControlToCompare="txtNewPwd" ControlToValidate="txtConfirmPwd" ErrorMessage="Password does not match" ForeColor="Red">*</asp:CompareValidator>
                <asp:CustomValidator ID="cuvConfirmPassword" runat="server" ErrorMessage="Please enter least 8 characters and 1 digit" ForeColor="Red" OnServerValidate="cuvConfirmPassword_ServerValidate">*</asp:CustomValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="text-left">
                <asp:Button ID="btnUpdate" runat="server" Text="Update new Password" OnClick="btnUpdate_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
