<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminUploadStudent.aspx.cs" Inherits="TestProject.AdminUploadStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 419px;
        }
        .auto-style3 {
            width: 419px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-center">
        <em>&quot;Upload Student Photo&quot;</em><table class="w-100">
            <tr>
                <td class="auto-style3">Student Name: </td>
                <td class="text-left">
                    <asp:DropDownList ID="ddlName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlName_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ddlName" ErrorMessage="Please select a valid student ID." ForeColor="Red" MaximumValue="9999" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
                </td>
                <td class="text-left">&nbsp;</td>
                <td class="text-left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="text-left">
                    <asp:Image ID="imgPhoto" runat="server" Height="100px" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="text-left">&nbsp;</td>
                <td class="text-left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Choose your photo: (jpg format)</td>
                <td class="text-left">
                    <asp:FileUpload ID="upPhoto" runat="server" Height="54px" Width="289px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="text-left">
                    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                <td class="text-left">&nbsp;</td>
                <td class="text-left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="text-left">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
