<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorSearch.aspx.cs" Inherits="TestProject.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 380px;
        }
        .auto-style5 {
            width: 1076px;
            text-align: center;
        }
        .auto-style8 {
            font-size: xx-large;
        }
        .auto-style9 {
            width: 380px;
            font-size: medium;
        }
        .auto-style10 {
            width: 1076px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style8" colspan="3"><strong>Search for Students with a Particular Skill Set</strong></td>
        </tr>
        <tr>
            <td class="auto-style9">Search Method</td>
            <td class="auto-style10">
                <asp:RadioButton ID="rdoName" runat="server" Checked="True" GroupName="SearchMethod" Text="Name" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rdoSkill" runat="server" GroupName="SearchMethod" Text="Skill" />
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">Enter Student Name/Skill : </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtSearchStudentInput" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="btnSearch" runat="server" Height="37px" Text="Search" OnClick="btnSearch_Click" />
            &nbsp;<asp:Button ID="btnReset" runat="server" Height="37px" OnClick="btnReset_Click" Text="Reset" Width="97px" />
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblSearchedStudent" runat="server"></asp:Label>
                <br />
                <asp:GridView ID="gvSearchedStudent" runat="server" CellPadding="4" Height="223px" Width="400px" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <p class="text-center">
        <em>&quot;Search Students&quot;</em></p>
</asp:Content>
