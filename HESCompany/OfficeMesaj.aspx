<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="OfficeMesaj.aspx.cs" Inherits="HESCompany.OfficeMesaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width:100%; text-align:center;">
        <tr> <td style="padding:10px 0 10px 0"> <asp:Label style=" font-size:30px; color:#DDD;" ID="LabelMesajHead" runat="server" Text="Sohbet Konusu"></asp:Label></td></tr>
        <tr> <td> <asp:TextBox style="border-radius:3px; border:none; width:300px; padding:5px 10px; font-size:15px;" ID="TextBoxMesajHead" runat="server"></asp:TextBox></td></tr>
    </table>

    <table style="width:100%;">
         <tr>
            <td style="width:50%; text-align:right; ">
                  <asp:Button style="background-color:yellowgreen; color:white; margin:10px; font-size:15px; padding:10px 15px; border:none; border-radius:5px;" ID="Button3" runat="server" Text="Sohbeti Başlat" OnClick="Button3_Click" /></td>
        
            <td style="width:50%; text-align:left;">
                <asp:Button style="border:none; border-radius:5px; margin:10px; background-color:dimgrey; color:white; font-size:15px; padding:10px 20px;" ID="Button2" runat="server" Text="Vazgeç" OnClick="Button2_Click" /></td>

            </tr>
    </table>

    <table style="width:100%; text-align:center; margin:20px;">
        <tr>
            <td>
                <asp:Label style="font-size:20px;" ID="LabelChoose" runat="server" Text="En az bir kişi seçin!"></asp:Label></td>
        </tr>
    </table>

    <table style="width:95%;  margin-top:60px;">
        <tr>
            <td>
                <asp:CheckBox style=" float:right; color:#DDD; font-size:25px;" ID="cbAllKonferans" runat="server" Text="Hepsini Seç" OnCheckedChanged="cbAllKonferans_CheckedChanged" AutoPostBack="true"/></td>
        </tr>
    </table>


</asp:Content>
