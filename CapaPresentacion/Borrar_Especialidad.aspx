<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Borrar_Especialidad.aspx.cs" Inherits="CapaPresentacion.Borrar_Especialidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
            height: 330px;
        }
        #form1 {
            height: 418px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
       <div align="center">  <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Especialidades.png" /></div>
    <div align="center" style="height: 279px; width: 1078px">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
           <Columns>
                 <asp:CommandField SelectText="ELIMINAR" ShowSelectButton="True" />
           </Columns>
       </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
        </div>
    </form>
</body>
</html>
