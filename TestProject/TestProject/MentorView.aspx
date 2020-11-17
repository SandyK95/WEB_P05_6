<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorView.aspx.cs" Inherits="TestProject.View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            font-family: "Segoe UI";
            font-size: xx-large;
            text-align: left;
        }
        .auto-style4 {
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3"><strong>View and Reply Parents Messages</strong></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <div class="col-sm-12">
                <asp:GridView ID="gvSender" runat="server" CellPadding="5" ForeColor="#333333" GridLines="Vertical" Height="200px" Width="600px" AutoGenerateSelectButton="True" DataKeyNames="MessageID" OnSelectedIndexChanged="gvSender_SelectedIndexChanged">
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
                    </div>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:GridView ID="gvReceiver" runat="server" AutoGenerateColumns="False" Width="675px" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="MessageID" HeaderText="Message ID" />
                        <asp:BoundField DataField="ReplyID" HeaderText="Reply ID" />
                        <asp:BoundField DataField="DateTimePosted" HeaderText="Date Time Posted" />
                        <asp:BoundField DataField="Text" HeaderText="Messages" />
                        <asp:HyperLinkField DataNavigateUrlFields="MessageID" DataNavigateUrlFormatString="MentorViewandReply.aspx?messageid={0}" Text="Reply" />
                    </Columns>
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
                <br />
                <asp:Label ID="lblMessageID" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
