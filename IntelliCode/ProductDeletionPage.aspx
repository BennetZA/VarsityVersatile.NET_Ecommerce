<%@ Page Title="" Language="C#" MasterPageFile="~/VVMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDeletionPage.aspx.cs" Inherits="IntelliCode.ProductDeletionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
  
            <tr>
             <td>
               ProductID
             </td>
             <td class="auto-style1">
                 
                 <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                 </td>
                 
             </tr>
          <tr>
             <td>
               ProductName
             </td>
             <td class="auto-style1">
                 
                 <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                 
             </td>

        
        </tr>
          <tr>
              <td>
                  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Remove Product" />
                  </td>
              </tr>
      </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
