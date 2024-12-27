using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Web.UI.WebControls;
using System.Web.UI;

using System;

<%@ Page Language = "C#" AutoEventWireup="true" CodeBehind="Equipo.aspx.cs" Inherits="Sitema_mantenimientoEquipos.NewFolder1.Equipo" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gestión de Equipos</title>
    <style>
        
        .form-section {
            margin-bottom: 20px;
        }

        label {
            font-weight: bold;
        }

        .btn - action {
    background - color: #4CAF50;
            color: white;
padding: 10px 20px;
border: none;
cursor: pointer;
margin: 5px;
}

        .btn - action:hover {
            background-color: #45a049;
        }

        
        @media screen and (max-width: 768px) {
            .form-section {
                width: 100 %;
padding: 10px;
            }

            .btn - action {
width: 100 %;
padding: 15px;
}
        }
    </ style >
</ head >
< body >
    < form id = "form1" runat = "server" >
        < div class= "form-section" >
            < fieldset >
                < legend > Equipo </ legend >
                < label for= "txtEquipoNombre" > Nombre del Equipo </ label >
                < asp:TextBox ID = "txtEquipoNombre" runat = "server" CssClass = "form-control" />
                < asp:RequiredFieldValidator
                    ID = "rfvEquipoNombre"
                    runat = "server"
                    ControlToValidate = "txtEquipoNombre"
                    ErrorMessage = "El nombre del equipo es obligatorio"
                    ForeColor = "Red" />
                < br />

                < label for= "txtEquipoDescripcion" > Descripción </ label >
                < asp:TextBox ID = "txtEquipoDescripcion" runat = "server" CssClass = "form-control" />
                < asp:RequiredFieldValidator
                    ID = "rfvEquipoDescripcion"
                    runat = "server"
                    ControlToValidate = "txtEquipoDescripcion"
                    ErrorMessage = "La descripción es obligatoria"
                    ForeColor = "Red" />
                < br />

                < asp:Button ID = "btnAgregarEquipo" runat = "server" Text = "Agregar Equipo" CssClass = "btn-action" OnClick = "AgregarEquipo" />
                < asp:Button ID = "btnModificarEquipo" runat = "server" Text = "Modificar Equipo" CssClass = "btn-action" OnClick = "ModificarEquipo" />
                < asp:Button ID = "btnEliminarEquipo" runat = "server" Text = "Eliminar Equipo" CssClass = "btn-action" OnClick = "EliminarEquipo" />
            </ fieldset >
        </ div >

        < div class= "form-section" >
            < fieldset >
                < legend > Usuario </ legend >
                < label for= "txtUsuarioNombre" > Nombre del Usuario </ label >
                < asp:TextBox ID = "txtUsuarioNombre" runat = "server" CssClass = "form-control" />
                < br />

                < label for= "txtUsuarioCorreo" > Correo del Usuario </ label >
                < asp:TextBox ID = "txtUsuarioCorreo" runat = "server" CssClass = "form-control" />
                < br />

                < asp:Button ID = "btnAgregarUsuario" runat = "server" Text = "Agregar Usuario" CssClass = "btn-action" OnClick = "AgregarUsuario" />
                < asp:Button ID = "btnModificarUsuario" runat = "server" Text = "Modificar Usuario" CssClass = "btn-action" OnClick = "ModificarUsuario" />
                < asp:Button ID = "btnEliminarUsuario" runat = "server" Text = "Eliminar Usuario" CssClass = "btn-action" OnClick = "EliminarUsuario" />
            </ fieldset >
        </ div >

        < div class= "form-section" >
            < fieldset >
                < legend > Técnico </ legend >
                < label for= "txtTecnicoNombre" > Nombre del Técnico </ label >
                < asp:TextBox ID = "txtTecnicoNombre" runat = "server" CssClass = "form-control" />
                < br />

                < label for= "txtTecnicoEspecialidad" > Especialidad </ label >
                < asp:TextBox ID = "txtTecnicoEspecialidad" runat = "server" CssClass = "form-control" />
                < br />

                < asp:Button ID = "btnAgregarTecnico" runat = "server" Text = "Agregar Técnico" CssClass = "btn-action" OnClick = "AgregarTecnico" />
                < asp:Button ID = "btnModificarTecnico" runat = "server" Text = "Modificar Técnico" CssClass = "btn-action" OnClick = "ModificarTecnico" />
                < asp:Button ID = "btnEliminarTecnico" runat = "server" Text = "Eliminar Técnico" CssClass = "btn-action" OnClick = "EliminarTecnico" />
            </ fieldset >
        </ div >

        < div class= "form-section" >
            < fieldset >
                < legend > Consultar Tabla </ legend >
                < label for= "ddlConsultarTabla" > Seleccionar Tabla </ label >
                < asp:DropDownList ID = "ddlConsultarTabla" runat = "server" CssClass = "form-control" >
                    < asp:ListItem Text = "Equipos" Value = "Equipos" />
                    < asp:ListItem Text = "Usuarios" Value = "Usuarios" />
                    < asp:ListItem Text = "Técnicos" Value = "Tecnicos" />
                </ asp:DropDownList >
                < asp:Button ID = "btnConsultarTabla" runat = "server" Text = "Consultar" CssClass = "btn-action" OnClick = "btnConsultarTabla_Click" />
            </ fieldset >
        </ div >

        < div class= "form-section" >
            < asp:GridView ID = "GridView1" runat="server" CssClass="table table-bordered" AutoGenerateColumns="true" />
        </div>

        <asp:Label ID = "lblMensaje" runat="server" ForeColor="Green" />
    </form>
</body>
</html>
