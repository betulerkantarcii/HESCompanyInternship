<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="StaffInfo.aspx.cs" Inherits="HESCompany.StaffInfo" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width:97%; margin:30px 0 30px 20px;">
        <tr>
            <td style="float:left;"> <asp:Button class="ButtonPersonelInfoHome" ID="ButtonHomePage1" runat="server" Text="Ana Sayfa" OnClick="ButtonHomePage1_Click" /> </td>
            <td style="float:right;"><asp:Button class="ButtonPersonelInfoExit" ID="ButtonExitPersonelInfo" runat="server" Text="Çıkış" OnClick="ButtonExitPersonelInfo_Click" />  </td>
        </tr>
    </table>


  
    <asp:Panel ID="Panel1" runat="server">     
 
    <asp:GridView class="StaffInfoGridView" ID="GridViewStaffInfo" runat="server" AutoGenerateColumns="False" Width="90%"  BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
        <Columns>
            <asp:TemplateField HeaderText="Bölüm">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("EmployeeDepartment") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sicil No">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Personel">
                <ItemTemplate>
                    <asp:Label ID="LabelEmployeeName" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Personel Mail">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxEmployeeMail" runat="server" Text='<%# Bind("EmployeeMail") %>'></asp:TextBox>
                </EditItemTemplate>
                <ControlStyle Font-Size="14pt" />
                <ItemTemplate>
                    <asp:Label ID="LabelEmployeeMail" runat="server" Text='<%# Bind("EmployeeMail") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="12pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Yönetici">
                <ItemTemplate>
                    <asp:Label ID="LabelExecutiveName" runat="server" Text='<%# Bind("ExecutiveName") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Yönetici Mail">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxExecutiveMail" runat="server" Text='<%# Bind("ExecutiveMail") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelExecutiveMail" runat="server" Text='<%# Bind("ExecutiveMail") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giriş Saati">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("EnterPersonel") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Çıkış Saati">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("ExitPersonel") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Font-Size="14pt" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle ForeColor="#333333" BackColor="White" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>




        <table style="width:100%; margin-bottom:80px; text-align:center;">
            <tr> <td style="padding:30px 0;"> <asp:Label ID="Label3" style="font-size:30px; color:#DDD;" runat="server" Text="Giriş Çıkış Takvimi"></asp:Label> </td></tr>
            <tr> <td style="padding:10px 0;">  <asp:Button class="buttonDate" ID="Button2020" runat="server" Text="2020" OnClick="Button2020_Click" /> </td></tr>
            <tr> <td style="padding:10px 0;"> <asp:Button class="buttonDate" ID="Button2021" runat="server" Text="2021" OnClick="Button2021_Click" /> </td></tr>
            <tr> <td style="padding:10px 0;"> <asp:Button class="buttonDate" ID="Button2022" runat="server" Text="2022" OnClick="Button2022_Click" /> </td></tr>
        </table>

    </asp:Panel>


    <asp:Panel ID="Panel2" runat="server">

        <table style="width:90%; text-align:center;">
            <tr> <td style="width:10%;"> <asp:Button style="font-size:30px; font-weight:bold; border:none; background-color:#574c4f; color:#DDD" ID="ButtonGeriYear" runat="server" Text="<" OnClick="ButtonGeriYear_Click" /></td> 
                 <td style="width:80%;"> <asp:Label style="font-size:40px; color:lightseagreen;" ID="LabelYear" runat="server" Text=""></asp:Label> </td> </tr>
            <tr> <td ></td><td style=" border-top-style: solid;  border-top-color: lightseagreen; border-top-width: medium;" > </td> </tr>
            
        </table>
        <table style="width:100%; text-align:center; margin:30px 0 30px 0;">
            <tr> <td> <asp:Button class="PersonelDateStaff" ID="Button1Ocak" runat="server" Text="Ocak" OnClick="Button1Ocak_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff"  ID="Button1Subat" runat="server" Text="Şubat" OnClick="Button1Subat_Click" /> </td></tr>
            <tr> <td>  <asp:Button class="PersonelDateStaff"  ID="Button1Mart" runat="server" Text="Mart" OnClick="Button1Mart_Click" /> </td></tr>
            <tr> <td >  <asp:Button  class="PersonelDateStaff"  ID="Button1Nisan" runat="server" Text="Nisan" OnClick="Button1Nisan_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff"  ID="Button1Mayıs" runat="server" Text="Mayıs" OnClick="Button1Mayıs_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff"  ID="Button1Haziran" runat="server" Text="Haziran" OnClick="Button1Haziran_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff"  ID="Button1Temmuz" runat="server" Text="Temmuz" OnClick="Button1Temmuz_Click" /> </td></tr>
            <tr> <td>  <asp:Button class="PersonelDateStaff"  ID="Button1Agustos" runat="server" Text="Ağustos" OnClick="Button1Agustos_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff"  ID="Button1Eylül" runat="server" Text="Eylül" OnClick="Button1Eylül_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff"  ID="Button1Ekim" runat="server" Text="Ekim" OnClick="Button1Ekim_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff" ID="Button1Kasım" runat="server" Text="Kasım" OnClick="Button1Kasım_Click" /> </td></tr>
            <tr> <td> <asp:Button class="PersonelDateStaff" ID="Button1Aralık" runat="server" Text="Aralık" OnClick="Button1Aralık_Click" /> </td></tr>
        </table>
      

    </asp:Panel>

    <asp:Panel ID="Panel3" runat="server">

       <table style="width:90%; text-align:center;">
            <tr> <td style="width:10%"> <asp:Button style="font-size:30px; font-weight:bold; color:#DDD; border:none; background-color:#574c4f;" ID="ButtonGeriMonth" runat="server" Text="<" OnClick="ButtonGeriMonth_Click" /></td> <td style="width:80%;">  <asp:Label style="font-size:40px; color:lightseagreen" ID="LabelYearMonth" runat="server" Text=""></asp:Label> </td> </tr>
            <tr> <td></td><td style=" border-top-style: solid;  border-top-color: lightseagreen; border-top-width: medium;" > </td> </tr>
            
        </table>
       

        <asp:GridView class="StaffInfoGridViewDate" ID="GridViewDate" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">

            <Columns>
                <asp:TemplateField HeaderText="Gün">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("DayPersonel") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="18pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Giriş Saati">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("EnterPersonel") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="18pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Çıkış Saati">
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("ExitPersonel") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                    <HeaderStyle Font-Size="18pt" />
                </asp:TemplateField>
            </Columns>

            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />

        </asp:GridView>

    </asp:Panel>

     
</asp:Content>

