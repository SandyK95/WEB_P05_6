<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminConfirmMentor.aspx.cs" Inherits="TestProject.AdminConfirmMentor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 188px;
        }
    .auto-style3 {
        width: 188px;
        text-align: right;
    }
        .auto-style4 {
            width: 188px;
            height: 32px;
        }
        .auto-style5 {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        The following mentor has been added successfully.&nbsp;
        <table class="w-100">
            <tr>
                <td class="auto-style4">ID:</td>
                <td class="auto-style5">
                    <asp:Label ID="lblId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Name: </td>
                <td class="auto-style5">
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email: </td>
                <td>
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
