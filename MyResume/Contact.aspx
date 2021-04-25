<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MyResume.Contact" %>

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
        <p>
            <asp:Label ID="lblContactSummary" runat="server" Text=""></asp:Label> 
        </p>
    </div>

    <div class="row mb-4">
        <div class="col-md-12">
            <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row mb-4">
        <div class="col-md-12">
            <asp:TextBox ID="txtEmailAddress" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row mb-4">
        <div class="col-md-12">
            <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row mb-4">
        <div class="col-md-12">
            <asp:TextBox ID="txtComments" CssClass="form-control" runat="server" TextMode="MultiLine" Columns="30" Rows="10"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="bntSendMessage" runat="server" CssClass="btn btn-primary btn-block" OnClick="bntSendMessage_Click" />
        </div>
    </div>

</asp:Content>
