<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="OfficeKonferansAnother.aspx.cs" Inherits="HESCompany.OfficeKonferansAnother" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table style="width:100%; text-align:center; margin:20px;">
        <tr>
            <td>
                <asp:Label style="font-size:20px;" ID="LabelChoose" runat="server" Text="En az bir kişi seçin!"></asp:Label></td>
        </tr>
    </table>


    <table style="width:100%;">
         <tr>
            <td style="width:50%; text-align:right; ">
                  <asp:Button style="background-color:yellowgreen; color:white; margin:10px; font-size:15px; padding:10px 15px; border:none; border-radius:5px;" ID="Button8" runat="server" Text="Konferansı Başlat" OnClick="Button3_Click" /></td>
        
            <td style="width:50%; text-align:left;">
                <asp:Button style="border:none; border-radius:5px; margin:10px; background-color:dimgrey; color:white; font-size:15px; padding:10px 20px;" ID="Button9" runat="server" Text="Vazgeç" OnClick="Button2_Click" /></td>

            </tr>
    </table>


    <table style="width:30%; margin:20px; margin-left:450px; margin-top:100px; text-align:center;">
        <tr> 
            <td style="padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button2" runat="server" Text=">"  /></td>
            <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label1" runat="server" Text="İnsan Kaynakları"></asp:Label></td>
            </tr>
    </table>

    <asp:Panel ID="Panel1" runat="server">
      <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxIK" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxIK_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>

    <table style="width:30%; margin:20px; margin-left:450px;">
        <tr> 
            <td style="padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button3" runat="server" Text=">" /></td>
            <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label2" runat="server" Text="Muhasebe"></asp:Label></td>
            </tr>
    </table >

    <asp:Panel ID="Panel2" runat="server">
        <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxM" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxM_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>

    <table style="width:30%; margin:20px; margin-left:450px;">
        <tr> 
            <td style="padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button4" runat="server" Text=">" /></td>
            <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label3" runat="server" Text="Pazarlama"></asp:Label></td>
            </tr>
    </table>

    <asp:Panel ID="Panel3" runat="server">
        <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxP" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxP_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>

    <table style="width:30%; margin:20px; margin-left:450px; text-align:center;">
        <tr> 
           <td style="padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button5" runat="server" Text=">"  /></td>
            <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label4" runat="server" Text="Yurt İçi Ticaret"></asp:Label></td>
        </tr>
    </table>

    <asp:Panel ID="Panel4" runat="server">
        <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxYI" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxYI_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>

    <table style="width:30%; margin:20px; margin-left:450px; text-align:center;">
        <tr> 
           <td style="padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button6" runat="server" Text=">" /></td>
           <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label5" runat="server" Text="Yurt Dışı Ticaret"></asp:Label></td>
            
        </tr>
    </table>

    <asp:Panel ID="Panel5" runat="server">
        <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxYD" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxYD_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>

    <table style="width:30%; margin:20px; margin-left:450px;">
        <tr> 
           <td style="padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button7" runat="server" Text=">"  /></td>
           <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label6" runat="server" Text="Bilgi İşlem"></asp:Label></td>
            
        </tr>
    </table>

    <asp:Panel ID="Panel6" runat="server">
        <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxBI" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxBI_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>

    <table style="width:30%; margin:20px; margin-left:450px; text-align:center;">
        <tr> 
            <td style="width:10%; padding:10px;"><asp:Button style="font-size:40px; border:none; background-color:#574c4f;" ID="Button1" runat="server" Text=">"  /></td>
            <td style="padding:20px;"><asp:Label style="font-size:40px; color:#DDD" ID="Label7" runat="server" Text="Genel Müdürlük"></asp:Label></td>
            
        </tr>
    </table>

    <asp:Panel ID="Panel7" runat="server">
        <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="CheckBoxGM" runat="server" Text="Hepsini Seç" OnCheckedChanged="CheckBoxGM_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>
    </asp:Panel>


</asp:Content>
