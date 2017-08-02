<%@ Page Title="" Language="C#" MasterPageFile="~/VVMasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="IntelliCode.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
 <h1 align ="center" style="color:white">  <span class="Rigister_Login" >Register Now And Acces More Content</span>   </h1>
			
     <table style="width: 308px; margin-left: 390px; margin-top: 47px">
       <tr>   
        
           <td>
               <asp:TextBox ID="txtFirstName"  runat="server" Width="261px" placeholder="First Name" cssClass="input-color" Height="23px"></asp:TextBox>
               <br />
                <br />
           </td>
       </tr>

       <tr>
         
           <td>
               <asp:TextBox ID="txtLastName"  runat="server" Width="261px" placeholder="Last Name" CssClass="input-color"  Height="23px"></asp:TextBox>
               <br />
                <br />
           </td>
       </tr>
       
       <tr>
         
           <td>
               <asp:DropDownList ID="GenderDropDown" runat="server">
                   <asp:ListItem>Select Gender</asp:ListItem>
                   <asp:ListItem>Male</asp:ListItem>
                   <asp:ListItem>Female</asp:ListItem>
               </asp:DropDownList>
               <br />
               <br />
               <asp:TextBox ID="txtUsername"  runat="server" Width="261px" placeholder="User Name" CssClass="input-color"  Height="23px"></asp:TextBox>
               <br />
                <br />
           </td>
       </tr>
       
       <tr>
         
           <td>
               <asp:TextBox ID="txtEmail"  runat="server" Width="261px" placeholder="Email Address" CssClass="input-color"  Height="23px"></asp:TextBox>
               <br />
               <br />
               <asp:TextBox ID="txtPassword" textMode="Password" runat="server" Width="261px" placeholder="New Password" CssClass="input-color"  Height="23px"></asp:TextBox>
               <br />
               <br />
               <asp:TextBox ID="txtConfirmpassword" textMode="Password"  runat="server" Width="261px" placeholder="Confirm Password" CssClass="input-color"  Height="23px"></asp:TextBox>
               <asp:Label ID="PassWordMatch"  visible="false" runat ="server" Font-Size="Smaller" ForeColor="#FF3300" Text="Error ! Password don't Match"></asp:Label>
               <br />
                <br />
           </td>
       </tr>
       <tr>
           <td>
               <asp:Button ID="btnRgister" runat="server" Height="23px" style="margin-left: 175px" Text="Sign Up" Width="91px" OnClick="btnRgister_Click" />
                <br />
                <br />
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
