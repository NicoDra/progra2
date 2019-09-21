<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="General_Habitaciones.aspx.cs" Inherits="CapaPresentacion.General_Habitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
             height: 494px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Habitaciones.png" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Alta de Habitacion" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Mostrar Habitaciones" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Volver" OnClick="Button4_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
