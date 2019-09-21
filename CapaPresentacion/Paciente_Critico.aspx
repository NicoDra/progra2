<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente_Critico.aspx.cs" Inherits="CapaPresentacion.Paciente_Critico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
             height: 657px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="height: 278px">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Pacientes.png" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="No Droga"></asp:Label>
&nbsp;<asp:TextBox ID="txtdroga" runat="server"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdroga" ErrorMessage="Ingrese Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sintomas"></asp:Label>
&nbsp;<asp:TextBox ID="txtsintomas" runat="server"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtsintomas" ErrorMessage="Ingresar Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Guardar" ValidationGroup="UNO" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Menu Principal" OnClick="Button1_Click" Visible="false"/>
    
    </div>
    </form>
</body>
</html>
