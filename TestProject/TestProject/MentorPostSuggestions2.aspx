<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorPostSuggestions2.aspx.cs" Inherits="TestProject.MentorPostSuggestions2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 253px;
        }
        .auto-style7 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style7" colspan="2"><strong>Student Details: </strong></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Image ID="Img" runat="server" Height="200px" Width="200px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Student ID:</strong></td>
            <td>
                <asp:Label ID="lblStudentID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Student Name: </strong></td>
            <td>
                <asp:Label ID="lblStudentName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Course:</strong></td>
            <td>
                <asp:Label ID="lblCourse" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Description: </strong></td>
            <td>
                <asp:Label ID="lblDescription" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Achievement(s): </strong></td>
            <td>
                <asp:Label ID="lblAchievement" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>Skill(s)</strong></td>
            <td>
                <asp:GridView ID="gvSkills" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><strong>External Link: </strong></td>
            <td>
                <asp:HyperLink ID="hlExternalLink" runat="server">Link</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <strong><span class="auto-style7">Project Details: </span></strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvProjects" runat="server" AutoGenerateColumns="False" Width="600px" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="ProjectID" DataNavigateUrlFormatString="MentorPostSuggestions4.aspx?projectid={0}" Text="View" />
                        <asp:BoundField DataField="Title" HeaderText="Project Title" />
                        <asp:BoundField DataField="Role" HeaderText="Role" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnApprove" runat="server" OnClick="btnApprove_Click" Text="Approve"/>
                &nbsp;<asp:Button ID="btnSuggest" runat="server" OnClick="btnSuggest_Click" Text="Suggest" />
            &nbsp;<asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" Width="129px" />
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
