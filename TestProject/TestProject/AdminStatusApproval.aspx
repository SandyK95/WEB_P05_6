<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminStatusApproval.aspx.cs" Inherits="TestProject.AdminStatusApproval" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 479px;
            text-align: right;
        }
        .auto-style3 {
            width: 291px;
            text-align: center;
        }
        .auto-style4 {
            width: 707px;
            text-align: right;
        }
        .auto-style5 {
            width: 790px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-center">
        <div class="text-center">
            Do you wish to approve the below entry?<table class="w-100">
                <tr>
                    <td class="auto-style5">ViewingRequestID:
                        <asp:Label ID="lblViewID" runat="server"></asp:Label>
                    </td>
                    <td class="text-left">Student Name:&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblStudName" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
&nbsp;<table class="w-100">
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="text-left">
                        <asp:Label ID="lblChange" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table class="w-100">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnApprove" runat="server" Text="Approve" OnClick="btnApprove_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" />
                </td>
                <td class="text-left">
                    <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
