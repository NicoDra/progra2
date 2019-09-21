<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="General_Medicos.aspx.cs" Inherits="CapaPresentacion.General_Medicos" %>

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
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Medicos.png" />
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar Medicos" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar Medicos" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Diagnostico" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" />
    
    </div>
    </form>
</body>
</html>
