<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Laboratorio03_pg13.aspx.cs" Inherits="Laboratorios_Practicas.Laboratorio03_pg13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/estilo_04.css" rel="stylesheet" />
    <script src="JS/codigo_javaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <h2>LABORATORIO 03</h2>

        <div class="contenedor-entradas">
            <asp:TextBox ID="txtnombre" placeholder="Nombre" class="Texto_Ancho" runat="server" />
            <asp:DropDownList ID="cbocargo" runat="server" AutoPostBack="true" CssClass="combo" OnClientClick="sueldo();return false;" />
            <asp:TextBox ID="txtsueldo" placeholder="Suelto" Class="Texto_Corto" runat="server" />
        </div>

        <div class="contenedor-combo">
            <asp:DropDownList ID="cboec" AutoPostBack="true" runat="server" class="combo" OnClientClick="estado_civil();return false;" />
            <asp:DropDownList ID="cbohijos" AutoPostBack="true" runat="server" class="combo" OnSelectedIndexChanged="cbohijos_SelectedIndexChanged" />
        </div>

        <div class="contenedor-entradas">
            <asp:TextBox ID="txtpec" placeholder="% Estado Civil" ReadOnly="true" class="Texto_Corto" runat="server" /> 
            <asp:TextBox ID="txtph" placeholder="% Hijos" ReadOnly="true" class="Texto_Corto" runat="server" /> 
        </div>

        <div class="contenedor-botones">
            <asp:Button ID="btnnuevo" Text="Nuevo" runat="server" class="botones" OnClick="btnnuevo_Click" />
            <asp:Button ID="btncalcular" Text="Calcular" runat="server" class="botones" OnClick="btncalcular_Click" />
        </div>

        <div class="contenedor-entradas">
            <asp:TextBox ID="txttec" ReadOnly="true" placeholder="% Estado Civil" runat="server" class="Texto_Corto" /> 
            <asp:TextBox ID="txttphijos" ReadOnly="true" placeholder="% Hijos" runat="server" class="Texto_Corto" /> 
            <asp:TextBox ID="txttp" ReadOnly="true" placeholder="Total a pagar" runat="server" /> 
        </div>
    </form>
</body>
</html>
