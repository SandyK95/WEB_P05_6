<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorConfirmPasswordChange.aspx.cs" Inherits="TestProject.MentorConfirmPasswordChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <em>Your Password have been changed successfully! You may now start with your navigations.</em></p>
    <p>
        Mentor ID:
        <asp:Label ID="lblMentorID" runat="server"></asp:Label>
    </p>
    <p>
        New Password :
        <asp:Label ID="lblNewPassword" runat="server"></asp:Label>
    </p>
</asp:Content>
