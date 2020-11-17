<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomePageMenu.ascx.cs" Inherits="TestProject.HomePageMenu" %>
<nav class="navbar navbar-expand-md bg-dark navbar-dark">
    <a class="navbar-brand" href="HomePageMain.aspx"
        style="font-size:32px; font-weight:bold; color:#ffffff;">
        ABC Polytechnic School
    </a>
	  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#staffNavbar">
	    <span class="navbar-toggler-icon"></span>
	  </button>
    <div class="collapse navbar-collapse" id="staffNavbar">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
                <a class="nav-link" href="HomePageMain.aspx">Home</a>
            </li>

            <li class="nav-item active">
                <a class="nav-link" href="HomePageDirectorMessage.aspx">Director Message</a>
            </li>
            
            <li class="nav-item active">
                <a class="nav-link" href="HomePageStudents.aspx">Students</a>
            </li>

            <li class="nav-item active">
                <a class="nav-link" href="HomePageAbout.aspx">About</a>
            </li>
            
            <li class="nav-item">
                <a class="nav-link" href="Login.aspx">
                    <span class="fa fa-sign-in"></span>Login</a>
            </li>
        </ul>
    </div>
</nav>