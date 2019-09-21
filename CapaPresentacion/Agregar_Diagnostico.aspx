<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar_Diagnostico.aspx.cs" Inherits="CapaPresentacion.Agregar_Diagnostico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
            height: 455px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 363px" align="center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Diagnostico.png" />
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Agregar Diagnostico" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="26px" Text="Agregar Tratamiento" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Volver" />
    
    </div>
    </form>
</body>
</html>
