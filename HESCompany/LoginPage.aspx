<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="HESCompany.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <div class="loginContainer"> 
<div> <img  class="imgLogin" src="Login.png" alt="üye" /> </div>
 <div  class="labelLogin"> <asp:Label ID="LabelSicilNo" runat="server" Text="Sicil Numarası"></asp:Label> </div>
<div>  <asp:TextBox class="textBoxLogin" ID="TextBoxusername" runat="server" AutoCompleteType="Disabled"></asp:TextBox> </div>
<div  class="labelLogin"> <asp:Label ID="LabelSifre" runat="server" Text="Şifre"></asp:Label> </div>
<div >  <asp:TextBox class="textBoxLogin" ID="TextBoxpassword" TextMode="Password" runat="server"></asp:TextBox> </div>
<div >  <asp:Button class="buttonLogin" ID="Buttonlogin" runat="server" Text="Giriş" OnClick="Buttonlogin_Click" /> </div>
    <div class="labelLogin"> <asp:Label style="color:darkred" ID="LabelUyari" runat="server" Text="Sicil numaranızı ya da şifrenizi yanlış girdiniz!"></asp:Label></div>
<div  class="labelLoginSifre"> <asp:LinkButton  style="color:lightseagreen;" ID="LinkSifreUnuttum" runat="server" OnClick="LinkSifreUnuttum_Click"> Şifremi Unuttum? </asp:LinkButton> </div>
 </div>

</asp:Content>
