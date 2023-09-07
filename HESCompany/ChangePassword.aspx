<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="HESCompany.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ContainerChangePasswordHead">
        <asp:Label class="ChangePasswordHead" ID="LabelChanegPasswordHead" runat="server" Text="Kullanıcı Şifre Değiştir"></asp:Label> 
    </div>

    <div class="ContainerChangePassword">
    <asp:Label class="LabelContainerChangePassword" ID="LabelEnterPassword" runat="server" Text="Mevcut Şifreyi Giriniz"></asp:Label>
    <asp:TextBox class="TextBoxContainerChangePassword" TextMode="Password"   ID="TextBoxEnterPasswordCP" runat="server"></asp:TextBox>
     </div>
      <div class="ContainerChangePassword">
     <div class="labelLogin"> <asp:Label style="color:darkred" ID="LabelUyariChangePassword" runat="server" Text="Mevcut şifrenizi yanlış girdiniz"></asp:Label></div>
    <asp:Label class="LabelContainerChangePassword" ID="LabelEnterNewPassword" runat="server" Text="Yeni Şifrenizi Giriniz"></asp:Label>
    <asp:TextBox class="TextBoxContainerChangePassword" TextMode="Password"  ID="TextBoxEnterNewPasswordCP" runat="server"></asp:TextBox>
     </div>
      <div class="ContainerChangePassword">
    <asp:Label class="LabelContainerChangePassword" ID="LabelConfirmNewPassword" runat="server" Text="Şifreyi Tekrar Giriniz"></asp:Label>
    <asp:TextBox class="TextBoxContainerChangePassword" TextMode="Password"  ID="TextBoxConfirmNewPasswordCP" runat="server"></asp:TextBox>
     </div>
    <div class="ContainerChangePasswordHead">
         <asp:Button class="ButtonContainerChangePassword" ID="Confirm" runat="server" Text="Onayla" OnClick="Confirm_Click" />
        <asp:Button class="ButtonContainerChangePassword"  ID="Cancel" runat="server" Text="Vazgeç" OnClick="Cancel_Click" />
       
         <div class="labelLogin"> <asp:Label style="color:red" ID="LabelUyariChangePasswordUyusmuyor" runat="server" Text="Yeni şifre birbiriyle uyuşmuyor!"></asp:Label></div>
        
    </div>

</asp:Content>
