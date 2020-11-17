<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorPostSuggestions.aspx.cs" Inherits="TestProject.PostSuggestions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-left">
        <asp:GridView ID="gvStudent" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gvStudent_PageIndexChanging" PageSize="5" Width="600px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" DataKeyNames="StudentID" OnSelectedIndexChanged="gvStudent_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="StudentID" DataTextField="StudentID" HeaderText="Student ID" DataNavigateUrlFormatString="MentorPostSuggestions2.aspx?studentid={0}" />
                <asp:BoundField DataField="Name" HeaderText="Student Name" />
                <asp:HyperLinkField DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="MentorPostSuggestions2.aspx?studentid={0}" Text="View ePortfolio" />
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
    <p class="text-left">
        <asp:GridView ID="gvSuggestions" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="601px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <EmptyDataTemplate>
                No Record Found!
            </EmptyDataTemplate>
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
    <p class="text-center">
        <em>&quot;Post suggestions for improvements&quot;</em></p>
</asp:Content>
