<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminCreateMentor.aspx.cs" Inherits="TestProject.AdminCreateMentor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 200px;
        }
        .auto-style3 {
            width: 200px;
            height: 32px;
        }
        .auto-style4 {
            height: 32px;
        }
        .auto-style5 {
            width: 200px;
            height: 36px;
        }
        .auto-style6 {
            height: 36px;
        }
    .auto-style7 {
        width: 200px;
        height: 34px;
    }
    .auto-style8 {
        height: 34px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>Create Mentor Account</strong><table class="w-100">
            <tr>
                <td class="auto-style5">Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter a name" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Date Entered:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblCurrentDate" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td id="lblDateEntered" class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Login Details</strong></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style7">Email:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtEmailAddr" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmailAddr" ErrorMessage="Please enter an email" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmailAddr" ErrorMessage="Please enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    <asp:CustomValidator ID="cuvEmail" runat="server" ControlToValidate="txtEmailAddr" Display="Dynamic" ErrorMessage="This email has already been used." ForeColor="Red">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter an email" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password:</td>
                <td>
                    <asp:TextBox ID="txtCfmPassword" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="cvCfmPw" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtCfmPassword" ErrorMessage="Please enter the same password" ForeColor="Red">*</asp:CompareValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtCfmPassword" Display="Dynamic" ErrorMessage="Please re-enter the same password.">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" Text="Create" OnClick="btnConfirm_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
