<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  Async="true" CodeBehind="efsearch.aspx.cs" Inherits="CrudApp.Views.efsearch" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        <section class="input-group"">
            <asp:TextBox runat="server" type="text" class="col form-control" ID="inputSearch" placeholder="Search Names"></asp:TextBox>
            <asp:Button ID="SearchButton" CssClass="mx-3 col ml-11 btn btn-sm btn-outline-info" runat="server" Text="Search" OnClick="SearchButton_Click" />
              </section>
        <asp:GridView ID="personListGrid" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
    </div>
</asp:Content>
