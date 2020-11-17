<%@ Page Title="" Language="C#" MasterPageFile="~/StudentTemplate.Master" AutoEventWireup="true" CodeBehind="StudentEditProfile.aspx.cs" Inherits="TestProject.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 201px;
        }
        .auto-style4 {
            width: 201px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            width: 201px;
            height: 28px;
        }
        .auto-style7 {
            height: 28px;
        }
        .auto-style8 {
            width: 201px;
            height: 143px;
        }
        .auto-style9 {
            height: 143px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>Create/Update Profile</td>
        </tr>
        <tr>
            <td class="auto-style3">Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="188px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter your name" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Course:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlCourse" runat="server" Height="21px" Width="184px">
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCourse" runat="server" ControlToValidate="ddlCourse" ErrorMessage="Please choose a course" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">About:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtAbout" runat="server" Height="130px" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAbout" ErrorMessage="Please enter something about yourself" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Email:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter a e-mail" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter a proper e-mail" ForeColor="Red" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">External Link:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtExternalLink" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Skill set:</td>
            <td>
                <DIV style="OVERFLOW-Y:scroll; WIDTH:260px; HEIGHT:150px">
                    <asp:CheckBoxList ID="cblSkillSet" runat="server">
                    </asp:CheckBoxList>
                </DIV>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Achievements:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtAchievements" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
                <asp:ValidationSummary ID="vlsStudent" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</asp:Content>
