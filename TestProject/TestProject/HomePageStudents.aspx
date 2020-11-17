<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="HomePageStudents.aspx.cs" Inherits="TestProject.HomePageStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -ms-flex: 0 0 100%;
            flex: 0 0 100%;
            max-width: 100%;
            text-align: left;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style3">
        <asp:GridView ID="gvPosters" runat="server" BorderStyle="None" GridLines="None" ShowHeader="False" AutoGenerateColumns="False" Height="500px" Width="400px" HorizontalAlign="Center">
            <Columns>
                <asp:ImageField DataImageUrlField="ProjectPoster" DataImageUrlFormatString="Images\{0}" ControlStyle-Width="500" ControlStyle-Height="600">
<ControlStyle Height="300px" Width="200px"></ControlStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:ImageField>
            </Columns>
            <HeaderStyle BorderStyle="None" />
        </asp:GridView>
        <br />
    </div>
</asp:Content>
