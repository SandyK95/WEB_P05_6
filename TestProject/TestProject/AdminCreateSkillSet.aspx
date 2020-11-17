<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminCreateSkillSet.aspx.cs" Inherits="TestProject.AdminCreateSkillSet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: left;
            width: 168px;
        }
        .auto-style3 {
            width: 168px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-center">
        <em>&quot;Create Choices of Skill Set&quot;</em><table class="w-100">
            <tr>
                <td class="auto-style2">Skill Set Name:</td>
                <td class="text-left">
                    <asp:TextBox ID="txtSkillName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSkillSet" runat="server" ControlToValidate="txtSkillName" ErrorMessage="Please enter a name." ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="cvSkillSet" runat="server" ControlToValidate="txtSkillName" Display="Dynamic" ErrorMessage="This name is already in the system." ForeColor="Red" OnServerValidate="cvSkillSet_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="text-left">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="text-left">
                    <asp:ValidationSummary ID="vmSkillSet" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
