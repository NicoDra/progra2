<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Muestra_Habitacion.aspx.cs" Inherits="CapaPresentacion.Muestra_Habitacion" %>

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
<body>
    <form id="form1" runat="server">
     <div align="center" style="height: 455px">
    
         <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Habitaciones.png" />
         <br />
         <br />
    
         <asp:DropDownList ID="ddl_esp" runat="server">
         </asp:DropDownList>
         <br />
         <br />
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar" />
         <br />
         <br />
         <asp:GridView ID="GridView1" runat="server">
         </asp:GridView>
         <br />
         <br />
         <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" />
         <br />
         <br />
    
    </div>
    </form>
</body>
</html>
