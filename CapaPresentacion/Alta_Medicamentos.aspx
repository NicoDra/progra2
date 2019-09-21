<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_Medicamentos.aspx.cs" Inherits="CapaPresentacion.Alta_Medicamentos" %>

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
    <div align="center" style="height: 432px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Medicamentos.png" />
        <br />
        <br />
        <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>

        &nbsp;<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        &nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="21px" ImageUrl="~/Imagenes/Crear.png" OnClick="ImageButton1_Click" Width="28px" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="393px" Visible="false">
            <br />
 <asp:Label ID="Label1" runat="server" Text="Drogas"></asp:Label>
&nbsp;<asp:TextBox ID="txtdroga" runat="server"></asp:TextBox>
            &nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="28px" ImageUrl="~/Imagenes/Buscar.png" Width="34px" OnClick="ImageButton3_Click" />
            <br />
            <asp:Panel ID="PanelCrearDroga" runat="server" Height="297px" Visible="false">
                <br />
                <asp:Label ID="Label2" runat="server" Text="Accion Terapeutica"></asp:Label>
                &nbsp;<asp:TextBox ID="txtaccion" runat="server"></asp:TextBox>
                &nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtaccion" ErrorMessage="Ingresar Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="ContraIndicaccion"></asp:Label>
                &nbsp;<asp:TextBox ID="txtcontraindicacion" runat="server"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtcontraindicacion" ErrorMessage="Ingresar Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Agregar" OnClick="Button2_Click" ValidationGroup="UNO" />
                &nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cerrar" Visible="false" />
            </asp:Panel>
            <br />
        <br />
        <br />
        <asp:Label ID="lblporcentaje" runat="server" Text="Porcentaje:"></asp:Label>
            <asp:TextBox ID="txtporcentaje" runat="server" style="margin-top: 0px"></asp:TextBox>
            <br />
            <br />
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Cargar" Visible="false" OnClick="Button4_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
        <br />
       

        <br />
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
