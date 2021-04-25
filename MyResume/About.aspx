<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MyResume.About" %>

<%@ Register Src="~/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" runat="server">
    <uc1:MenuControl runat="server" ID="MenuControl1" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">

    <asp:ImageButton ID="btnBrasil" runat="server" ImageUrl="~/img/mini_brasil.png" ToolTip="Em português" ImageAlign="AbsMiddle" OnClick="btnBrasil_Click" /><asp:ImageButton ID="btnUS" runat="server" ImageUrl="~/img/mini_us.png" ImageAlign="AbsMiddle" OnClick="btnUS_Click" ToolTip="In english" />

    <h1 class="mb-0">
        <asp:Label ID="lblGreetings" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblLastName" runat="server" Text=""></asp:Label></h1>
    <div class="mb-5">
        <p class="lead mb-3">
            <asp:Label ID="lblHeadLine" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblSummary" runat="server" Text=""></asp:Label>
            <br />
            <asp:ImageButton ID="btnDownload" runat="server" ToolTip="Donwload" ImageUrl="~/img/adobe-pdf.gif" OnClick="btnDownload_Click" ImageAlign="AbsMiddle" />
            Download
        </p>
    </div>

    <p>
        <asp:HyperLink ID="lnkFacebook" runat="server" CssClass="mr-2 mb-2" Target="_blank">Facebook</asp:HyperLink>
        <asp:HyperLink ID="lnkLinkedIn" runat="server" CssClass="mr-2 mb-2" Target="_blank">LinkedIn</asp:HyperLink>
        <asp:HyperLink ID="lnkGithub" runat="server" CssClass="mr-2 mb-2" Target="_blank">GitHub</asp:HyperLink>
    </p>
</asp:Content>
