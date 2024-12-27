<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipo.aspx.cs" Inherits="Sitema_mantenimientoEquipos.NewFolder1.Equipo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Mantenimiento de Tablas</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            width: 80%;
            margin: auto;
            padding: 20px;
        }
        .form-section {
            margin-bottom: 20px;
            padding: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        .form-section h3 {
            margin-top: 0;
        }
        .form-group {
            margin-bottom: 10px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input, .form-group select {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group button, .form-group .asp-button {
            margin-top: 10px;
            padding: 10px 20px;
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .form-group button:hover, .form-group .asp-button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Mantenimiento de Equipos, Usuarios y Técnicos</h1>
            
            <!-- EQUIPOS -->
            <div class="form-section">
                <h3>Gestión de Equipos</h3>
                <div class="form-group">
                    <label for="txtEquipoNombre">Nombre del Equipo:</label>
                    <asp:TextBox ID="txtEquipoNombre" runat="server" placeholder="Ingrese el nombre del equipo"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtEquipoDescripcion">Descripción:</label>
                    <asp:TextBox ID="txtEquipoDescripcion" runat="server" placeholder="Ingrese la descripción"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnAgregarEquipo" runat="server" Text="Agregar Equipo" OnClick="AgregarEquipo" CssClass="asp-button" BackColor="#FF9933" />
                    <asp:Button ID="btnModificarEquipo" runat="server" Text="Modificar Equipo" OnClick="ModificarEquipo" CssClass="asp-button" BackColor="#FF9966" />
                    <asp:Button ID="btnEliminarEquipo" runat="server" Text="Eliminar Equipo" OnClick="EliminarEquipo" CssClass="asp-button" BackColor="#FFCC99" />
                </div>
            </div>

            <!-- USUARIOS -->
            <div class="form-section">
                <h3>Gestión de Usuarios</h3>
                <div class="form-group">
                    <label for="txtUsuarioNombre">Nombre del Usuario:</label>
                    <asp:TextBox ID="txtUsuarioNombre" runat="server" placeholder="Ingrese el nombre del usuario"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtUsuarioCorreo">Correo Electrónico:</label>
                    <asp:TextBox ID="txtUsuarioCorreo" runat="server" placeholder="Ingrese el correo"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnAgregarUsuario" runat="server" Text="Agregar Usuario" OnClick="AgregarUsuario" CssClass="asp-button" BackColor="#FF9933" />
                    <asp:Button ID="btnModificarUsuario" runat="server" Text="Modificar Usuario" OnClick="ModificarUsuario" CssClass="asp-button" BackColor="#FF9966" />
                    <asp:Button ID="btnEliminarUsuario" runat="server" Text="Eliminar Usuario" OnClick="EliminarUsuario" CssClass="asp-button" BackColor="#FFCC99" />
                </div>
            </div>

            <!-- TECNICOS -->
            <div class="form-section">
                <h3>Gestión de Técnicos</h3>
                <div class="form-group">
                    <label for="txtTecnicoNombre">Nombre del Técnico:</label>
                    <asp:TextBox ID="txtTecnicoNombre" runat="server" placeholder="Ingrese el nombre del técnico"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtTecnicoEspecialidad">Especialidad:</label>
                    <asp:TextBox ID="txtTecnicoEspecialidad" runat="server" placeholder="Ingrese la especialidad"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnAgregarTecnico" runat="server" Text="Agregar Técnico" OnClick="AgregarTecnico" CssClass="asp-button" BackColor="#FF9966" />
                    <asp:Button ID="btnModificarTecnico" runat="server" Text="Modificar Técnico" OnClick="ModificarTecnico" CssClass="asp-button" BackColor="#FF9933" />
                    <asp:Button ID="btnEliminarTecnico" runat="server" Text="Eliminar Técnico" OnClick="EliminarTecnico" CssClass="asp-button" BackColor="#FFCC99" />
                </div>
            </div>

            <!-- CONSULTAR -->
            <div class="form-section">
                <h3>Consultar Registros</h3>
                <div class="form-group">
                    <label>Seleccione la tabla a consultar:</label>
                    <asp:DropDownList ID="ddlConsultarTabla" runat="server">
                        <asp:ListItem Text="Equipos" Value="equipos"></asp:ListItem>
                        <asp:ListItem Text="Usuarios" Value="usuarios"></asp:ListItem>
                        <asp:ListItem Text="Técnicos" Value="tecnicos"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnConsultarTabla" runat="server" Text="Consultar" OnClick="ConsultarTabla" CssClass="asp-button" BackColor="#CC3300" />
                </div>
            </div>

            <!-- RESULTADOS -->
            <div class="form-section">
                <h3>Resultados</h3>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
