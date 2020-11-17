<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminConfirmStudent.aspx.cs" Inherits="TestProject.AdminConfirmStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 255px;
        }
    .auto-style3 {
        width: 255px;
        text-align: right;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Student has been added successfully.<table class="w-100">
            <tr>
                <td class="auto-style2">Student ID:</td>
                <td>
                    <asp:Label ID="lblId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Student Name:</td>
                <td>
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Enrolled Course: </td>
                <td>
                    <asp:Label ID="lblCourse" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Student Email: </td>
                <td>
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
