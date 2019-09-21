<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_Medicos.aspx.cs" Inherits="CapaPresentacion.Alta_Medicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
            height: 319px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Medicos.png" />
    </div>
        <div style="height: 260px" align="center">
           
            <asp:Panel ID="Panel1" runat="server" Height="252px" Width="1077px" HorizontalAlign="Center" > 
                <br />
                <asp:Label ID="lbldni" runat="server" Text="DNI:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdnimedico" runat="server" MaxLength="8"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdnimedico" ErrorMessage="Solo Numeros" ValidationExpression="^[0-9]*" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdnimedico" ErrorMessage="Ingrese DNI" ValidationGroup="UNO">*</asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="lblnombre" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtnombremedico" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtnombremedico" ErrorMessage="Solo Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombremedico" ErrorMessage="Ingrese El Nombre" ValidationGroup="UNO">*</asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="lblespecialidad" runat="server" Text="Especialidades: "></asp:Label>
                <asp:DropDownList ID="Lalista" runat="server" AppendDataBoundItems="true">
                </asp:DropDownList>
                <br />
            <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="UNO" />
                <br />
                <br />
            <br />
                <asp:Button ID="Cargar" runat="server" Text="Cargar" OnClick="Cargar_Click" ValidationGroup="UNO" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Volver" runat="server" OnClick="Volver_Click" Text="Volver" />
                <br />
            </asp:Panel>


        </div>
        
    </form>
</body>
</html>
