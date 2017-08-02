<%@ Page Title="" Language="C#" MasterPageFile="~/VVMasterPage.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="IntelliCode.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br/><br/>
    
    <br/><br/>

      <div id="innerCart" runat ="server"></div>
    <asp:Button ID="cmdUpdate" runat="server" Text="Update Quantities" style="margin-left: 602px" Width="141px" OnClick="cmdUpdate_Click" />
    <div align="right" id="CartLink" runat ="server"></div>
 

        <br/><br/>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
