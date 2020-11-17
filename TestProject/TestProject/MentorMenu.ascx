<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MentorMenu.ascx.cs" Inherits="TestProject.MentorMenu" %>
<nav class="navbar navbar-expand-md bg-dark navbar-dark">
    <a class="navbar-brand" href="MentorMain.aspx"
        style="font-size:32px; font-weight:bold; color:#ffffff;">
        Mentor Menu
    </a>
	  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#staffNavbar">
	    <span class="navbar-toggler-icon"></span>
	  </button>
    <div class="collapse navbar-collapse" id="staffNavbar">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item">
                <a class="nav-link text-white" href="MentorApproveStudentPortfolio.aspx">Approve Students Portfolio</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="MentorPostSuggestions.aspx">Post suggestions for improvements</a>
            </li>
            
            <li class="nav-item">
                <a class="nav-link text-white" href="MentorSearch.aspx">Search for Students with a Particular Skill Set</a>
            </li>

            <li class="nav-item">
                <a class="nav-link text-white" href="MentorView.aspx">View parents messages</a>
            </li>
            
            <li class="nav-item">
                <a class="nav-link text-white" href="MentorChange.aspx">Change Password</a>
            </li>
        </ul>

        <ul class="navbar-nav ml-auto">
            <li class="nav-item">
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" CausesValidation="False" CssClass="btn btn-link nav-link" OnClick="btnLogOut_Click" />
            </li>
        </ul>
    </div>
</nav>