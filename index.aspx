<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="pitonProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        .div1{
            border-color:black;
            background-color:lightgray;
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
           <asp:Label ID="CategoriesName" runat="server" Font-Size="20pt" ForeColor="Black" Text="Görev Listesi"></asp:Label>

                  <br />
                  <asp:Label ID="Label1" runat="server" Text="Lütfen Kategori Seçiniz"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:DropDownList ID="DropDownList1" runat="server" Width="347px" AutoPostBack="True" >
                       <asp:ListItem Value="Günlük">Günlük </asp:ListItem>
                  <asp:ListItem Value="Haftalık">Haftalık </asp:ListItem>
                  <asp:ListItem Value="Aylık">Aylık </asp:ListItem>
                  <asp:ListItem Value="Hepsi">Hepsi </asp:ListItem>
                  </asp:DropDownList>
                  <br />
                  <asp:Table ID="Table1" runat="server" Width="1097px">
                      <asp:TableRow>
                          <asp:TableCell ID="cell">

                           </asp:TableCell>
                      </asp:TableRow>
                  </asp:Table>
                  <br />

            </div>

        </div>

    </form>
</body>
</html>
