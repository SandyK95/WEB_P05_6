<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="AdminCreateStudentAccount.aspx.cs" Inherits="TestProject.AdminCreateStudentAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 200px;
        }
        .auto-style5 {
            width: 200px;
            height: 36px;
        }
        .auto-style6 {
            height: 36px;
        }
        .auto-style7 {
            margin-top: 6;
        }
        .auto-style8 {
            width: 231px;
        }
        .auto-style9 {
            font-family: "Segoe UI";
            color: #FF0000;
        }
        .auto-style10 {
            font-family: "Segoe UI";
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <div class="text-center">
            <span class="auto-style10">
        <strong>Create Student Account</strong></span>
        </div>
        <table class="w-100">
            <tr>
                <td class="auto-style5">Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter a name" ForeColor="Red">*</asp:RequiredFieldValidator>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email: </td>
                <td>
                    <asp:TextBox ID="txtEmailAddr" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" CssClass="auto-style9" ErrorMessage="Please enter a valid email address" ControlToValidate="txtEmailAddr" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    <asp:CustomValidator ID="cuvEmail" runat="server" ControlToValidate="txtEmailAddr" Display="Dynamic" ErrorMessage="This email has already been used." ForeColor="Red">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mentor: </td>
                <td>
                    <asp:DropDownList ID="ddMentor" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Year Enrolled: </td>
                <td>
                    <asp:Label ID="lblCurrentYear" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Course:</td>
                <td>
                    <asp:DropDownList ID="ddCourse" runat="server" AutoPostBack="true" >
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table class="w-100">
            <tr>
                <td class="auto-style2">Student Number:</td>
                <td class="text-left">
                    <asp:TextBox ID="txtStudentNumber" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfStudentNumber" runat="server" CssClass="auto-style9" ErrorMessage="Please enter a Student Number" ControlToValidate="txtStudentNumber" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="text-left">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfPassword" runat="server" CssClass="auto-style9" ErrorMessage="Please enter a password" ControlToValidate="txtPassword" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password:</td>
                <td class="text-left">
                    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="cvCfmPw" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Please use the same password." ForeColor="Red">*</asp:CompareValidator>
                </td>
            </tr>
        </table>
        <table class="w-100">
            <tr>
                <td>
                    <table class="w-100">
                        <tr>
                            <td class="auto-style8">&nbsp;</td>
                            <td>
                    <asp:Button ID="btnConfirm" runat="server" CssClass="auto-style7" Text="Confirm" Width="130px" OnClick="btnConfirm_Click" />
                                <br />
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style9" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    &nbsp;</p>
</asp:Content>
