<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Office.aspx.cs" Inherits="HESCompany.Office" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width:97%; margin:30px 0 30px 20px;">
        <tr>
            <td style="float:left;"> <asp:Button class="ButtonPersonelInfoHome" ID="ButtonHomePage1" runat="server" Text="Ana Sayfa" OnClick="ButtonHomePage1_Click" />  </td>
            <td style="float:right;">  <asp:Button class="ButtonPersonelInfoExit" ID="ButtonExitLRF" runat="server" Text="Çıkış" OnClick="ButtonExitLRF_Click" /> </td>
        </tr>
    </table>


<asp:Panel ID="Panel1" class='sidebarOffice' runat="server">

<asp:Panel style="margin-bottom:80px; width:90%;" ID="PanelKonferans" runat="server">

    
    <table style=" width:100%; text-align:center; margin:30px 0 30px 0; ">
       <tr>
            <td> <asp:Label style="font-size:30px;" ID="LabelKonferans" runat="server" Text="Video Konferans"></asp:Label></td>
        </tr>
        <tr> <td style="border-top-style: solid; border-top-color: inherit; border-top-width: medium;" class="auto-style3"> </td></tr>
    </table>

           <table style="width:100%; text-align:center; margin-bottom:30px;">
        <tr>
            <td>
                <asp:Button style="border-radius:5px; padding:7px; background-color: #574c4f; color:white;" ID="ButtonKonferans" runat="server" Text="+ Yeni Konferans Oluştur" OnClick="ButtonKonferans_Click" />
            </td> 
        </tr>
    </table >  

 <asp:Panel ID="PanelKonferansEkle" runat="server" style="width:90%; border:solid 3px; border-radius:5px; margin:30px 0 30px 0;">
<table style="width:100%; text-align:center;">
        <tr>
            <td> <asp:Button style="float:right; border:none; background-color:red; color:white; border-radius:90%;" ID="ButtonCancelKonferans" runat="server" Text="X" OnClick="ButtonCancelKonferans_Click1"/> </td>
        </tr>
        <tr>
            <td>
                <asp:Label style="font-size:20px;" ID="LabelButtonKonferans" runat="server" Text="Yeni Video Konferans"></asp:Label>
            </td>
        </tr>
 </table>

<table style="width:100%; text-align:center; margin:20px 0 20px 0">
        <tr>
            <td style="width:50%;">
                <asp:Button style="background-color:#574c4f; font-size:15px; border:none; border-radius:5px; padding:5px; color:white;" ID="ButtonCurrentDepartment" runat="server" Text="Bu Departman" OnClick="ButtonCurrentDepartment_Click" /> </td>
            <td style="width:50%;">
                <asp:Button style="background-color:#574c4f; font-size:15px; border:none; border-radius:5px; padding:5px; color:white;" ID="ButtonAnotherDepartment" runat="server" Text="Tüm Departmanlar" OnClick="ButtonAnotherDepartment_Click" /> </td>
        </tr>
 </table>

</asp:Panel>

         <asp:GridView ID="GridView1" runat="server" Width="97%" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
            <Columns>
                <asp:TemplateField Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="LabelConferenceID" runat="server" Text='<%# Bind("ConferenceID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Konferans İsteği">
                    <ItemTemplate>
                        <asp:Label  ID="Label1" runat="server" Text='<%# Bind("ConferenceRequest") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Katılımcılar">
                    <ItemTemplate>
                        <asp:Label  ID="Label2" runat="server" Text='<%# Bind("ConferenceSend") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" Text="Katıl" CommandName="Join" >
                <ControlStyle CssClass="buttonOfficeCss" Font-Size="11pt" />
                <HeaderStyle Font-Size="13pt" />
                </asp:ButtonField>
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




 <asp:Panel ID="PanelMesaj" runat="server" style="width:90%;">

      <table style=" width:100%; text-align:center; margin:50px 0 30px 0">
       <tr>
            <td> <asp:Label style="font-size:30px;" ID="LabelMesaj" runat="server" Text="Sohbet"></asp:Label></td>
        </tr>
          <tr> <td style="border-top:solid; width:100%; "> </td> </tr>
        </table>



 <table style=" width:100%; text-align:center; margin-bottom:30px;">
         <tr>
            <td> <asp:Button style="border-radius:5px; padding:7px; background-color: #574c4f; color:white;" ID="ButtonMesaj" runat="server" Text="+ Yeni Sohbet Oluştur" OnClick="ButtonMesaj_Click" />
            </td>
        </tr>
    </table>


 <asp:Panel ID="PanelMesajEkle" runat="server" style="width:90%; border:solid 3px; border-radius:5px; margin:30px 0 30px 0;">

     <table style="width:100%; text-align:center;">
        <tr>
            <td> <asp:Button style="float:right; border:none; background-color:red; color:white; border-radius:90%;" ID="ButtonCancelMesaj" runat="server" Text="X" OnClick="ButtonCancelMesaj_Click"/> </td>
        </tr>
        <tr>
            <td>
                <asp:Label style="font-size:20px;" ID="Label3" runat="server" Text="Yeni Sohbet"></asp:Label>
            </td>
        </tr>
 </table>

<table style="width:100%; text-align:center; margin:20px 0 20px 0">
        <tr>
            <td style="width:50%;">
                <asp:Button style="background-color:#574c4f; font-size:15px; border-radius:5px; padding:5px; border:none; color:white;" ID="ButtonCurrentDMesaj" runat="server" Text="Bu Departman" OnClick="ButtonCurrentDMesaj_Click" /> </td>
            <td style="width:50%;">
                <asp:Button style="background-color:#574c4f; font-size:15px; border-radius:5px; padding:5px; border:none; color:white;" ID="ButtonAnotherDMesaj" runat="server" Text="Tüm Depertmanlar" OnClick="ButtonAnotherDMesaj_Click" /> </td>
        </tr>
 </table>

  
    </asp:Panel >

     <asp:Panel ID="Panel2" style="width:100%; margin-bottom:50px;" runat="server">

        <asp:GridView ID="GridView2" runat="server"  Width="97%" AutoGenerateColumns="False" OnRowDataBound="GridView2_RowDataBound" DataKeyNames="RoomID" OnRowCommand="GridView2_RowCommand1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >

            <Columns>
                <asp:TemplateField Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="LabelRoomID" runat="server" Text='<%# Bind("RoomID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Konu">
                    <ItemTemplate>
                        <asp:Label ID="LabelKonu" runat="server" Text='<%# Bind("MessageHead") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sohbet İsteği">
                    <ItemTemplate>
                        <asp:Label ID="LabelEmployeeName" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Katılımcılar">
                    <ItemTemplate>
                        <asp:Label ID="LabelParticipants" runat="server" Text='<%# Bind("Participants") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="13pt" />
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" CommandName="SohbeteGir" Text="Sohbete Gir" >
                <ControlStyle CssClass="SohbetGrid" Font-Size="11pt" />
                <HeaderStyle Font-Size="13pt" />
                </asp:ButtonField>
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

</asp:Panel>

 </asp:Panel>



     

</asp:Content>
