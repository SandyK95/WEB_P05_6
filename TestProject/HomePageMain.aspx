<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="HomePageMain.aspx.cs" Inherits="TestProject.HomePageMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            position: relative;
            left: 0px;
            top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12">
    <div class="text-center">
        <asp:Image ID="HomeImage" runat="server" ImageUrl="~/Images/Home.png" CssClass="img-fluid"/>
    </div>
</div>
</asp:Content>
