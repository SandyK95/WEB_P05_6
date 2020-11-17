<%@ Page Title="" Language="C#" MasterPageFile="~/MentorTemplate.Master" AutoEventWireup="true" CodeBehind="MentorApproveEdit.aspx.cs" Inherits="TestProject.MentorApproveEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            font-size: xx-large;
            color: #FF0000;
        }
        .auto-style5 {
            font-size: large;
            height: 76px;
            width: 154px;
        }
        .auto-style6 {
            height: 76px;
        }
        .auto-style7 {
            font-size: large;
            width: 154px;
        }
    .auto-style8 {
        font-weight: bold;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style4" colspan="2"><em><strong>Approve or Reject Student </strong></em><strong>D</strong><span class="auto-style8">etails</span></td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Student ID:</strong></td>
            <td>
                <asp:Label ID="lblStudentID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Name:</strong></td>
            <td>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Course:</strong></td>
            <td class="auto-style6">
                <asp:Label ID="lblCourse" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Status:</strong> </td>
            <td class="auto-style6">
                <asp:RadioButtonList ID="rdoStatus" runat="server">
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" Width="163px" OnClick="btnSave_Click"/>
&nbsp;&nbsp;<br />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="162px" OnClick="btnCancel_Click" />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Button ID="btnPortfolio" runat="server" OnClick="btnPortfolio_Click" Text="View Portfolio" Width="162px" />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
