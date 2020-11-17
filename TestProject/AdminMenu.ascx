<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminMenu.ascx.cs" Inherits="TestProject.AdminMenu" %>
<nav class="navbar navbar-expand-md bg-dark navbar-dark">
    <a class="navbar-brand" href="AdminMain.aspx"
        style="font-size:32px; font-weight:bold; color:#ffffff;">
        Admin Menu
    </a>
	  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#staffNavbar">
	    <span class="navbar-toggler-icon"></span>
	  </button>
    <div class="collapse navbar-collapse" id="staffNavbar">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item">
                <a class="nav-link text-white" href="AdminCreateMentor.aspx">Create Mentor Account</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="AdminCreateStudentAccount.aspx">Create Student Account</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="AdminCreateSkillSet.aspx">Create Skill Set</a>
            </li>
            
            <li class="nav-item">
                <a class="nav-link text-white" href="AdminUploadStudent.aspx">Upload Student Photo</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="AdminApproveView.aspx">Approve Viewing Request</a>
            </li>
        </ul>

        <ul class="navbar-nav ml-auto">
            <li class="nav-item">
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" CausesValidation="False" CssClass="btn btn-link nav-link" OnClick="btnLogOut_Click" />
            </li>
        </ul>
    </div>
</nav>