<%@ Page Title="" Language="C#" MasterPageFile="~/VVMasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IntelliCode.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <table style="width: 203px; height: 12px; margin-left: 408px; margin-top: 93px">
         
       <tr>
          
           <td>
               <br />

               <span class="Rigister_Login"> <asp:Label  ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="Login to Your Account"></asp:Label>
                   </span>

              
               <br />
               <asp:TextBox ID="txtUsername"  runat="server" Width="261px" placeholder="Username" cssClass="input-color" Height="23px"></asp:TextBox>
               <br />
                <br />
               <asp:TextBox ID="txtPasword" textMode="Password"  runat="server" Width="261px" placeholder="Password" CssClass="input-color"  Height="23px"></asp:TextBox>
           </td>
       </tr>

       <tr>
         
           <td>
               <asp:Label ID="LoginError" Visible="false" runat="server" Font-Size="Smaller" ForeColor="Red" Text="Error Incorrect Username/Password Please Verify Your Login"></asp:Label>
               <br />
               <asp:CheckBox ID="KeepMeIn" runat="server" />
                <br />
               <asp:Label ID="Label1" runat="server" Text="Keep me signed in" style="color: #FFFFFF"></asp:Label>
           </td>
       </tr>
       <tr>
          <td> 
               <asp:Button ID="btnLogin" runat="server" Text="Sign in" Width="66px" Height="27px" OnClick="btnLogin_Click" />
              <br />
               <br />
           </td>
       </tr>
       <tr>
           <td>
               &nbsp;</td>
       </tr>
   </table>
    <br />

 
      <h1 align ="center">  &nbsp;</h1>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
