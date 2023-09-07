<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="HESCompany.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <script src="Scripts/jquery-1.6.4.min.js"></script>
    <script>
        $(function () {
            $(window).unload(function () {
                var scrollPosition = $("div#element").scrollTop();
                localStorage.setItem("scrollPosition", scrollPosition);
            });
            if (localStorage.scrollPosition) {
                $("div#element").scrollTop(localStorage.getItem("scrollPosition"));
            }
        });
    </script>

 <div id="element" class='sidebar1'>

     <table style="width:100%; text-align:center; margin:30px 0 30px 0;">
         <tr>
             <td> <asp:Label style="font-size:36px; color:yellowgreen; font-weight:bold;" ID="LabelIsim" runat="server" Text=""></asp:Label> </td>
         </tr>
     </table>

     <table style="width:90%; text-align:center; margin:30px 0 30px 0;">
         <tr>
             <td style="width:10%;"> <img style="width:120px; height:100px;" src="https://media.giphy.com/media/kbR9VZqpPmd4yAsfQ6/source.gif"/> </td>
             <td style="width:80%;"> <asp:Label style="font-size:25px; color:black;" ID="Label1" runat="server" Text="Yapılacaklar Listesi"></asp:Label> </td>
         </tr>
     </table>

     
<asp:Panel ID="Panel1" style="width:100%; text-align: center; margin:30px 0 30px 0" runat="server">
   <table style="margin-bottom:30px;">
       <tr> <asp:Button class="buttonAddHome" ID="ButtonEkle" runat="server" Text="+ Ekle" OnClick ="ButtonEkle_Click"/> </tr>
   </table>


     <table  style="width:100%; text-align:center; margin: 50px 0 10px 0">
         <tr>
             <td style="width:70%; padding:5px;"> <asp:TextBox style=" float:right;  border-radius:5px; font-size:15px; " ID="TextBoxSearch" runat="server"></asp:TextBox></td>
            <td style="padding:5px;"> <asp:Button style=" float:left; border-radius:5px; border-style:none; padding:5px 10px; background-color:#555; color:white;" ID="ButtonSearch" runat="server" Text="Ara" OnClick="ButtonSearch_Click" /></td>
         </tr>
     </table> 
      
   

       
 <asp:GridView class="StaffInfoGridViewHome" ID="GridViewNote" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridViewNote_RowCancelingEdit"  OnRowEditing="GridViewNote_RowEditing" OnRowUpdating="GridViewNote_RowUpdating" DataKeyNames="NoteID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBoxNote" AutoPostBack="true" OnCheckedChanged="CheckBoxNote_Checked" runat="server" />
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="LabelNoteID" runat="server" Text='<%# Bind("NoteID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxNote" runat="server" Text='<%# Bind("Note") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelNote" runat="server" Text='<%# Bind("Note") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxTarih" runat="server" Text='<%# Bind("DateofNote") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelTarih" runat="server" Text='<%# Bind("DateofNote") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" Visible="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Update">Güncelle</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Cancel">Vazgeç</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Düzenle</asp:LinkButton>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" ForeColor="YellowGreen" />
                </asp:TemplateField>

            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>

</asp:Panel>

<asp:Panel ID="Panel2" style="margin:50px 0 30px 0" runat="server">
   <table style="width:90%; text-align: center; margin-left:20px;">
       <tr> <td style="padding-bottom:20px;"> <asp:Label style="font-size:22px;" ID="Label3" runat="server" Text="Yeni Görev Ekle"></asp:Label> </td></tr>
       <tr> <td> <asp:TextBox style= "border:none; border-radius:5px; width:90%; padding:8px 10px; font-size:17px;" ID="TextBoxNote" runat="server"></asp:TextBox> </td></tr>
   </table>
    <table style="width:90%; text-align:center; margin-left:20px; margin-top:20px">
         <tr> <td style="padding-right:10px;"> <asp:Button style="border:none; float:right; border-radius:5px; padding:10px 12px; font-size:13px; background-color:yellowgreen; color:white;  " ID="ButtonKaydet" runat="server" Text="Kaydet" OnClick ="ButtonKaydet_Click" /> </td> 
               <td style="padding-right:10px;"> <asp:Button style="border:none; float:left; border-radius:5px; padding:10px 12px; font-size:13px; background-color:#555; color:white;  " ID="ButtonVazgeç" runat="server" Text="Vazgeç" OnClick="ButtonVazgeç_Click" /></td>
       </tr>
    </table>

</asp:Panel>

 <asp:Panel ID="Panel3" runat="server">

     <table style="width:90%; text-align:center; margin:100px 0 30px 0;">
         <tr>
             <td style="width:10%;"> <img style="width:120px; height:100px;" src="https://media.giphy.com/media/kbR9VZqpPmd4yAsfQ6/source.gif"/> </td>
             <td style="width:80%;"> <asp:Label style="font-size:25px; color:black;" ID="Label2" runat="server" Text="Yapılanlar Listesi"></asp:Label> </td>
         </tr>
     </table>

     
    

     <table  style="width:100%; text-align:center; margin: 30px 0 10px 0">
         <tr>
            <td style="width:70%; padding:5px;"> <asp:TextBox style=" float:right;  border-radius:5px; font-size:15px;" ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="padding:5px;"> <asp:Button style=" float:left; border-radius:5px; border-style:none; padding:5px 10px; background-color:#555; color:white;" ID="Button4" runat="server" Text="Ara" OnClick="Button4_Click" /></td>
         </tr>
     </table> 


 <asp:GridView class="StaffInfoGridViewHome" ID="GridViewCheckedNote" runat="server" AutoGenerateColumns="False"   OnRowDeleting="GridViewCheckedNote_RowDeleting" DataKeyNames="NoteID" OnRowCommand="GridViewCheckedNote_RowCommand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:TemplateField ShowHeader="False" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="LabelCheckedNoteID" runat="server" Text='<%# Bind("NoteID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                   
                    <ItemTemplate>
                        <asp:Label ID="LabelCheckedNote" runat="server" Text='<%# Bind("Note") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                   
                    <ItemTemplate>
                        <asp:Label ID="LabelCheckedTarih" runat="server" Text='<%# Bind("DateofNote") %>'></asp:Label>
                    </ItemTemplate>

                    <ControlStyle Font-Size="15pt" />

                </asp:TemplateField>
                <asp:ButtonField CommandName="ButtonGridGeriEkle" Text="Geri Ekle" >
                <ControlStyle Font-Size="15pt" ForeColor="YellowGreen" />
                </asp:ButtonField>
                <asp:CommandField ShowDeleteButton="True" >
                <ControlStyle Font-Size="15pt" ForeColor="Black" />
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
</asp:GridView>

     <div style="margin-bottom:50px;"></div>



     </asp:Panel>

 </div>



  <div class='sidebar'>
    
         <table class="HomeTable">

             <tr>
                 <td>
                     <header  class="Homekullanici">
        <asp:LinkButton style="font-size: 22px;  color:yellowgreen;" class="Homekullanici" ID="LinkButtonHomeKullanici" runat="server" OnClick="LinkButtonHomeKullanici_Click">Kullanıcı şifre değiştir</asp:LinkButton>
        <br />
        <asp:LinkButton style=" font-size: 22px; padding-right:10px; color:darkred;" class="Homekullanici" ID="LinkButtonCikis" runat="server" OnClick="LinkButtonCikis_Click">Çıkış Yap</asp:LinkButton> 
    </header>
                 </td>
             </tr>

             <tr >
                 <td>
                     <img class="imgHome" src="https://media.giphy.com/media/RGRzxETrRFHbiWwtiR/source.gif" alt="Personel Kayıt" />
                 </td>


             </tr>

             <tr>

                  <td>
                     <asp:Button class="btnHome" id="Button1" runat="server" Text="Personel Giriş-Çıkış Bilgileri" Width="250px" OnClick="ButtonPersonelKayit_Click"  />
                 </td>

                

             </tr>

             <tr>
                  <td>
                    <img class="imgHome" style="width:150px; height:150px" src="https://media.giphy.com/media/XGy1O2nALj8D47Qkvd/source.gif" alt="İzin Belgesi" /> 
                 </td>

                 

             </tr>

             <tr>
                  <td>
                     <asp:Button class="btnHome" id="Button2" runat="server" Text="İzin Belgesi" Width="230px" OnClick="ButtonİzinBelgesi_Click"  />
                 </td>
             </tr>


         </table>

</div>


<div style=" text-align:center">

    <asp:Button class="ButtonHESHome" ID="ButtonOfis" runat="server"  OnClick="ButtonOfis_Click" />
</div>
   
</asp:Content>
