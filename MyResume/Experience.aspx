<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Experience.aspx.cs" Inherits="MyResume.Experience" %>

<%@ Register Src="~/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" runat="server">
    <uc1:MenuControl runat="server" ID="MenuControl1" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <h1 class="mb-0">
        <asp:Label ID="lblCaption" runat="server" Text=""></asp:Label></h1>
    <div class="mb-5">
        <ul class="resume-list">
            <asp:Repeater ID="rptExperience" runat="server">
                <ItemTemplate>
                    <li>
                        <h3>
                            <%# ((MyResume.OR.Experience)Container.DataItem).Title %>, <%# ((MyResume.OR.Experience)Container.DataItem).Company %></h3>
                        <p class="date">
                            <%# MyResume.LetterOfMonth.Get(((MyResume.OR.Experience)Container.DataItem).StartMonth, Session["Idiom"].ToString()) %> <%# ((MyResume.OR.Experience)Container.DataItem).StartYear %> - <%# MyResume.LetterOfMonth.Get(((MyResume.OR.Experience)Container.DataItem).EndMonth, Session["Idiom"].ToString()) %> <%# ((MyResume.OR.Experience)Container.DataItem).EndYear %>
                            <br />
                            <%# ((MyResume.OR.Experience)Container.DataItem).Location %>
                        </p>
                        <p>
                            <%# ((MyResume.OR.Experience)Container.DataItem).Description %>
                        </p>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
