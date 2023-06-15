﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="efmain.aspx.cs" Inherits="CrudApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <section>
     <p class="lead">Work with entity framework</p>
     <div class="input-group">
         <div class="col-3">
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efadd">Add</a>
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efsearch">Search</a>
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efall">List</a>
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="efall">Delete</a>
         </div>
     </div>
 </section>
</asp:Content>
