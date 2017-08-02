<%@ Page Title="" Language="C#" MasterPageFile="~/VVMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductEditPage.aspx.cs" Inherits="IntelliCode.ProductEditPage" %>
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
                 
                 <asp:FileUpload ID="Upload" runat="server" />
                 
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
          <tr>
             <td class="auto-style1">
                 
            
                 
                 <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit Product" />
                 
            
                 
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
