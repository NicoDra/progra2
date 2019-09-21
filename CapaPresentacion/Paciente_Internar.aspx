<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente_Internar.aspx.cs" Inherits="CapaPresentacion.Paciente_Internar" %>

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
    <div style="height: 528px" align="center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Pacientes.png" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Paciente: "></asp:Label>
&nbsp;<asp:DropDownList ID="LdPaciente" runat="server" OnSelectedIndexChanged="LdPaciente_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
    
        &nbsp;
                
    
        <asp:TextBox ID="txtnombrepaciente" runat="server" Enabled="false"></asp:TextBox>
        
    
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Imagenes/Crear.png" Width="31px" OnClick="ImageButton1_Click" />
        
    
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="69px" Visible="false">
            <br />
            <asp:Label ID="lblespecialidad" runat="server" Text="Especialidad: "></asp:Label>
            <asp:DropDownList ID="LdEspecialidad" runat="server">
            </asp:DropDownList>
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="27px" ImageUrl="~/Imagenes/Crear.png" OnClick="ImageButton2_Click" Width="27px" />
        </asp:Panel>

        <br />
        <asp:Panel ID="Panel2" runat="server" Visible="false" Height="53px">
            <asp:Label ID="lblmedicos" runat="server" Text="Medicos Disponibles:"></asp:Label>
            &nbsp;<asp:DropDownList ID="LdMedicos" runat="server" OnSelectedIndexChanged="LdMedicos_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <asp:TextBox ID="txtnombreMedico" runat="server" Enabled="false"></asp:TextBox>
            <asp:ImageButton ID="ImageButton5" runat="server" Height="27px" ImageUrl="~/Imagenes/Crear.png" Width="27px" OnClick="ImageButton5_Click" />
            <br />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel3" runat="server" Height="117px" Visible="false" style="margin-bottom: 20px">
            <asp:Label ID="Label2" runat="server" Text="Habitaciones: "></asp:Label>
            &nbsp;<asp:DropDownList ID="LdHabitacion" runat="server">
                <asp:ListItem>-------------</asp:ListItem>
            </asp:DropDownList>
            &nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" Height="25px" ImageUrl="~/Imagenes/Actualizar.png" Width="27px" OnClick="ImageButton4_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Camas Disponibles: "></asp:Label>
            <asp:DropDownList ID="LdCamas" runat="server" Height="17px" Width="84px">
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton6" runat="server" Height="30px" ImageUrl="~/Imagenes/Crear.png" OnClick="ImageButton6_Click" Width="34px" Visible="false"/>
        </asp:Panel>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
