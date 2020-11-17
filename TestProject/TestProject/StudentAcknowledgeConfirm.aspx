<%@ Page Title="" Language="C#" MasterPageFile="~/StudentTemplate.Master" AutoEventWireup="true" CodeBehind="StudentAcknowledgeConfirm.aspx.cs" Inherits="TestProject.StudentAcknowledgeConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 199px;
        }
        .auto-style4 {
            width: 199px;
            height: 36px;
        }
        .auto-style5 {
            height: 36px;
        }
        .auto-style6 {
            width: 199px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3">SuggestionID:</td>
            <td>
                <asp:Label ID="lblSuggestionID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Description:</td>
            <td>
                <asp:Label ID="lblDescription" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Status</td>
            <td class="auto-style7">
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5">
                <asp:Button ID="btnAcknowledge" runat="server" OnClick="btnAcknowledge_Click" style="height: 33px" Text="Acknowledge" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>
