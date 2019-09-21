<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="CapaPresentacion.MenuPrincipal" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
            height: 785px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div align="center"> 
        <asp:Panel ID="Panel1" runat="server" Height="728px" style="margin-bottom: 38px">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/Menu Principal.png" />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/BtEspecialidad.png" OnClick="ImageButton1_Click1" style="margin-bottom: 0px" />
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Imagenes/Bthabitaciones.png" OnClick="ImageButton2_Click" />
            <br />
&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Imagenes/BtMedicos.png" OnClick="ImageButton3_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Imagenes/BtPacientes.png" OnClick="ImageButton4_Click" />
            <br />
            &nbsp;
            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Imagenes/BtMedicamentos.png" OnClick="ImageButton5_Click" />
            </div>
            <br />
            <br />
            <asp:Image ID="Image4" runat="server" ImageUrl="~/Imagenes/Gestion.png" />
            <br />
            <asp:Image ID="Image5" runat="server" ImageUrl="~/Imagenes/Clinica.png" />
        </asp:Panel>
    </form>
</body>
</html>
