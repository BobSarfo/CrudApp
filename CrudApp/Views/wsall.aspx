<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  Async="true" CodeBehind="wsall.aspx.cs" Inherits="CrudApp.Views.wsall" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
        <div>
            <p>
                List of Persons
            </p>
            <asp:GridView ID="personListGrid" runat="server" AutoGenerateColumns="false" OnRowCommand="personListGrid_RowCommand">
                <Columns>                  
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                      <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="DeleteButton" CssClass="btn btn-sm btn-outline-danger" runat="server" Text="Delete" CommandName="DeletePerson" CommandArgument='<%# Eval("Id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>