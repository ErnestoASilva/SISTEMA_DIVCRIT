﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosVacacionales
{
    public partial class frmAceptarDenegar : Form
    {
        public frmAceptarDenegar()
        {
            InitializeComponent();
        }
        //Prueba
        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";
        static string cadena = "Data Source = DESKTOP-H64H067; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";

        SqlConnection conexion = new SqlConnection(cadena);

        DateTime fecha1;
        DateTime fecha2;
        int idSolicitud;
        string selectColaboradoresWhere;
        string estadoRH, estadoJEFE, tipoPermiso;
        int id, diasPedidosVacaciones, nomina;
        bool aviso;

        DateTime proximo_reset;
        int diasPedidos;
        DateTime fecha_temporal;
        DateTime fechaActual = DateTime.Now;
        DateTime fechaIngreso;
        int diasTotales;
        int diasDisponibles;

        int permisos_dias_pedidos, permisos_dias_sinsueldo_pedidos, permisos_horas_pedidos;

        private void frmAceptarDenegar_Load(object sender, EventArgs e)
        {
            cbxEstadoLista.Text = "PENDIENTE";
            aviso = false;
            btnDenegar.Enabled = false;
            btnAceptar.Enabled = false;
            dgvSolicitudes.AllowUserToAddRows = false;

            try
            {
                //EJECUCION DEL METODO PARA ACTUALIZAR EL DATAGRIDVIEW
                conexion.Open();
                actualizadDataGridView();
                conexion.Close();

                //rellenarLabels();
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmAceptarDenegar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DESPLEGAR INFORMACION EN LOS LABELS AL HACER CLICK EN UNA CELDA DEL DATAGRIDVIEW
            try
            {
                idSolicitud = (int)dgvSolicitudes.CurrentRow.Cells[0].Value;
                obtenerFechas();
                rellenarLabels();

                estadoJEFE = dgvSolicitudes.CurrentRow.Cells[9].Value.ToString();
                estadoRH = dgvSolicitudes.CurrentRow.Cells[8].Value.ToString();

                verificarEstado();
                

            }
            catch (Exception)
            {

            }
        }

        //METODO PARA COLOCAR LA INFORMACION EN LOS LABELS CON LA INFORMACION DE LA CELDA SELECCIONADA
        private void rellenarLabels() 
        {
            try
            {
                if (dgvSolicitudes.CurrentRow != null)
                {
                    lblNomina.Text = "Nómina: " + dgvSolicitudes.CurrentRow.Cells[1].Value.ToString();
                    lblNombre.Text = "Nombre: " + dgvSolicitudes.CurrentRow.Cells[2].Value.ToString();
                    lblTipoPermiso.Text = "Tipo de Permiso: " + dgvSolicitudes.CurrentRow.Cells[3].Value.ToString();
                    lblDiasPedidos.Text = "Días Pedidos: " + dgvSolicitudes.CurrentRow.Cells[4].Value.ToString();
                    lblFechaInicio.Text = "Fecha Inicial: " + dgvSolicitudes.CurrentRow.Cells[5].Value.ToString();
                    lblFechaFinal.Text = "Fecha Final: " + dgvSolicitudes.CurrentRow.Cells[6].Value.ToString();
                    rtbMotivo.Text = dgvSolicitudes.CurrentRow.Cells[7].Value.ToString();
                    lblEstadoRH.Text = dgvSolicitudes.CurrentRow.Cells[8].Value.ToString();
                    lblEstadoJefe.Text = dgvSolicitudes.CurrentRow.Cells[9].Value.ToString();
                    id = (int)dgvSolicitudes.CurrentRow.Cells[0].Value;
                }
                else
                {
                    if (dgvSolicitudes.Rows.Count == 0)
                    {
                    MessageBox.Show("No hay solicitudes que mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado. Código:" + ex.InnerException.HResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        //METODO PARA OBTENER LA FECHA INICIAL Y FECHA FINAL DE LAS SOLICITUDES
        private void obtenerFechas()
        {
            conexion.Open();
            string consultaFecha = string.Format("SELECT fecha_inicio, fecha_final FROM SOLICITUD_VACACIONES WHERE ID = " + idSolicitud + ";");
            SqlCommand command = new SqlCommand(consultaFecha, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                fecha1 = (DateTime)reader[0];
                fecha2 = (DateTime)reader[1];
            }


            conexion.Close();
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            //PREGUNTAR SI EL TIPO DE USUARIO ES VACACIONES(RECURSOS HUMANOS) O CUALQUIER OTRO(JEFES DE AREAS) 
            if (VariablesGlobales.tipoUsuario == "vacaciones")
            {
                //ACTUALIZAR EL ESTADO DE RECURSOS HUMANOS A RECHAZADO
                string actualizarRH = string.Format("UPDATE SOLICITUD_VACACIONES SET estado_rh = 'RECHAZADA' WHERE ID = " + idSolicitud + ";");
                
                try
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand(actualizarRH, conexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se ha rechazado la solicitud exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rellenarLabels();
                    actualizadDataGridView();
                    conexion.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado. Código:" + ex.HResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                
            }
            else if (VariablesGlobales.tipoUsuario == "jefe" || VariablesGlobales.tipoUsuario == "admin" || VariablesGlobales.tipoUsuario == "jefe_almacen" )
            {
                //ACTUALIZAR EL ESTADO DE JEFES DE AREA A RECHAZADO
                string actualizarRH = string.Format("UPDATE SOLICITUD_VACACIONES SET estado_jefe = 'RECHAZADA' WHERE ID = " + idSolicitud + ";");
                
                try
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand(actualizarRH, conexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se ha rechazado la solicitud exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizadDataGridView();
                    conexion.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrió un error inesperado. Código:" + ex.HResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                
            }
        }

        //METODO PARA ACTUALIZAR LA INFORMACION DEL DATAGRIDVIEW
        private void actualizadDataGridView()
        {
           //PREGUNTA POR EL TIPO DE USUARIO
            if (VariablesGlobales.tipoUsuario == "vacaciones")
            {
                //MOSTRAR LAS SOLICITUDES CON EL ESTADO SELECCIONADO
                if (cbxEstadoLista.Text == "TODOS")
                {
                    //SI EL USUARIO SELECCIONA TODOS EN EL ESTADO DESPELEGAR LA INFORMACION DE TODAS LAS SOLICITUDES
                    selectColaboradoresWhere = "";
                }
                else
                {
                    //SI EL USUARIO SELECCIONA CUALQUIER OTRO ESTADO DEPLIEGAR LA INFORMACION CORRESPONDIENTE
                    selectColaboradoresWhere = "WHERE estado_rh = '" + cbxEstadoLista.Text + "'";
                }
            }
            else
            {
                // MOSTRAR LAS SOLICITUDES CON EL ESTADO SELECCIONADO DEPENDIENDO DEL EMAIL DEL JEFE
                if (cbxEstadoLista.Text == "TODOS")
                {
                    //SI EL USUARIO SELECCIONA TODOS EN EL ESTADO DESPELEGAR LA INFORMACION DE TODAS LAS SOLICITUDES
                    selectColaboradoresWhere = "WHERE C.email_jefe = '" + VariablesGlobales.emailUsuario + "'"; 
                }
                else
                {
                    //SI EL USUARIO SELECCIONA CUALQUIER OTRO ESTADO DEPLIEGAR LA INFORMACION CORRESPONDIENTE
                    selectColaboradoresWhere = "WHERE C.email_jefe = '" + VariablesGlobales.emailUsuario + "' AND estado_jefe = '" + cbxEstadoLista.Text + "'";
                }
            }

            //CONSULTA PARA LLENAR LA INFORMACION DEL DATAGRIDVIEW
            string consulta = "SELECT S.ID, C.nomina AS 'Nómina', nombre AS 'Nombre', tipo_permiso AS 'Tipo de Permiso'," +
                " dias_pedidos AS 'Días Pedidos', fecha_inicio AS 'Fecha Inicio', fecha_final AS 'Fecha Final', motivo AS 'Motivo'," +
                " estado_rh AS 'Estado de solicitud con Recursos Humanos', estado_jefe AS 'Estado de solicitud con Jefe Directo'" +
                " FROM COLABORADORES C INNER JOIN SOLICITUD_VACACIONES S ON C.nomina = S.nomina " + selectColaboradoresWhere + " ORDER BY S.ID ASC";
            var dataAdapter = new SqlDataAdapter(consulta, conexion);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.DataSource = ds.Tables[0];
            dgvSolicitudes.BackgroundColor = Color.White;

            DataGridViewColumn column = dgvSolicitudes.Columns[0];
             
            string consulta2 = "SELECT estado_rh, estado_jefe, nomina, tipo_permiso, dias_pedidos from SOLICITUD_VACACIONES WHERE ID = " + id;
            SqlCommand command = new SqlCommand(consulta2, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                estadoJEFE = reader["estado_jefe"] as string;
                estadoRH = reader["estado_rh"] as string;
                nomina = (int)reader["nomina"];
                tipoPermiso = reader["tipo_permiso"] as string;
                diasPedidosVacaciones = (int)reader["dias_pedidos"];

            }

            rellenarLabels();
            

            //conexion.Close();

        }

        private void dgvSolicitudes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //EVENTO PARA VERIFICAR SI LA SOLICITUD SELECCIONADA FUE APROBADA O RECHAZADA
            verificarEstado();
            rellenarLabels();
            try
            {
                if (dgvSolicitudes.CurrentRow == null)
                {
                    btnAceptar.Enabled = false;
                    btnDenegar.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void pbxRegresar_Click(object sender, EventArgs e)
        {
            //BOTON PARA REGRESAR AL MENU DE JEFES
            Form MenuSuper = new frmMenuSuper();
            MenuSuper.Show();
            this.Dispose();
        }

        private void cbxEstadoLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EVENTO PARA ACTUALIZAR EL DATAGRIDVIEW CADA QUE SE CAMBIA DE COLABORADOR
            conexion.Open();
            actualizadDataGridView();
            conexion.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //PREGUNTA EL TIPO DE PERMISO A PROCESAR 
            switch (tipoPermiso)
            {
                case "DIAS LIBRES CON GOCE DE SUELDO":
                    //VERFICA SI TIENE LOS SUFICIENTES PERMISOS PARA PODER PROCESAR LA SOLICITUD
                    if (verificarPermisos() < 3)
                    {
                        ejecutarAceptar();
                    }
                    else
                    {
                        rechazarNoHayDias();
                    }
                    break;
                case "DÍA LIBRE SIN GOCE DE SUELDO":
                    //VERFICA SI TIENE LOS SUFICIENTES PERMISOS PARA PODER PROCESAR LA SOLICITUD
                    if (verificarPermisos() < 3)
                    {
                        ejecutarAceptar();
                    }
                    else
                    {
                        rechazarNoHayDias();
                    }
                    break;
                case "HORAS LIBRES":
                    //VERFICA SI TIENE LOS SUFICIENTES PERMISOS PARA PODER PROCESAR LA SOLICITUD
                    if (verificarPermisos() < 3)
                    {
                        ejecutarAceptar();
                    }
                    else
                    {
                        rechazarNoHayDias();
                    }
                    break;
                case "VACACIONES":
                    if (diasPedidosVacaciones <= verificarDiasDisponibles())
                    {
                    //VERFICA SI TIENE LOS SUFICIENTES DIAS DISPONIBLES PARA PODER PROCESAR LA SOLICITUD
                        ejecutarAceptar();
                    }
                    else
                    {
                        rechazarNoHayDias();
                    }
                    break;
                default:
                    break;
            }
            rellenarLabels();
            verificarEstado();

        }

        //METODO QUE VERIFICA EL ESTADO DE LAS SOLICITUDES PARA ACTIVAR O DESACTIVAR LOS BOTONES
        private void verificarEstado()
        {
            //PREGUNTA POR EL TIPO DE USUARIO
            if (VariablesGlobales.tipoUsuario == "jefe" || VariablesGlobales.tipoUsuario == "jefe_almacen" || VariablesGlobales.tipoUsuario == "admin")
            {
                //PREGUNTA POR EL ESTADO DE LA SOLICITUD PARA HABILITAR O DESHABILITAR LOS BOTONES DE DENEGAR O ACEPTAR
                //SI LA SOLICITUD YA FUE ACEPTADA O DENEGADA NO SE PUEDE VOLVER A PROCESAR
                if (estadoJEFE == "APROBADA" || estadoJEFE == "RECHAZADA")
                {
                    btnAceptar.Enabled = false;
                    btnDenegar.Enabled = false;
                }
                else
                {
                    btnAceptar.Enabled = true;
                    btnDenegar.Enabled = true;
                }
            }
            else if (VariablesGlobales.tipoUsuario == "vacaciones")
            {
                //PREGUNTA POR EL ESTADO DE LA SOLICITUD PARA HABILITAR O DESHABILITAR LOS BOTONES DE DENEGAR O ACEPTAR
                //SI LA SOLICITUD YA FUE ACEPTADA O DENEGADA NO SE PUEDE VOLVER A PROCESAR
                if (estadoRH == "APROBADA" || estadoRH == "RECHAZADA")
                {
                    btnAceptar.Enabled = false;
                    btnDenegar.Enabled = false;
                }
                else
                {
                    btnAceptar.Enabled = true;
                    btnDenegar.Enabled = true;
                }
            }
            
        }

        //METODO PARA VERIFICAR CUANTOS DIAS DISPONIBLES TIENE EL COLABORADOR
        private int verificarDiasDisponibles()
        {
            //CONSULTA DE DATOS NECESARIOS PARA EL CALCULO DE DIAS DISPONIBLES
            conexion.Open();
            string query = "SELECT proximo_reset, dias_pedidos, dia_entrada from COLABORADORES C INNER JOIN VACACIONES V ON C.nomina = V.nomina WHERE C.nomina = " + nomina;
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                proximo_reset = (DateTime)reader[0];
                diasPedidos = (int)reader[1];
                fechaIngreso = (DateTime)reader[2];
            }
            conexion.Close();

            //CALCULO PARA OBTENER LOS AÑOS 
            fecha_temporal = proximo_reset.AddYears(-2);

            //MessageBox.Show(fecha_temporal.ToString());
            TimeSpan difFechas = fechaActual - fecha_temporal;
            int años = difFechas.Days / 365;


            //PREGUNTA PARA DISTINGUIR A LOS COLABORADORES DE NUEVO INGRESO
            if (fecha_temporal.AddYears(-1) > fechaIngreso)
            {
                diasTotales = (años * 5) + 5;
            }
            else
            {
                diasTotales = (años * 5);
            }

            //RETORNO DE RESULTADOS
            diasDisponibles = diasTotales - diasPedidos;
            return diasDisponibles;
        }

        //METODO PARA VERIFICAR LOS PERMISOS DISPONIBLES DEL COLABORADOR
        private int verificarPermisos()
        {
            //CONSULTA DE DATOS NECESARIOS
            conexion.Open();
            string query = "SELECT permisos_dias_pedidos, permisos_dias_sinsueldo_pedidos, permisos_horas_pedidos from VACACIONES WHERE nomina = " + nomina;
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                permisos_dias_pedidos = (int)reader[0];
                permisos_dias_sinsueldo_pedidos = (int)reader[1];
                permisos_horas_pedidos = (int)reader[2];
            }
            conexion.Close();

            //PREGUNTA PARA DISTINGUIR EL TIPO DE PERMISO Y REGRESAR LA INFORMACION CORRESPONDIENTE 
            switch (tipoPermiso)
            {
                case "DIAS LIBRES CON GOCE DE SUELDO":
                    return permisos_dias_pedidos;
                    
                case "DÍA LIBRE SIN GOCE DE SUELDO":
                    return permisos_dias_sinsueldo_pedidos;

                case "HORAS LIBRES":
                    return permisos_horas_pedidos;
                default:
                    return 0;
            }
        }

        //METODO QUE ACTUALIZA LA TABLA DE SOLICITUDES
        private void ejecutarAceptar()
        {
            //PREGUNTA PARA DETECTAR EL TIPO DE USUARIO
            if (VariablesGlobales.tipoUsuario == "vacaciones")
            {
                //EJECUTA EL UPDATE A LA TABLA 
                string actualizarRH = string.Format("UPDATE SOLICITUD_VACACIONES SET estado_rh = 'APROBADA' WHERE ID = " + idSolicitud + ";");

                try
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand(actualizarRH, conexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se ha aceptado la solicitud exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rellenarLabels();
                    actualizadDataGridView();
                    conexion.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado. Código:" + ex.HResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }
            else if (VariablesGlobales.tipoUsuario == "jefe" || VariablesGlobales.tipoUsuario == "admin" || VariablesGlobales.tipoUsuario == "jefe_almacen")
            {
                //EJECUTA EL UPDATE A LA TABLA 
                string actualizarRH = string.Format("UPDATE SOLICITUD_VACACIONES SET estado_jefe = 'APROBADA' WHERE ID = " + idSolicitud + ";");

                try
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand(actualizarRH, conexion);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se ha aceptado la solicitud exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizadDataGridView();
                    conexion.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrió un error inesperado. Código:" + ex.HResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

            //PREGUNTA PARA CONOCER EL ESTADO DE LA SOLICITUD
            if (estadoJEFE == "APROBADA" && estadoRH == "APROBADA")
            {
                string actualizarRH;
                //PREGUNTA EL TIPO DE PERMISO
                switch (tipoPermiso)
                {
                    //RELIZA EL UPDATE CON EL TIPO DE SOLICITUD CORRESPONDIENTE
                    case "DIAS LIBRES CON GOCE DE SUELDO":
                        actualizarRH = ("UPDATE VACACIONES SET permisos_dias_pedidos = permisos_dias_pedidos + 1 WHERE nomina = " + nomina + ";");
                        conexion.Open();
                        SqlCommand command = new SqlCommand(actualizarRH, conexion);
                        command.ExecuteNonQuery();
                        conexion.Close();
                        break;
                    case "DÍA LIBRE SIN GOCE DE SUELDO":
                        actualizarRH = ("UPDATE VACACIONES SET permisos_dias_sinsueldo_pedidos = permisos_dias_sinsueldo_pedidos + 1 WHERE nomina = " + nomina + ";");
                        conexion.Open();
                        SqlCommand command2 = new SqlCommand(actualizarRH, conexion);
                        command2.ExecuteNonQuery();
                        conexion.Close();
                        break;
                    case "HORAS LIBRES":
                        actualizarRH = ("UPDATE VACACIONES SET permisos_horas_pedidos = permisos_horas_pedidos + 1 WHERE nomina = " + nomina + ";");
                        conexion.Open();
                        SqlCommand command3 = new SqlCommand(actualizarRH, conexion);
                        command3.ExecuteNonQuery();
                        conexion.Close();
                        break;
                    case "VACACIONES":
                        actualizarRH = ("UPDATE VACACIONES SET dias_pedidos = dias_pedidos + " + diasPedidosVacaciones + " WHERE nomina = " + nomina + ";");
                        conexion.Open();
                        SqlCommand command4 = new SqlCommand(actualizarRH, conexion);
                        command4.ExecuteNonQuery();
                        conexion.Close();
                        break;
                    default:
                        break;
                }

            }
        }

        //METODO QUE RECHAZA LA SOLICITUD SI NO DIAS O PERMISOS DISPONIBLES
        private void rechazarNoHayDias()
        {
            string actualizarEstado = string.Format("UPDATE SOLICITUD_VACACIONES SET estado_rh = 'RECHAZADA', estado_jefe = 'RECHAZADA' WHERE ID = " + idSolicitud + ";");

            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand(actualizarEstado, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Ya no quedan días o permisos disponibles para el colaborador:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); rellenarLabels();
                actualizadDataGridView();
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado. Código:" + ex.HResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
