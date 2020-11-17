<%@ Page Title="" Language="C#" MasterPageFile="~/StudentTemplate.Master" AutoEventWireup="true" CodeBehind="StudentDeleteMember.aspx.cs" Inherits="TestProject.StudentDeleteMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .auto-style5 {
            height: 26px;
            text-align: left;
        }
        .auto-style6 {
            width: 297px;
            height: 27px;
            text-align: center;
        }
        .auto-style7 {
            height: 27px;
            text-align: left;
        }
        .auto-style8 {
            width: 297px;
            height: 26px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style6">Member&#39;s Student ID:</td>
            <td class="auto-style7">
                <asp:Label ID="lblStudentID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Member&#39;s Name:</td>
            <td class="auto-style5">
                <asp:Label ID="lblStudentName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" Width="110px" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>
