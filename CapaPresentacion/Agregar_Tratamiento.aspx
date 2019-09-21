<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar_Tratamiento.aspx.cs" Inherits="CapaPresentacion.Agregar_Tratamiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
            height: 510px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 504px"align="center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Diagnostico.png" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Especialidad"></asp:Label>
&nbsp;<asp:DropDownList ID="LaListadEspecialidad" runat="server">
        </asp:DropDownList>
        &nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Imagenes/Actualizar.png" Width="27px" OnClick="ImageButton1_Click" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="170px" style="margin-top: 0px" Visible="false">
            <br />
            <asp:Label ID="Label2" runat="server" Text="Medicos"></asp:Label>
            <asp:DropDownList ID="DropMedicos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropMedicos_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:TextBox ID="txtnombreMedico" runat="server" Enabled="false"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ingresar DNI del Paciente"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdni" runat="server" MaxLength="8"></asp:TextBox>
            &nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="27px" ImageUrl="~/Imagenes/Buscar.png" Width="27px" OnClick="ImageButton2_Click" ValidationGroup="UNO" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdni" ErrorMessage="Solo Numeros" ValidationExpression="^[0-9]*" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
        </asp:Panel>
    <br />
        <asp:Panel ID="Panel2" runat="server" Height="141px" style="margin-top: 0px" Visible="false">
            <br />
            <asp:Label ID="Label4" runat="server" Text="Diagnostico"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdiagnostico" runat="server" Enabled="false"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Tratamientos"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropMedicamentos" runat="server" style="margin-bottom: 0px">
            </asp:DropDownList>
            &nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="28px" ImageUrl="~/Imagenes/mas.png" Width="27px" OnClick="ImageButton3_Click" />
            <br />
            <br />
            
            <br />
            </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
