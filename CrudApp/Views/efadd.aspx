<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="efadd.aspx.cs" Inherits="CrudApp.Views.WebForm1" Async="True" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div class="form-group">
        <asp:label runat="server" >First Name</asp:label>
        <asp:TextBox runat="server" type="text" class="form-control" id="inputFName"  placeholder="First Name"></asp:TextBox>
   </div>
  <div class="form-group mt-2">
        <asp:label runat="server" >Last Name</asp:label>
        <asp:TextBox  runat="server" type="text" class="form-control" id="inputLName" placeholder="Last Name"></asp:TextBox>
  </div>
      <div class="form-group  mt-2">
        <asp:label runat="server">Age</asp:label>
        <asp:TextBox  runat="server" type="text" class="form-control" id="inputAge" placeholder="Age"></asp:TextBox>
  </div>
  <div class="form-group mt-4">
    <asp:Button ID="efAddSubmit" runat="server" class="btn btn-primary" Text="Submit" OnClick="efAddSubmit_Click" />
</div> 
  <%--<button type="submit"  id="efAddSubmit">Submit</button>--%>
</asp:Content>
