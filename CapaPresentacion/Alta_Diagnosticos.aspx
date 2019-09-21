<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_Diagnosticos.aspx.cs" Inherits="CapaPresentacion.Alta_Diagnosticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
             height: 746px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 663px" align="center">
     <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Diagnostico.png" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Especialidad: "></asp:Label>
        <asp:DropDownList ID="LaListadEspecialidad" runat="server" AutoPostBack="true">
        </asp:DropDownList>
        &nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Imagenes/Actualizar.png" Width="27px" OnClick="ImageButton1_Click" />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="112px" Visible="false">
             <br />
           
             <asp:Label ID="Label2" runat="server" Text="Medicos"></asp:Label>
             &nbsp;<asp:DropDownList ID="DropMedicos" runat="server" OnSelectedIndexChanged="DropMedicos_SelectedIndexChanged" AutoPostBack="true">
             </asp:DropDownList>
             <asp:TextBox ID="txtnombreMedico" runat="server" Enabled="false"></asp:TextBox>
             <br />
             <br />
             <asp:Label ID="Label3" runat="server" Text="Pacientes Dni"></asp:Label>
             &nbsp;<asp:TextBox ID="txtdni" runat="server"></asp:TextBox>
             &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="27px" ImageUrl="~/Imagenes/Buscar.png" Width="27px" OnClick="ImageButton2_Click" ValidationGroup="UNO" />
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdni" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]*" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
             <br />
           
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="76px" Visible="false">
            <asp:Label ID="Label4" runat="server" Text="Diagnostico"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtdiagnostico" runat="server"></asp:TextBox>
            &nbsp;<asp:ImageButton ID="ImageButton3" runat="server" Height="27px" ImageUrl="~/Imagenes/Crear.png" Width="27px" OnClick="ImageButton3_Click" ValidationGroup="DOS" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtdiagnostico" ErrorMessage="Solo Caracteres" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="DOS">*</asp:RegularExpressionValidator>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" Height="81px" Visible="false">
            <asp:Label ID="Label5" runat="server" Text="Tratamiento"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropMedicamentos" runat="server">
            </asp:DropDownList>
            &nbsp;<asp:ImageButton ID="ImageButton4" runat="server" Height="27px" ImageUrl="~/Imagenes/mas.png" Width="27px" OnClick="ImageButton4_Click" />
        </asp:Panel>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
    </div>
    </form>
</body>
</html>
