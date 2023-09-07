<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Konferans.aspx.cs" Inherits="HESCompany.Konferans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <script>

        var sessionRoom = '<%= Session["RoomID"] %>';
        var sessionToken = '<%= Session["Token"] %>';
        var sessionName = '<%= Session["Name"] %>';

        function onVidyoClientLoaded(status) {
            console.log(status.state);
            if (status.state == "READY") {
                var vidyoConnector = VC.CreateVidyoConnector({
                    viewId: "renderer",
                    viewStyle: "VIDYO_CONNECTORVIEWSTYLE_Default",
                    remoteParticipants: 20,
                    logFileFilter: "error",
                    logFileName: "",
                    userData: ""
                }).then(function (vidyoConnector) {
                    vidyoConnector.Connect({
                        host: "prod.vidyo.io",
                        token: sessionToken,
                        displayName: sessionName,
                        resourceId: sessionRoom ,
                        onSuccess: function () {
                            console.log("Connected! YAY!");
                        },
                        onFailure: function (reason) {
                            console.log("Connection failed" + reason);
                        },
                        onDisconnected: function (reason) {
                            console.log("disconnected—" + reason);
                        }
                    }).then(function (vc) {
                        console.log("Create success");
                    }).catch(function (error) {

                    });
                })
            }
        }



      </script>


      <script src="https://static.vidyo.io/latest/javascript/VidyoClient/VidyoClient.js?onload=onVidyoClientLoaded" ></script>

        <div style="width:100%; text-align:center; margin:30px 0 30px 0">
        <asp:Button class="ButtonPersonelInfo" ID="Button1" runat="server" Text="Ofise Dön" OnClick="Button1_Click" />
        <asp:Button class="ButtonPersonelInfo"  style="margin-left:20px;" ID="Button2" runat="server" Text="Konferansı Bitir" OnClick="Button2_Click" />
        </div>
        <div style="width: 100%; height:500px; text-align:center; margin: 30px 0 30px 0" id="renderer"></div>
      

</asp:Content>
