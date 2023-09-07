<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="HESCompany.Message"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <script src="Scripts/jquery-1.6.4.min.js"></script>
    <script>

        $(window).load(function () {
            var panel1 = document.getElementById('<%=Panel1.ClientID %>');
            panel1.scrollTop = panel1.scrollHeight;
        });
    </script>


   <div class='sidebarMessage'>

      
        <table style="width:100%; margin: 20px 0 30px 0" >
            <tr style="text-align:center;"> 
                <td >  <asp:Button class="ButtonPersonelInfo" style="margin:30px 0 30px 0;" ID="ButtonOffice" runat="server" Text="Ofise Dön" OnClick="ButtonOffice_Click" /></td>
                <td><asp:Button class="ButtonPersonelInfo" style="margin:30px 0 30px 0;" ID="Button1" runat="server" Text="Sohbeti Bitir" OnClick="Button1_Click" /></td>

            </tr>
        </table>
       <table style="width:100%; margin: 20px 0 30px 0">
            
            <tr style="text-align:center"><td> <asp:Label style="font-size:35px; color:yellowgreen" ID="LabelMesajHead" runat="server" Text="Label"></asp:Label> </td></tr>
            
          </table>
       <table style="width:90%;   margin: 20px 0 70px 10px">
            <tr><td> <asp:Label style="font-size:20px; color:yellowgreen;" ID="Label2" runat="server" Text="Katılımcılar"></asp:Label> </td>  </tr>
           <tr> <td style="border-top:solid;"> </td></tr>
             <tr> <td style="padding-top:10px;"><asp:Label style="font-size:20px;" ID="LabelMesajParticipants" runat="server" Text="Label"></asp:Label> </td>
            </tr>
            
           <tr> <td style="padding-bottom:20px;"> </td></tr>

            <tr><td> <asp:Label style="font-size:20px; color:yellowgreen;" ID="Label4" runat="server" Text="Sohbeti Başlatan"></asp:Label> </td>  </tr>
           <tr> <td style="border-top:solid;"> </td></tr> 
           <tr>  <td  style="padding-top:10px;"><asp:Label style="font-size: 20px;" ID="LabelMesajStarter" runat="server" Text="Label"></asp:Label> </td>
            </tr>
        </table>
     
   </div>
     <asp:Panel  ID="Panel1" runat="server" Width="900px"  Height="350px"  CssClass ="stylePanel" >
         
<asp:gridview  runat="server" ID="Gridview1" CssClass="mGrid" AutoGenerateColumns="True" ShowHeader="False" cellpadding="6" BorderStyle="None" GridLines="None" style="width:900px; height:300px; "  >
       
      
   </asp:gridview>

         </asp:Panel>
 

    <asp:TextBox style="width:700px;  font-family:Georgia; margin:30px 10px 20px 120px; height:30px;border:none; border-radius:5px; font-size:15px"  ID="TextBox1" runat="server"></asp:TextBox>

       <asp:Button class="buttonSend" runat="server"  Text="Gönder" ID="AddMessage" OnClick="AddMessage_Click" OnClientClick=""/>
       
         
 
</asp:Content>
