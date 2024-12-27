using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_mantenimientoEquipos.NewFolder1
{
    public partial class Equipo : Page
    {
        
        private void EjecutarProcedimiento(string procedimiento, SqlParameter[] parametros)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TuCadenaDeConexion"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(procedimiento, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                cmd.Parameters.AddRange(parametros);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                   
                    Response.Write("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        
        private void LlenarGridView(string procedimiento, GridView gridView)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TuCadenaDeConexion"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(procedimiento, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridView.DataSource = dt;
                gridView.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
                LlenarUsuarios();
                LlenarTecnicos();
            }
        }

        // Agregar equipo
        protected void AgregarEquipo(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", txtNombreEquipo.Text),
                new SqlParameter("@descripcion", txtDescripcionEquipo.Text)
            };

            EjecutarProcedimiento("IngresarEquipo", parametros);
            LlenarGrid();
        }

        // Modificar equipo
        protected void ModificarEquipo(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", int.Parse(txtEquipoID.Text)),
                new SqlParameter("@nombre", txtNombreEquipo.Text),
                new SqlParameter("@descripcion", txtDescripcionEquipo.Text)
            };

            EjecutarProcedimiento("ModificarEquipo", parametros);
            LlenarGrid();
        }

        // Eliminar equipo
        protected void EliminarEquipo(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", int.Parse(txtEquipoID.Text))
            };

            EjecutarProcedimiento("BorrarEquipo", parametros);
            LlenarGrid();
        }

        // Llenar grid de equipos
        protected void LlenarGrid()
        {
            LlenarGridView("ConsultarEquipos", gvEquipos);
        }

        // Agregar usuario
        protected void AgregarUsuario(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", txtNombreUsuario.Text),
                new SqlParameter("@correo", txtCorreoUsuario.Text)
            };

            EjecutarProcedimiento("IngresarUsuario", parametros);
            LlenarUsuarios();
        }

        // Modificar usuario
        protected void ModificarUsuario(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", int.Parse(txtUsuarioID.Text)),
                new SqlParameter("@nombre", txtNombreUsuario.Text),
                new SqlParameter("@correo", txtCorreoUsuario.Text)
            };

            EjecutarProcedimiento("ModificarUsuario", parametros);
            LlenarUsuarios();
        }

        // Eliminar usuario
        protected void EliminarUsuario(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", int.Parse(txtUsuarioID.Text))
            };

            EjecutarProcedimiento("BorrarUsuario", parametros);
            LlenarUsuarios();
        }

        // Llenar grid de usuarios
        protected void LlenarUsuarios()
        {
            LlenarGridView("ConsultarUsuarios", gvUsuarios);
        }

        // Agregar técnico
        protected void AgregarTecnico(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", txtNombreTecnico.Text),
                new SqlParameter("@especialidad", txtEspecialidadTecnico.Text)
            };

            EjecutarProcedimiento("IngresarTecnico", parametros);
            LlenarTecnicos();
        }

        // Modificar técnico
        protected void ModificarTecnico(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", int.Parse(txtTecnicoID.Text)),
                new SqlParameter("@nombre", txtNombreTecnico.Text),
                new SqlParameter("@especialidad", txtEspecialidadTecnico.Text)
            };

            EjecutarProcedimiento("ModificarTecnico", parametros);
            LlenarTecnicos();
        }

        // Eliminar técnico
        protected void EliminarTecnico(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", int.Parse(txtTecnicoID.Text))
            };

            EjecutarProcedimiento("BorrarTecnico", parametros);
            LlenarTecnicos();
        }

        // Llenar grid de técnicos
        protected void LlenarTecnicos()
        {
            LlenarGridView("ConsultarTecnicos", gvTecnicos);
        }
    }
}

