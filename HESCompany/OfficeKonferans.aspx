<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="OfficeKonferans.aspx.cs" Inherits="HESCompany.OfficeKonferans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <table style="width:100%; padding-top:50px;">
         <tr>
            <td style="width:50%; text-align:right; ">
                  <asp:Button style="background-color:yellowgreen; color:white; margin:10px; font-size:15px; padding:10px 15px; border:none; border-radius:5px;" ID="Button3" runat="server" Text="Konferansı Başlat" OnClick="Button3_Click" /></td>
        
            <td style="width:50%; text-align:left;">
                <asp:Button style="border:none; border-radius:5px; margin:10px; background-color:dimgrey; font-size:15px; padding:10px 20px; color:white;" ID="Button2" runat="server" Text="Vazgeç" OnClick="Button2_Click" /></td>

            </tr>
    </table>

    <table style="width:100%; text-align:center;">
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
