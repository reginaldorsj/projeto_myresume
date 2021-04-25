<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="MyResume.Education" %>

<%@ Register Src="~/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" runat="server">
    <uc1:MenuControl runat="server" ID="MenuControl1" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <h1 class="mb-5">
        <asp:Label ID="lblCaption" runat="server" Text=""></asp:Label></h1>
    <div class="mb-5">
        <ul class="resume-list">
            <asp:Repeater ID="rptEducation" runat="server">
                <ItemTemplate>
                    <ul class="resume-list">
                        <li>
                            <h3><%# ((MyResume.OR.Education)Container.DataItem).School %></h3>
                            <p class="date">
                                <%# ((MyResume.OR.Education)Container.DataItem).StartYear %> - <%# ((MyResume.OR.Education)Container.DataItem).EndYear %>
                            </p>
                            <p><%# ((MyResume.OR.Education)Container.DataItem).Degree %>, <%# ((MyResume.OR.Education)Container.DataItem).FieldOfStudy %></p>
                        </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
