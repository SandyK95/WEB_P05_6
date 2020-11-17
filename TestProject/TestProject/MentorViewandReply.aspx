<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorViewandReply.aspx.cs" Inherits="TestProject.MentorViewandReply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 325px;
        }
        .auto-style6 {
            width: 325px;
            text-align: center;
        }
        .auto-style7 {
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3" colspan="2"><strong>Reply Message </strong></td>
        </tr>
        <tr>
            <td class="auto-style4">MessageID:</td>
            <td>
                <asp:Label ID="lblMessageID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">MentorID:</td>
            <td>
                <asp:Label ID="lblMentorID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Reply Text:</td>
            <td>
                <asp:TextBox ID="txtReplyBox" runat="server" Height="198px" Rows="5" TextMode="MultiLine" Width="413px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;<asp:Label ID="lblReplied" runat="server" CssClass="auto-style7" Font-Bold="True" ForeColor="#009933" Text="Reply Message have been sent successfully!" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send" />
            </td>
            <td class="text-center">
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td class="text-left" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
