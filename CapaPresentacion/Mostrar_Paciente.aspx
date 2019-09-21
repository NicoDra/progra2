<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar_Paciente.aspx.cs" Inherits="CapaPresentacion.Mostrar_Paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Pacientes.png" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Especialidades"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Imagenes/Actualizar.png" Width="27px" OnClick="ImageButton1_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
             height: 494px;
         }
    </style>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
