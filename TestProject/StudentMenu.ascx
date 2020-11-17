<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentMenu.ascx.cs" Inherits="TestProject.StudentMenu" %>
<nav class="navbar navbar-expand-md bg-dark navbar-dark">
    <a class="navbar-brand" href="StudentMain.aspx"
        style="font-size:32px; font-weight:bold; color:#ffffff;">
        Student Menu
    </a>
	  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#staffNavbar">
	    <span class="navbar-toggler-icon"></span>
	  </button>
    <div class="collapse navbar-collapse" id="staffNavbar">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item">
                <a class="nav-link text-white" href="StudentEditProfile.aspx">Edit Profile</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="StudentProjects.aspx">View Projects</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="StudentAcknowledge.aspx">Acknowledge sugguestions</a>
            </li>
        </ul>

        <ul class="navbar-nav ml-auto">
            <li class="nav-item">
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" CausesValidation="False" CssClass="btn btn-link nav-link" OnClick="btnLogOut_Click" />
            </li>
        </ul>
    </div>
</nav>