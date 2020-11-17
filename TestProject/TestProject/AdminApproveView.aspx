<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminApproveView.aspx.cs" Inherits="TestProject.AdminApproveView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 197px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-center">
        <em>&quot;Approve Viewing Request&quot;</em><table class="w-100">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="text-left">
                    <strong>Viewing Request count:
                    <asp:Label ID="lblCount" runat="server"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="text-left">
                    <asp:GridView ID="gvViewingRequest" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="ViewingRequestID" HeaderText="ViewingRequestID" />
                            <asp:BoundField DataField="ParentID" HeaderText="Parent ID" />
                            <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                            <asp:HyperLinkField DataNavigateUrlFields="ViewingRequestID,StudentName" DataNavigateUrlFormatString="AdminStatusApproval.aspx?viewingrequestid={0}&amp;studentname={1}" DataTextField="Status" HeaderText="Status" />
                            <asp:BoundField DataField="DateCreated" HeaderText="Date Created" />
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
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
