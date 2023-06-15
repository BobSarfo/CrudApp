<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webmain.aspx.cs" Inherits="CrudApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
 <section>
    <p class="lead">Work with Web Services</p>
    <div class="input-group">
        <div class="col-3">
        <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="wsadd">Add</a>
        <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="wssearch">Search</a>
        <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="wsall">List</a>
        <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="wsall">Delete</a>
        </div>
    </div>
 </section>
    
</asp:Content>
