<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneralEspecialidad.aspx.cs" Inherits="CapaPresentacion.GeneralEspecialidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
        }
    </style>
</head>
<body style="height: 244px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <div align="center"> 
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Especialidades.png" />
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Mostrar y Crear Especialidad" OnClick="Button1_Click" />
        <br />
        <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar una especialidad" />
            <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Volver" OnClick="Button2_Click" Width="257px" />
            </div>
    </form>
</body>
</html>
