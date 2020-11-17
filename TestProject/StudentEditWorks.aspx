<%@ Page Title="" Language="C#" MasterPageFile="~/StudentTemplate.Master" AutoEventWireup="true" CodeBehind="StudentEditWorks.aspx.cs" Inherits="TestProject.StudentEditWorks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 200px;
        }
        .auto-style4 {
            width: 200px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style4">Project ID:</td>
            <td class="auto-style5">
                <asp:Label ID="lblProjectID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Title:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblRemoveMembers" runat="server" Text="Remove Group Members: " Visible="False"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:GridView ID="gvMembers" runat="server" AutoGenerateColumns="False" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="StudentID" HeaderText="Member ID" AccessibleHeaderText="MemberID" />
                        <asp:HyperLinkField DataNavigateUrlFields="StudentID,ProjectID" DataNavigateUrlFormatString="StudentDeleteMember.aspx?StudentID={0}&amp;ProjectID={1}" Text="Remove" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblAddMembers" runat="server" Text="Add Group Members: (seperated by &quot;,&quot;) " Visible="False"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMembers" runat="server" Height="27px" Visible="False" CssClass="form-check-label"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Description:</td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" Height="150px" Width="260px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Reflection:</td>
            <td>
                <asp:TextBox ID="txtReflection" runat="server" Height="90px" Width="260px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
