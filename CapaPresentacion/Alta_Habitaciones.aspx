<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_Habitaciones.aspx.cs" Inherits="CapaPresentacion.Alta_Habitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {

             background-image:url('/Imagenes/fondon.png');
            height: 455px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div align="center" style="height: 470px">
    
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Habitaciones.png" />
    
       <br />
       <br />
       INGRESE CODIGO DE HABITACION:<asp:TextBox ID="txtident" runat="server"></asp:TextBox>
       &nbsp;
       <asp:ImageButton ID="ImageButton1" runat="server" Height="24px" ImageUrl="~/Imagenes/Buscar.png" OnClick="ImageButton1_Click" Width="32px" />
       &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtident" ErrorMessage="Solo Numeros" ValidationExpression="^[0-9]*" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtident" EnableViewState="False" ErrorMessage="Ingrese Numero De habitacion" ValidationGroup="UNO">*</asp:RequiredFieldValidator>
       <br />
&nbsp;<br />
       INGRESE NUMERO DE CAMAS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtnumcam" runat="server"></asp:TextBox>
       &nbsp;
       <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtnumcam" ErrorMessage="Ingresa Numeros" ValidationExpression="^[0-9]*" ValidationGroup="UNO">*</asp:RegularExpressionValidator>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnumcam" ErrorMessage="Ingrese Cantidad de Cama" ValidationGroup="UNO">*</asp:RequiredFieldValidator>
       <br />
       <br />
       <asp:Label ID="Label1" runat="server" Text="TIPOS DE CAMAS :"></asp:Label>
&nbsp;&nbsp;
       <asp:DropDownList ID="DropDownList1" runat="server">
           <asp:ListItem>SIMPLE</asp:ListItem>
           <asp:ListItem>MEDIA</asp:ListItem>
           <asp:ListItem>ALTA</asp:ListItem>
       </asp:DropDownList>
       <br />
       <br />
       SELECCIONE ESPECIALIDAD:<br />
       <br />
       <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
           <Columns>
                 <asp:CommandField SelectText="SELECCIONAR" ShowSelectButton="True" />
           </Columns>
       </asp:GridView>
       <asp:Label ID="lblesp" runat="server" Text="Especialidad"></asp:Label>
       <asp:Label ID="lblncama" runat="server" Text="0" Visible="false"></asp:Label>
       <br />
       <br />
       <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="UNO" />
       <br />
       <br />
&nbsp;&nbsp;&nbsp;
       <br />
       <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CARGAR" ValidationGroup="UNO" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="VOLVER" />
    
    </div>
    </form>
</body>
</html>
