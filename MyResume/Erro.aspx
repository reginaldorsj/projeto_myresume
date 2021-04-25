<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true"
    CodeBehind="Erro.aspx.cs" Inherits="MyResume.Erro" %>

<%@ Register Src="~/MenuControl.ascx" TagPrefix="uc1" TagName="MenuControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" runat="server">
    <uc1:MenuControl runat="server" ID="MenuControl1" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <h1 class="mb-5">
        Internal Error</h1>
    <div class="mb-5">
        <p>
             Sorry about that. But this process is not available or something wrong. 
        </p>
    </div>
    <p class="center">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Restart</asp:HyperLink></p>
</asp:Content>
