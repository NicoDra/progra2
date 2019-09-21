<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="General_Medicamentos.aspx.cs" Inherits="CapaPresentacion.General_Medicamentos" %>

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
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Medicamentos.png" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Alta de Medicamento" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
        <br />
    </div>
        
    </form>
</body>
</html>
