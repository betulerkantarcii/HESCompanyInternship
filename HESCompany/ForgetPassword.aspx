<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="HESCompany.ForgetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <asp:Panel ID="Panel1forgetpassword" runat="server">
        <div class="Panel1Container">
         <div class="ContainerForgetPassword"> <asp:Label class="ContainerForgetPasswordLabel2" style="color:black; font-size:20px;" ID="LabelGetID" runat="server" Text="Sicil Numaranızı Giriniz"></asp:Label> </div>     
          <div > <asp:TextBox class="TextBoxContainerChangePassword" ID="TextBoxGetID" runat="server" AutoCompleteType="Disabled"></asp:TextBox> </div>
        <div  class="ContainerForgetPassword"> <asp:Label class="ContainerForgetPasswordLabel1" ID="LabelForgetPassword" runat="server" Text="En sevdiğiniz yemek?"></asp:Label> </div>
         <div class="ContainerForgetPassword"> <asp:Label class="ContainerForgetPasswordLabel2" ID="Label2ForgetPassword" runat="server" Text="Güvenlik sorusuna cevap vererek şifrenizi değiştirebilirsiniz."></asp:Label> </div>     
        <div > <asp:TextBox class="ContainerForgetPasswordTextBox" ID="TextBoxForgetPassword" runat="server" AutoCompleteType="Disabled"></asp:TextBox> </div>
            <asp:Button class="ButtonContainerChangePassword" ID="ConfirmForgetPasswordButton" runat="server" Text="Onayla" OnClick="ConfirmForgetPasswordButton_Click"/>
            <asp:Button class="ButtonContainerChangePassword" ID="CancelForgetPasswordButton" runat="server" Text="Vazgeç" OnClick="CancelForgetPasswordButton_Click"/>
         </div>

    </asp:Panel>

    <asp:Panel ID="Panel2forgetpassword" runat="server">
        <div class="ContainerChangePassword">
    <div  class="ContainerForgetPassword"> <asp:Label class="ContainerForgetPasswordLabel1" style="margin-bottom:20px;" ID="Label1" runat="server" Text="Yeni Şifre Belirle"></asp:Label> </div>
    <asp:Label class="LabelContainerChangePassword" ID="LabelEnterNewPassword" runat="server" Text="Yeni Şifrenizi Giriniz"></asp:Label>
    <asp:TextBox class="TextBoxContainerChangePassword" TextMode="Password" ID="TextBoxEnterNewPassword" runat="server"></asp:TextBox>
     </div>
      <div class="ContainerChangePassword">
    <asp:Label class="LabelContainerChangePassword" ID="LabelConfirmNewPassword" runat="server" Text="Şifreyi Tekrar Giriniz"></asp:Label>
    <asp:TextBox class="TextBoxContainerChangePassword" TextMode="Password" ID="TextBoxConfirmNewPassword" runat="server"></asp:TextBox>
     </div>
    <div class="ContainerChangePasswordHead">
        <asp:Button class="ButtonContainerChangePassword" ID="ConfirmNewPasswordForgetP" runat="server" Text="Onayla" OnClick="ConfirmNewPasswordForgetP_Click1" />
         <asp:Button class="ButtonContainerChangePassword"  ID="CancelNewPasswordForgetP" runat="server" Text="Vazgeç" OnClick="CancelNewPasswordForgetP_Click" />
        <div class="labelLogin"> <asp:Label style="color:darkred" ID="LabelUyariForgetPassword" runat="server" Text="Şifreler birbiriyle uyuşmuyor!"></asp:Label></div>
    </div>
        

    </asp:Panel>


</asp:Content>
