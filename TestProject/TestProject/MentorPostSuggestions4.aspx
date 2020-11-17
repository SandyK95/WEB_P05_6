<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorPostSuggestions4.aspx.cs" Inherits="TestProject.MentorPostSuggestions4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 299px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style4"><strong>ProjectID: </strong></td>
            <td>
                <asp:Label ID="lblProjectID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Project Title: </strong></td>
            <td>
                <asp:Label ID="lblProjectTitle" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Project Description:</strong></td>
            <td>
                <asp:Label ID="lblProjectDescription" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Project Poster: </strong></td>
            <td>
                <asp:Image ID="imgPoster" runat="server" Height="300px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Project URL: </strong></td>
            <td class="auto-style6">
                <asp:HyperLink ID="hlProjectURL" runat="server">Link</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Reflection: </strong></td>
            <td>
                <asp:Label ID="lblReflection" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
