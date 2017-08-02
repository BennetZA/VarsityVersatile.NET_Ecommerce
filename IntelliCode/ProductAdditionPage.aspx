<%@ Page Title="" Language="C#" MasterPageFile="~/VVMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductAdditionPage.aspx.cs" Inherits="IntelliCode.ProductAdditionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        
        
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
                ProductCategory
             </td>
             <td class="auto-style1">
                 
                 <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem>Mathset</asp:ListItem>
                     <asp:ListItem>LiteratureAndArt</asp:ListItem>
                     <asp:ListItem>other</asp:ListItem>
                 </asp:DropDownList>
                 
             </td>

        </tr>
          <tr>
             <td>
                 ProductPrice
             </td>
             <td class="auto-style1">
                 
                 <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                 
             </td>

        </tr>
         <tr>
             <td class="auto-style2">
                 ProductImage
             </td>
             <td class="auto-style3">
                 
                 <br />
                 <asp:FileUpload ID="upLoad" runat="server" />
                 <br />
                 
             </td>

        </tr>
          <tr>
             <td>
                ShortDescription
             </td>
             <td class="auto-style1">
                 
                 <asp:TextBox ID="txtSdescription" runat="server"></asp:TextBox>
                 
             </td>

        </tr>
          <tr>
             <td>
               FullDescription
             </td>
             <td class="auto-style1">
                 
                 <asp:TextBox ID="txtFdescription" runat="server"></asp:TextBox>
                 
             </td>

        </tr>
          
                   </table>
      <br />
      <asp:Button ID="btnAdd" runat="server" Text="add" Width="240px" OnClick="btnAdd_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
