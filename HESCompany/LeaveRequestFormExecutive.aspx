<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="LeaveRequestFormExecutive.aspx.cs" Inherits="HESCompany.LeaveRequestFormExecutive" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width:97%; margin:30px 0 30px 20px;">
        <tr>
            <td style="float:left;"><asp:Button class="ButtonPersonelInfoHome" ID="ButtonHomePage1" runat="server" Text="Ana Sayfa" OnClick="ButtonHomePage1_Click" /> </td>
            <td style="float:right;"> <asp:Button class="ButtonPersonelInfoExit" ID="ButtonExitLRF" runat="server" Text="Çıkış" OnClick="ButtonExitLRF_Click" />  </td>
        </tr>
    </table>
     
    


    <asp:Panel ID="Panel1" style="height:500px;overflow-y:auto; scrollbar-width:none;" runat="server">
   
   
        <div style="width:100%; text-align:center; margin-bottom:20px;"> <asp:Label  style="color:#DDD; font-size:35px;" ID="Label3" runat="server" Text="İzin Başvuruları"></asp:Label> 
 </div>

      


         <div style="width:100%; margin:30px;text-align:center;">

                  <asp:TextBox style="padding:6px 18px; margin-right:20px; border-radius:5px; font-size:15px; " ID="TextBoxSearch" runat="server"></asp:TextBox>
                 <asp:Button style="padding: 8px 20px; border-radius:5px; border-style:none; background-color:#555; color:white;" ID="ButtonSearch" runat="server" Text="Ara" OnClick="ButtonSearch_Click" />

        </div>

      
       <asp:GridView class="StaffInfoGridView" ID="GridViewLRF" runat="server" AutoGenerateColumns="False" Width="90%" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="RequestID" OnRowDeleting="GridViewLRF_RowDeleting"  OnRowCommand="GridViewLRF_RowCommand" GridLines="Horizontal">
            <Columns>
                <asp:TemplateField HeaderText="İzin No" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="LabelRequestID" runat="server" Text='<%# Bind("RequestID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sicil No">
                    <ItemTemplate>
                        <asp:Label ID="LabelEmployeeID" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Personel">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Bölüm">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("EmployeeDepartment") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mail">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("EmployeeMail") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Yönetici" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("ExecutiveName") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Yönetici Mail" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("ExecutiveMail") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Türü">
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("RequestType") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Nedeni">
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("RequestReason") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Başlangıç">
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("RequestBegin") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Bitiş">
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Bind("RequestEnd") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Onaylanma Durumu">
                    <EditItemTemplate>
                        <asp:Button ID="ButtonGridOnayla" runat="server" Text="Onayla" />
                        <asp:Button ID="ButtonGridReddet" runat="server" Text="Reddet" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Bind("ApprovalStatus") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="15pt" />
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" CommandName="ButtonGridOnayla" Text="Onayla" >
                <ControlStyle BackColor="#009900" ForeColor="White" CssClass="buttonexecutiveonay" />
                </asp:ButtonField>
                <asp:ButtonField  ButtonType="Button" CommandName="ButtonGridReddet" Text="Reddet" >
                <ControlStyle BackColor="#CC0000" ForeColor="White" CssClass="buttonexecutiveonay" />
                </asp:ButtonField>
                <asp:CommandField DeleteText="Sil" ShowDeleteButton="True" >
                <ControlStyle Font-Size="15pt" />
                </asp:CommandField>
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


        <div class="space">  </div>

        </asp:Panel>
</asp:Content>
