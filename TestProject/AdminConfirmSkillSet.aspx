<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminConfirmSkillSet.aspx.cs" Inherits="TestProject.AdminConfirmSkillSet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 202px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;<asp:Label ID="lblId" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblName" runat="server"></asp:Label>
&nbsp;has been added into the system successfully.<table class="w-100">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnAcknowledge" runat="server" Text="Acknowledge" OnClick="btnAcknowledge_Click" />
            </td>
        </tr>
    </table>
</p>
</asp:Content>
