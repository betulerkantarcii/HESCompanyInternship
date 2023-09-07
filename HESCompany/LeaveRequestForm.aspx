<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" MaintainScrollPositionOnPostback="true"  AutoEventWireup="true" CodeBehind="LeaveRequestForm.aspx.cs" Inherits="HESCompany.LeaveRequestForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <table style="width:97%; margin:30px 0 30px 20px; " >
        <tr>
         <td style="float:left;"> <asp:Button class="ButtonPersonelInfoHome" ID="ButtonHomePage1" runat="server" Text="Ana Sayfa" OnClick="ButtonHomePage1_Click" />  </td> 
         <td style="float:right"> <asp:Button class="ButtonPersonelInfoExit" ID="ButtonExitLRF" runat="server" Text="Çıkış" OnClick="ButtonExitLRF_Click" /> </td>
        </tr>
        </table>

    <div class="LRFPage">


        <div style="width:100%; text-align:center; margin-bottom:20px;"> <asp:Label  style="color:#DDD; font-size:30px;" ID="LabelLRFExistingRequest" runat="server" Text="Oluşturulan İzin Başvuruları"></asp:Label> 
 </div>

      


         <div style="width:100%; margin:30px;text-align:center;">

                  <asp:TextBox style="padding:6px 18px; margin-right:20px; border-radius:5px; font-size:15px; " ID="TextBoxSearch" runat="server"></asp:TextBox>
                 <asp:Button style="padding: 8px 20px; border-radius:5px; border-style:none; background-color:#555; color:white;" ID="ButtonSearch" runat="server" Text="Ara" OnClick="ButtonSearch_Click" />

        </div>
       
       <asp:GridView class="StaffInfoGridViewLRF" ID="GridViewLRF" runat="server" AutoGenerateColumns="False" Width="90%" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" OnRowCancelingEdit="GridViewLRF_RowCancelingEdit" OnRowEditing="GridViewLRF_RowEditing" OnRowUpdating="GridViewLRF_RowUpdating" OnRowDeleting="GridViewLRF_RowDeleting" DataKeyNames="RequestID" GridLines="Horizontal">
            <Columns>
                <asp:TemplateField HeaderText="İzin No" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="LabelRequestID" runat="server" Text='<%# Bind("RequestID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sicil No" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Personel" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Bölüm" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("EmployeeDepartment") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mail" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("EmployeeMail") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Yönetici" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("ExecutiveName") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Yönetici Mail" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("ExecutiveMail") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Türü">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxRequestType" runat="server" Text='<%# Bind("RequestType") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("RequestType") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Nedeni">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxRequestReason" runat="server" Text='<%# Bind("RequestReason") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("RequestReason") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Başlangıç">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxRequestBegin" runat="server" Text='<%# Bind("RequestBegin") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("RequestBegin") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="İzin Bitiş">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxRequestEnd" runat="server" Text='<%# Bind("RequestEnd") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Bind("RequestEnd") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Onaylanma Durumu">
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Bind("ApprovalStatus") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Update">Güncelle</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Cancel">Vazgeç</asp:LinkButton>
                    </EditItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Düzenle</asp:LinkButton>
                    </ItemTemplate>
                    <ControlStyle Font-Size="14pt" />
                </asp:TemplateField>
                <asp:CommandField DeleteText="Sil" ShowDeleteButton="True" >
                <ControlStyle Font-Size="14pt" />
                </asp:CommandField>
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

        <div class="space" > </div>

          <div style="width:100%; text-align:center;"> 
              <asp:Label style="color:#DDD; font-size:30px;" ID="Label13" runat="server" Text="Yeni izin Başvurusu"></asp:Label> 
        </div>
      


        <table style="width:100%; text-align:center; margin-top:30px;">

             <tr>  <td style="text-align:center; color:darkred; font-size:20px;"> <asp:Label ID="LabelEmptyID" runat="server" Text="Sicil Numaranızı Giriniz!"></asp:Label></td></tr>
   
        </table>

  <table class="LRFTable">

        <tr>
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" runat="server" Text="Sicil Numarası"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" ID ="TextBoxLRFID" runat="server" AutoPostBack="true" OnTextChanged="TextBoxLRFID_TextChanged" ></asp:TextBox> </td>
       
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" runat="server" Text="Ad-Soyad"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" ID ="TextBoxLRFName" runat="server"></asp:TextBox> </td>

       
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" runat="server" Text="Departman"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" ID ="TextBoxLRFDepatment" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" runat="server" Text="E-mail"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" ID ="TextBoxLRFMail" runat="server"></asp:TextBox> </td>
       
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" runat="server" Text="Yönetici"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" ID ="TextBoxLRFExecutive" runat="server"></asp:TextBox> </td>
        </tr>
      </table>


<asp:Panel ID="Panel1" style="margin-bottom:80px;" runat="server">

    <table class="LRFTable">

        <tr> <td  class="LRFTableTD"> <asp:Label class="LabelLRF" ID="LabelLRFType" runat="server" Text="İzin Türü"></asp:Label></td>
         <td class="LRFTableTD" > <asp:CheckBox   class= "CheckBoxLRF" style="font-size:25px; color:#DDD" ID="CheckBoxLRF1" runat="server" Text="Yıllık İzin" OnCheckedChanged="CheckBoxLRF1_CheckedChanged" AutoPostBack="true" /> </td>
         <td class="LRFTableTD"> <asp:CheckBox  class= "CheckBoxLRF" style="font-size:25px; color:#DDD" ID="CheckBoxLRF2" runat="server" Text="Doğum İzni" OnCheckedChanged="CheckBoxLRF2_CheckedChanged" AutoPostBack="true" /></td>
         <td class="LRFTableTD"> <asp:CheckBox  class= "CheckBoxLRF" style="font-size:25px; color:#DDD" ID="CheckBoxLRF3" runat="server" Text="Ölüm İzni" OnCheckedChanged="CheckBoxLRF3_CheckedChanged" AutoPostBack="true"/></td>
         <td class="LRFTableTD"> <asp:CheckBox  class= "CheckBoxLRF" style="font-size:25px; color:#DDD" ID="CheckBoxLRF4" runat="server" Text="Mazeret İzni" OnCheckedChanged="CheckBoxLRF4_CheckedChanged" AutoPostBack="true"/> </td>
          <td class="LRFTableTD"> <asp:CheckBox  class= "CheckBoxLRF" style="font-size:25px; color:#DDD" ID="CheckBoxLRF5" runat="server" Text="Evlenme İzni" OnCheckedChanged="CheckBoxLRF5_CheckedChanged"  AutoPostBack="true"/> </td>
          <td class="LRFTableTD"> <asp:CheckBox  class= "CheckBoxLRF" style="font-size:25px; color:#DDD" ID="CheckBoxLRF6" runat="server" Text="Hastalık İzni" OnCheckedChanged="CheckBoxLRF6_CheckedChanged"  AutoPostBack="true"/> </td>
       </tr>

     </table>


            </asp:Panel>

 

  <asp:Panel ID="Panel2" runat="server">

    <table style="width:100%; text-align:center;">


         <tr>

            <td class="LRFTableTD" >
                <asp:Label class="LabelLRF" style="float:right;" ID="LabelReason" runat="server" Text="İzin Türü"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" ID="LabelReasonAns" style="float:left; color:#DDD" runat="server" ></asp:Label> </td>
        </tr>

        <tr>

            <td class="LRFTableTD">
                <asp:Label class="LabelLRF" style="float:right;" ID="LabelIzinNedeni1" runat="server" Text="Açıklama"></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" style="float:left;"  ID="TextBoxLRFSebep1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" style="float:right;" ID="LabelTarih1" runat="server" Text="İzin Başlangıç Tarihi"></asp:Label></td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" style="float:left;" ID="TextBoxLRFTarih1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="LRFTableTD"> <asp:Label class="LabelLRF" style="float:right;" ID="LabelTo1" runat="server" Text=" İzin Bitiş Tarihi "></asp:Label> </td>
            <td class="LRFTableTD"> <asp:TextBox class= "TextBoxLRF" style="float:left;" ID="TextBoxLRFTarih1Till" runat="server"></asp:TextBox></td>
        </tr>
            </table>
        <table style=" width:100%; text-align:center;">
        <tr><td style="text-align:center; color:darkred; font-size:20px"> <asp:Label ID="LabelHata1" runat="server" Text="Tüm alanları doldurunuz!"></asp:Label></td></tr>
        </table>
        <table style="width:100%; text-align:center;">
         <tr> <td style="padding-right:10px;"> <asp:Button class="ButtonLRF" style="float:right;" ID="ButtonLRFSave1" runat="server" Text="Kaydet" OnClick="ButtonLRFSave1_Click" /></td> 
              <td style="padding-left:10px;"> <asp:Button class="ButtonLRF" style="float:left;" ID="ButtonLRFCancel" runat="server" Text="Vazgeç" OnClick="ButtonLRFCancel_Click" /> </td> </tr>
        </table>

   </asp:Panel>
     
      <div class="space"></div>
       
</div>
</asp:Content>
