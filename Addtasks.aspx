<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addtasks.aspx.cs" Inherits="pitonProject.Addtasks" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 <style type="text/css">
        .auto-style3 {
            height: 66px;
            margin-top: 0px;
        }

        .auto-style11 {
            height: 66px;
            margin-top: 0px;
            width: 100%;
        }
        .auto-style1 {
            margin-left: 211px;
            width: 1097px;
            margin-top: 0px;
        }
        
        .auto-style4 {
            height: 726px;
        }

     .auto-style12 {
         width: 1097px;
         height: 563px;
     }
     .auto-style13 {
         width: 334px;
     }
     .auto-style14 {
         width: 334px;
         height: 71px;
     }
     .auto-style15 {
         height: 71px;
     }
     .auto-style16 {
         width: 334px;
         height: 274px;
     }
     .auto-style17 {
         height: 274px;
     }

    </style>
</head>
<body style="background-color:lightgray">
    <form id="form1" runat="server"  class="auto-style4">
        <div class="auto-style3" id="div1" runat="server" style="width: 100%;background-color:deepskyblue">
            <br />
        </div>
        <div class="auto-style11" id="divColor" runat="server" style="background-color:deepskyblue">
            <div class="auto-style1" style="background-color: white">
                  <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
         
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="CategoriesName" runat="server" Font-Size="20pt" ForeColor="Black" Text="Görev Ekle"></asp:Label>

                
                  <br />
                  <br />
                  <table class="auto-style12">
                      <tr>
                          <td class="auto-style14">
                              <asp:Label ID="Label3" runat="server" Text="Konu"></asp:Label>
                          </td>
                          <td class="auto-style15">
                              <asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="452px"></asp:TextBox>
                          </td>
                          <td class="auto-style15"></td>
                      </tr>
                      <tr>
                          <td class="auto-style13">
                              <asp:Label ID="Label1" runat="server" Text="Başlangıç Tarihi"></asp:Label>
                          </td>
                          <td>
                              <asp:TextBox ID="TextBox2" runat="server" Width="452px"></asp:TextBox>
                              <ajaxToolkit:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Format="dd/MM/yyyy" BehaviorID="TextBox2_CalendarExtender" TargetControlID="TextBox2">
                              </ajaxToolkit:CalendarExtender>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style13">
                              <asp:Label ID="Label2" runat="server" Text="Bitiş Tarihi"></asp:Label>
                          </td>
                          <td>
                              <asp:TextBox ID="TextBox3" runat="server" Width="452px"></asp:TextBox>
                              <ajaxToolkit:CalendarExtender ID="TextBox3_CalendarExtender" runat="server"  Format="dd/MM/yyyy" BehaviorID="TextBox3_CalendarExtender" TargetControlID="TextBox3">
                              </ajaxToolkit:CalendarExtender>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style16">
                              <asp:Label ID="Label4" runat="server" Text="Açıklama"></asp:Label>
                          </td>
                          <td class="auto-style17">
                              <asp:TextBox ID="TextBox4" runat="server" Height="159px" TextMode="MultiLine" Width="452px"></asp:TextBox>
                          </td>
                          <td class="auto-style17"></td>
                      </tr>
                      <tr>
                          <td class="auto-style13">
                              <asp:Label ID="Label5" runat="server" Text="Hatırlatıcı Ekle"></asp:Label>
                          </td>
                          <td>
                              <asp:TextBox ID="TextBox5" runat="server" TextMode="DateTime" Width="452px"></asp:TextBox>
                              <ajaxToolkit:CalendarExtender ID="TextBox5_CalendarExtender" runat="server"  Format="dd/MM/yyyy" BehaviorID="TextBox5_CalendarExtender" TargetControlID="TextBox5">
                              </ajaxToolkit:CalendarExtender>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style13">&nbsp;</td>
                          <td>
                              <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="Kaydet" Width="135px" />
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                  </table>
                  <br />

                
                  <br />

            </div>

        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    </form>
</body>
</html>
