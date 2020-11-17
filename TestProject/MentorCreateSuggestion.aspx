<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorCreateSuggestion.aspx.cs" Inherits="TestProject.MentorCreateSuggestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 184px;
        }
        .auto-style5 {
            width: 184px;
            height: 38px;
        }
        .auto-style6 {
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Student ID :</td>
            <td>
                <asp:Label ID="lblStudentID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Suggestion : </td>
            <td>
                <asp:TextBox ID="txtSuggestion" runat="server" Height="136px" TextMode="MultiLine" Width="364px"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvSuggestion" runat="server" ControlToValidate="txtSuggestion" ErrorMessage="Please include that suggestion" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lblSubmit" runat="server" ForeColor="#009900" Text="Success" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="lblStatus" runat="server" ForeColor="#009933"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Mentor ID:</td>
            <td class="auto-style6">
                <asp:Label ID="lblMentorID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            &nbsp;<asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" Enabled="False" Width="95px" />
            </td>
        </tr>
    </table>
</asp:Content>
