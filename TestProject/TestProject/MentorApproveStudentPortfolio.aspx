<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorApproveStudentPortfolio.aspx.cs" Inherits="TestProject.ApproveStudentPortfolio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        font-family: "Segoe UI";
        font-style: italic;
        font-weight: bold;
        font-size: xx-large;
        color: #FF0000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-left">
        <span class="auto-style3">View Students List</span>
        </p>
    <p class="text-left">
        <asp:Label ID="lblMessage" runat="server" Font-Size="Medium"></asp:Label>
</p>
<p class="text-left">
        <asp:GridView ID="gvStudent" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvStudent_PageIndexChanging" PageSize="5" AutoGenerateColumns="False" DataKeyNames="StudentID">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="MentorApproveEdit.aspx?studentid={0}" DataTextField="StudentID" HeaderText="Student ID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:HyperLinkField>
                <asp:BoundField DataField="Name" HeaderText="Student Name" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
            </Columns>
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
</p>
    <p class="text-left">
        &nbsp;</p>
</asp:Content>
