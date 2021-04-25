<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Skills.aspx.cs" Inherits="MyResume.Skills" %>

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
        <p>
            <asp:Label ID="lblSkillSummary" runat="server" Text=""></asp:Label> 
        </p>
    </div>
    <div class="col-md-12">
        <asp:Repeater ID="rptSkillDetails" runat="server">
            <ItemTemplate>
                <span class="progressText"><b><%# ((MyResume.OR.Skill)Container.DataItem).Name %></b></span>
                <div class="progress">
                    <div class="progress-bar progress-bar-striped progress-bar-animated bg-success" role="progressbar" style="width: <%# ((MyResume.OR.Skill)Container.DataItem).Rate %>%" aria-valuenow="<%# ((MyResume.OR.Skill)Container.DataItem).Rate %>" aria-valuemin="0" aria-valuemax="100"><%# ((MyResume.OR.Skill)Container.DataItem).Rate %>%</div>
                </div>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
