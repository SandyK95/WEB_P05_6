<%@ Page Title="" Language="C#" MasterPageFile="~/StudentTemplate.Master" AutoEventWireup="true" CodeBehind="StudentCreateWork.aspx.cs" Inherits="TestProject.StudentPersonalWork" %>
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
        .auto-style6 {
            width: 200px;
            height: 34px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style10 {
            width: 200px;
            height: 50px;
        }
        .auto-style11 {
            height: 50px;
        }
        .auto-style12 {
            width: 200px;
            height: 3px;
        }
        .auto-style13 {
            height: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>Create Projects</td>
        </tr>
        <tr>
            <td class="auto-style4">Project Name:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtPrjName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPrjName" ErrorMessage="Please enter the project name " ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Members ID:<br />
                (seperated by&quot;,&quot;)</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtMembers" runat="server"></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Description:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDesc" runat="server" Height="140px" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDesc" runat="server" ControlToValidate="txtDesc" ErrorMessage="Please describe your project" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Files:</td>
            <td>
                <asp:FileUpload ID="fupProject" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Project URL:</td>
            <td class="auto-style13">
                <asp:TextBox ID="txtPrjURL" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7">
                <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
                <asp:ValidationSummary ID="vlsProject" runat="server" ForeColor="Red" />
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
    </table>
</asp:Content>
