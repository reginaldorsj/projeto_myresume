<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuControl.ascx.cs" Inherits="MyResume.MenuControl" %>
<ul class="mb-5">
    <li runat="server" id="uliAbout"><a href="About.aspx"><%= Caption.About %></a></li>
    <li runat="server" id="uliSkills"><a href="Skills.aspx"><%= Caption.Skills %></a></li>
    <li runat="server" id="uliExperience"><a href="Experience.aspx"><%= Caption.Experience %></a></li>
    <li runat="server" id="uliEducation"><a href="Education.aspx"><%= Caption.Education %></a></li>
    <li runat="server" id="uliCertifications"><a href="Certifications.aspx"><%= Caption.Certifications %></a></li>
    <li runat="server" id="uliLanguages"><a href="Languages.aspx"><%= Caption.Languages %></a></li>
    <li runat="server" id="uliContact"><a href="Contact.aspx"><%= Caption.Contact %></a></li>
</ul>


