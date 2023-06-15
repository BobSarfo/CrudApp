<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrudApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="col">
            <section class="row" aria-labelledby="gettingStartedTitle">
               <p class="lead">Work with entity framework</p>
                <p>
                    <a class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="views/efcall">Entity Framework</a>
                </p>
            </section>
            <section class="row" aria-labelledby="librariesTitle">
                <p class="lead">work with web service calls</p>
               <p>
                    <a  class="btn btn-primary btn-md"  target="_blank" rel="noopener noreferrer" href="views/webservice.aspx">Web Services&raquo;</a>
                </p>
            </section>
          </div>
    </main>

</asp:Content>
