<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar_Especialidad.aspx.cs" Inherits="CapaPresentacion.Crear_Especialidad" %>

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
<body style="height: 514px">
    <form id="form1" runat="server">
    <div style="height: 56px">
    
        </div>
        <div align="center" style="height: 466px"> 
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Especialidades.png" />
            <br />
            <br />
        <asp:Label ID="lblnombre" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtnombreesp" runat="server" Width="99px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnombreesp" ErrorMessage="Solo Caracteres" ValidationExpression="^[A-Za-z]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnombreesp" ErrorMessage="Ingrese El Nombre" ValidationGroup="UNO">*</asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Crear Especialidad" OnClick="Button1_Click" ValidationGroup="UNO" />

&nbsp;<br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"
EnableScriptGlobalization="True" EnablePartialRendering="True">
<Scripts>
<asp:ScriptReference Name="jquery"/>
</Scripts>
</asp:ScriptManager>

        </div>
    </form>
</body>
</html>
