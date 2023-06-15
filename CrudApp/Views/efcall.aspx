﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="efcall.aspx.cs" Inherits="CrudApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <section>
     <p class="lead">Work with entity framework</p>
     <div class="row">
         <div class="col-3">
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efadd">Add</a>
         </div>
         <div class="col-3">
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efcall">Search</a>
         </div>
         <div class="col-3">
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efcall">List</a>
         </div>
         <div class="col-3">
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efcall">Delete</a>
         </div>
     </div>
 </section>
</asp:Content>
