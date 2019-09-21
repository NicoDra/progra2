<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_Pacientes.aspx.cs" Inherits="CapaPresentacion.Alta_Pacientes" %>

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
    <div style="height: 692px" align="center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Pacientes.png" />
    
        <br />
        <br />
        Numero De Internacion :
        <asp:Label ID="lblnumero" runat="server" Text="0"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Paciente Critico"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>SI</asp:ListItem>
            <asp:ListItem>NO</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lbldnipaciente" runat="server" Text="DNI:"></asp:Label>
    
    &nbsp;<asp:TextBox ID="txtdnipaciente" runat="server" MaxLength="8"></asp:TextBox>
    
        &nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdnipaciente" ErrorMessage="Solo Numeros" ValidationExpression="^[0-9]*" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdnipaciente" ErrorMessage="Ingrese El DNI" ValidationGroup="UNO">*</asp:RequiredFieldValidator>
    
        <br />
        <br />
        <asp:Label ID="lblnombre" runat="server" Text="Nombre: "></asp:Label>
&nbsp;<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    
        &nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="Ingrese Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="Ingrese El Nombre">*</asp:RequiredFieldValidator>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Sexo: "></asp:Label>
        <asp:DropDownList ID="LalistaMS" runat="server">
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Femenino</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
        <input id="Text1" type="date" runat="server" min ="1900/01/01" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="UNO" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar" ValidationGroup="UNO" style="height: 26px" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" />
    
    </div>
    </form>
</body>
</html>
