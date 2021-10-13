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
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Microsoft.Office.Interop.Outlook;
using System.IO;

namespace PermisosVacacionales
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";
        static string cadena = "Data Source = DESKTOP-H64H067; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";

        SqlConnection conexion = new SqlConnection(cadena);


        DateTime fechaIngreso;
        DateTime fechaActual;
        DateTime proximo_reset;
        DateTime fechaCalculo;
        DateTime dos_anios_mas;
        DateTime fecha_temporal;
        string nombre;
        int diasPedidos;
        int nomina;
        string correo;
        string puesto;
        string area;
        string motivo;
        int permisos_dias_pedidos;
        int permisos_horas_pedidos;
        int permisos_dias_restantes;
        int permisos_horas_restantes;
        int permisos_dias_sinsueldo_pedidos;
        int permisos_dias_sinsueldo_restantes;
        int diasTotales;
        int diasDisponibles;
        int diasCalculados;
        int diasCalculadoSinGoce;
        int diasCalculadoVacaciones;
        string correo_jefe;

        int variable1 = 0;
        int variable2 = 10;


        string tipoPermiso;
        string tipoUsuario = VariablesGlobales.tipoUsuario;


        private void frmConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

            try
            {
                //CREACIÓN Y EJECUCIÓN DE CONSULTA PARA OBTENER TODOS LOS DATOS DEL COLABORADOR
                conexion.Open();
                string consulta = string.Format("SELECT c.nomina, nombre, correo, puesto, area, dia_entrada, dias_pedidos, permisos_dias_pedidos, permisos_horas_pedidos, permisos_dias_sinsueldo_pedidos, email_jefe, proximo_reset  FROM COLABORADORES C INNER JOIN VACACIONES V ON c.nomina = v.nomina WHERE correo = " + "'" + VariablesGlobales.emailUsuario + "';");
                SqlCommand command = new SqlCommand(consulta, conexion);
                SqlDataReader reader = command.ExecuteReader();

                //ASIGNACIÓN DE VARIABLES A LOS DATOS OBTENIDOS
                while (reader.Read())
                {
                    nomina = (int)reader[0];
                    nombre = reader[1] as string;
                    correo = reader[2] as string;
                    puesto = reader[3] as string;
                    area = reader[4] as string;
                    fechaIngreso = (DateTime)reader[5];
                    diasPedidos = (int)reader[6];
                    permisos_dias_pedidos = (int)reader[7];
                    permisos_horas_pedidos = (int)reader[8];
                    permisos_dias_sinsueldo_pedidos = (int)reader[9];
                    correo_jefe = reader[10] as string;
                    proximo_reset = (DateTime)reader[11];
                }
                conexion.Close();


                conexion.Open();
                try
                {
                    //CONSULTA PARA OBTENER LA IMAGEN QUE SE MOSTRARÁ DEL COLABORADOR
                    SqlCommand comandoFoto = new SqlCommand("SELECT imagen FROM COLABORADORES WHERE nomina = " + nomina, conexion);
                    byte[] img = (byte[])comandoFoto.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(img);
                    pbxFoto.Image = Image.FromStream(ms);

                }
                catch (System.Exception)
                {

                }
                conexion.Close();

                //INICIALMENTE TODOS LOS DateTimePicker EMPIEZAN CON LA FECHA ACTUAL
                fechaActual = DateTime.Now;
                this.lblTime.Text = DateTime.Now.ToString();
                dtpFecha1CG.Value = DateTime.Now;
                dtpFecha2CG.Value = DateTime.Now;
                dtpFecha1SG.Value = DateTime.Now;
                dtpFecha2SG.Value = DateTime.Now;
                dtpHora.Value = DateTime.Now.Date;
                dtpHora2.Value = DateTime.Now.Date;

                //SE CREA UNA VARIABLE QUE SE UTILIZARÁ PARA REEMPLAZAR LA FECHA DEL PROXIMO RESET DE DIAS VACACIONALES (CADA DOS AÑOS)
                dos_anios_mas = proximo_reset.AddYears(2);

                //SE HACE LA COMPARACIÓN PARA SABER SI LA FECHA DEL RESET YA LLEGÓ
                if (fechaActual >= proximo_reset)
                {
                    //AL SER ASÍ, SE HACE EL REEMPLAZO DE LA PRÓXIMA FECHA DE RESET Y SE RESETEAN LOS DÍAS PEDIDOS PARA VOLVER A HACER EL CÁLCULO
                    SqlCommand sqlCmd1 = new SqlCommand("UPDATE COLABORADORES SET proximo_reset = '" + dos_anios_mas.ToString("MM/dd/yyyy") + "' WHERE nomina = " + nomina, conexion);
                    SqlCommand sqlCmd2 = new SqlCommand("UPDATE VACACIONES SET dias_pedidos = 0 WHERE nomina = " + nomina, conexion);
                    conexion.Open();
                    try
                    {
                        sqlCmd1.ExecuteNonQuery();
                        sqlCmd2.ExecuteNonQuery();
                        proximo_reset = dos_anios_mas;
                        diasPedidos = 0;
                        //enviarCorreo();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ocurrio un error inesperado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    conexion.Close();
                }


                //VARIABLE TEMPORAL CREADA PARA HACER EL CÁLCULO DE AÑOS DESDE EL ÚLTIMO RESET
                fecha_temporal = proximo_reset.AddYears(-2);
                
                //SE HACE EL CÁLCULO
                TimeSpan difFechas = fechaActual - fecha_temporal;
                int años = difFechas.Days / 365;


                //SE PREGUNTA PARA DIFERENCIAR SI UN COLABORADOR ES NUEVO O NO
                if (fecha_temporal.AddYears(-1) > fechaIngreso)
                {
                    //SI EL USUARIO NO ES NUEVO, EL RESET LO DEVOLVERÁ A TENER 5 DÍAS DISPONIBLES
                    diasTotales = (años * 5) + 5;
                }
                else
                {
                    //SI ES NUEVO, COMENZARÁ A CONTAR DESDE CERO HASTA QUE CUMPLA UN AÑO
                    diasTotales = (años * 5);
                }

                //SE CALCULAN LOS DÍAS DISPONIBLES TOMANDO LA CANTIDAD DE DÍAS CALCULADOS ANTERIORMENTE Y SUSTRAYENDO 
                // LA CANTIDAD DE DÍAS PEDIDOS
                diasDisponibles = diasTotales - diasPedidos;

                lblDiasDisponibles.Text = diasDisponibles.ToString();

                //LO MISMO CON LOS PERMISOS. SE COMIENZA A CONTAR CON TRES Y SE CALCULAN SUS PERMISOS DISPONIBLES 
                // SUSTRAYENDO LA CANTIDAD DE PERMISOS QUE HA PEDIDO.
                permisos_dias_restantes = 3 - permisos_dias_pedidos;
                permisos_horas_restantes = 3 - permisos_horas_pedidos;
                permisos_dias_sinsueldo_restantes = 3 - permisos_dias_sinsueldo_pedidos;

                //DESPLEGAR LA INFORMACIÓN OBTENIDA ANTERIORMENTE EN LABELS
                lblNombre.Text = nombre;
                lblNomina.Text = nomina.ToString();
                lblCorreo.Text = correo;
                lblArea.Text = area;
                lblPuesto.Text = puesto;
                lblPermiso_Dias.Text = permisos_dias_restantes.ToString();
                lblPermiso_Horas.Text = permisos_horas_restantes.ToString();
                lblPermiso_SinGoce.Text = permisos_dias_sinsueldo_restantes.ToString();

                //COMPROBACIÓN DE DÍAS Y PERMISOS DISPONIBLES CON LA COMPROBACIÓN DE QUE NO HAYAN LLEGADO A CERO.
                //SI ESE ES EL CASO, SE MUESTRA UN MESSAGEBOX AVISANDO QUE YA NO TIENE PERMISOS Y BLOQUEANDO LAS TABS CORRESPONDIENTES.
                if (diasTotales <= 0)
                {
                    MessageBox.Show("Ya no te quedan días de vacaciones.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ((Control)this.tabVacaciones).Enabled = false;

                }
                if (permisos_dias_restantes <= 0)
                {
                    MessageBox.Show("Ya no te quedan permisos de días restantes en este semestre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ((Control)this.tabConGoce).Enabled = false;

                }
                if (permisos_dias_sinsueldo_restantes <= 0)
                {
                    MessageBox.Show("Ya no te quedan permisos de días sin goce de sueldo restantes en este semestre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ((Control)this.tabSinGoce).Enabled = false;

                }
                if (permisos_horas_restantes <= 0)
                {
                    MessageBox.Show("Ya no te quedan permisos de horas restantes en este semestre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ((Control)this.tabHoras).Enabled = false;
                }

                //LOS DATETIMEPICKER DEL PEDIDO DE HORAS TIENEN FORMATO ESPECIAL PARA LA POSIBILIDAD DE ESCOGER HORAS EXACTAS.
                dtpHora.Format = DateTimePickerFormat.Custom;
                dtpHora.CustomFormat = "dd/MM/yyyy | hh:mm tt";
                dtpHora.ShowUpDown = true;


                dtpHora2.Format = DateTimePickerFormat.Custom;
                dtpHora2.CustomFormat = "dd/MM/yyyy | hh:mm tt";
                dtpHora2.ShowUpDown = true;



            }
            catch (System.Exception)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }



        }

        //EVENTO QUE SE UTILIZA PARA EL RELOJ EN VIVO
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();

        }

        //MÉTODO QUE SE UTILIZA PARA CALCULAR LA CANTIDAD DE DÍAS ENTRE DOS FECHAS (EXCLUYENDO LOS FINES DE SEMANA)
        public int diasEntre(DateTime diaUno, DateTime diaDos)
        {
            diaUno = diaUno.Date;
            diaDos = diaDos.Date;
            int diasLaborales;
            if (diaUno > diaDos)
            {
                //SI LA PRIMERA FECHA ESCOGIDA ES MAYOR QUE LA SEGUNDA, SE ESTABLECEN LOS DIAS LABORALES COMO CERO.
                diasLaborales = 0;
            }
            else
            {
                //SE CACLCULA LA CANTIDAD TOTAL DE DÍAS ENTRE LAS DOS FECHAS
                TimeSpan span = diaDos - diaUno;

                //SE LE AÑADE UN DÍA PARA TOMAR EN CUENTA TAMBIÉN EL PRIMER DÍA
                diasLaborales = span.Days + 1;

                //SE DIVIDE ENTRE SIETE PARA CONTAR LAS SEMANAS ENTRE AMBOS DÍAS
                int conteoSemanal = diasLaborales / 7;

                //VER SI HAY FINES DE SEMANA EN EL TIEMPO SUPERANDO EL CONTEO SEMANAL
                if (diasLaborales > conteoSemanal * 7)
                {
                    //ENCONTRAR LOS FINES DE SEMANA EN EL INTERVALO DE TIEMPO RESTANTE DESPUÉS DE RESTAR LAS SEMANAS COMPLETAS
                    int diaUnoDeSemana = (int)diaUno.DayOfWeek;
                    int diaDosDeSemana = (int)diaDos.DayOfWeek;
                    if (diaDosDeSemana < diaUnoDeSemana)
                        diaDosDeSemana += 7;
                    if (diaUnoDeSemana <= 6)
                    {
                        if (diaDosDeSemana >= 7)//CUANDO EN EL INTERVALO SE ENCUENTRA UN SABADO Y UN DOMINGO
                            //SE RESTAN DOS DÍAS
                            diasLaborales -= 2;
                        else if (diaDosDeSemana >= 6)//CUANDO SOLO SE ENCUENTRA UN SABADO EN EL INTERVALO
                            //SE RESTA UNO
                            diasLaborales -= 1;
                    }
                    else if (diaUnoDeSemana <= 7 && diaDosDeSemana >= 7)//CUANDO SOLO SE ENCUENTRA UN DOMINGO EN EL INTERVALO
                        diasLaborales -= 1;
                }

                //SE LE RESTAN LOS FINES DE SEMANA AL CONTEO SEMANAL 
                diasLaborales -= conteoSemanal + conteoSemanal;
            }
            return diasLaborales;
        }

        //MÉTODO PARA ENVIAR UN CORREO DE AVISO AL JEFE DIRECTO AL REALIZAR UNA SOLICITUD
        private void enviarCorreo()
        {
            System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();

            mensaje.To.Add(correo_jefe);
            mensaje.Subject = "Solicitud de Permiso Vacacional de " + nombre;
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;

            mensaje.Body = "Ha recibido una solicitud de " + tipoPermiso + " por " + nombre + ", favor de ingresar al sistema para revisar la solicitud.";
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new System.Net.Mail.MailAddress("serviciocritson@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.UseDefaultCredentials = false;

            cliente.Credentials = new System.Net.NetworkCredential("serviciocritson@gmail.com", "Servicio2021");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mensaje);
                cliente.Dispose();
                MessageBox.Show("Se ha enviado un correo con tu solicitud a tu supervisor.", "Exito");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        //AL SELECCIONAR LOS RADIOBUTTON DE 'FALLECIMIENTO' U 'OTRO' SE ACTIVAN SUS RESPECTIVOS TEXTBOX
        private void rbtFallecimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFallecimiento.Checked)
            {
                tbxFallecimiento.Enabled = true;

            }
            else if (!rbtFallecimiento.Checked)
            {
                tbxFallecimiento.Enabled = false;
                tbxFallecimiento.Clear();
            }
        }

        private void rbtOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOtro.Checked)
            {
                tbxOtro.Enabled = true;

            }
            else if (!rbtOtro.Checked)
            {
                tbxOtro.Enabled = false;
                tbxOtro.Clear();
            }
        }


        private void btnSolicitarCG_Click(object sender, EventArgs e)
        {
            //EL RADIOBUTTON DE MOTIVO SELECCIONADO SE VERÁ REFLEJADO EN EL MOTIVO EN LA SOLICITUD
            tipoPermiso = "DIAS LIBRES CON GOCE DE SUELDO";
            if (rbtTitulacion.Checked)
            {
                motivo = "Titulación";
            }
            if (rbtCursos.Checked)
            {
                motivo = "CURSOS, CONGRESOS, SEMINARIOS";
            }
            if (rbtComision.Checked)
            {
                motivo = "COMISIÓN (MÉDICA/ADMINISTRATIVA)";
            }
            if (rbtMatrimonio.Checked)
            {
                motivo = "MATRIMONIO";
            }
            if (rbtNacimiento.Checked)
            {
                motivo = "NACIMIENTO";
            }
            if (rbtFallecimiento.Checked)
            {
                motivo = "FALLECIMIENTO: " + tbxFallecimiento.Text;
            }
            if (rbtOtro.Checked)
            {
                motivo = "OTRO: " + tbxOtro.Text;
            }

            //ANTES DE RALIZAR LA SOLICITUD, SE ASEGURA DE QUE LA FECHA INICIAL NO SOBREPASE LA FECHA FINAL
            if (dtpFecha1CG.Value <= dtpFecha2CG.Value)
            {
                //enviarCorreo();
                enviarSolicitud(nomina, tipoPermiso, diasCalculados, dtpFecha1CG.Value, dtpFecha2CG.Value, motivo);
            }
            else
            {
                MessageBox.Show("Favor de Insertar un Plazo Correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CADA VEZ QUE SE SELECCIONE LA FECHA SE HACE EL CÁLCULO DE DÍAS TOTALES SELECCIONADOS PARA QUE NO SOBREPASE LOS DIAS POSIBLES
        // SEGÚN EL TIPO DE PERMISO QUE SE VA A SOLICITAR.
        private void dtpFecha1CG_ValueChanged(object sender, EventArgs e)
        {
            lblDiasCalcualdos.Text = diasEntre(dtpFecha1CG.Value, dtpFecha2CG.Value).ToString();

            //SE HACE UNA COMPARACIÓN PARA EVITAR QUE SE PUEDA HACER LA SOLICITUD EN CASO DE QUE
            // ESTA SOBREPASE LA CANTIDAD DE DÍAS QUE SE PUEDEN PEDIR POR PERMISO.
            if (diasCalculados > 5)
            {
                btnSolicitarCG.Enabled = false;
                MessageBox.Show("Solo puedes solicitar hasta 5 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (diasCalculados <= 5)
            {
                btnSolicitarCG.Enabled = true;
            }
        }

        private void dtpFecha2CG_ValueChanged(object sender, EventArgs e)
        {
            diasCalculados = diasEntre(dtpFecha1CG.Value, dtpFecha2CG.Value);
            lblDiasCalcualdos.Text = diasCalculados.ToString() + " días";

            if (diasCalculados > 5)
            {
                btnSolicitarCG.Enabled = false;
                MessageBox.Show("Solo puedes solicitar hasta 5 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (diasCalculados <= 5)
            {
                btnSolicitarCG.Enabled = true;
            }

        }

        private void dtpFecha1SG_ValueChanged(object sender, EventArgs e)
        {
            diasCalculadoSinGoce = diasEntre(dtpFecha1SG.Value, dtpFecha2SG.Value);
            lblDiasSinGoce.Text = diasCalculadoSinGoce.ToString();
            if (diasCalculadoSinGoce > 2)
            {
                btnSolicitarSG.Enabled = false;
                MessageBox.Show("Solo puedes solicitar hasta 2 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (diasCalculadoSinGoce <= 2)
            {
                btnSolicitarSG.Enabled = true;
            }
        }

        private void dtpFecha2SG_ValueChanged(object sender, EventArgs e)
        {
            diasCalculadoSinGoce = diasEntre(dtpFecha1SG.Value, dtpFecha2SG.Value);
            lblDiasSinGoce.Text = diasCalculadoSinGoce.ToString();
            if (diasCalculadoSinGoce > 2)
            {
                btnSolicitarSG.Enabled = false;
                MessageBox.Show("Solo puedes solicitar hasta 2 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (diasCalculadoSinGoce <= 2)
            {
                btnSolicitarSG.Enabled = true;
            }
        }
        private void dtpFecha1Vacaciones_ValueChanged(object sender, EventArgs e)
        {
            diasCalculados = diasEntre(dtpFecha1Vacaciones.Value, dtpFecha2Vacaciones.Value);
            lblDiasCalcualdos.Text = diasCalculados.ToString() + " días";

            //AQUÍ EN VEZ DE LIMITAR AL COLABORADOR A UNA CANTIDAD EXACTA DE DÍAS SE LE LIMITA A SUS DÍAS VACACIONALES DISPONIBLES.
            if (diasCalculados > diasDisponibles)
            {
                btnSolicitarVacaciones.Enabled = false;
                MessageBox.Show("Solo tienes " + diasDisponibles.ToString() + " días disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (diasCalculados <= diasDisponibles)
            {
                btnSolicitarVacaciones.Enabled = true;
            }

            lblDiasCalculadosVacaciones.Text = diasCalculados.ToString() + " días";
        }

        private void dtpFecha2Vacaciones_ValueChanged(object sender, EventArgs e)
        {
            diasCalculados = diasEntre(dtpFecha1Vacaciones.Value, dtpFecha2Vacaciones.Value);
            lblDiasCalcualdos.Text = diasCalculados.ToString() + " días";

            if (diasCalculados > diasDisponibles)
            {
                btnSolicitarVacaciones.Enabled = false;
                MessageBox.Show("Solo tienes " + diasDisponibles.ToString() + " días disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (diasCalculados <= diasDisponibles)
            {
                btnSolicitarVacaciones.Enabled = true;
            }

            lblDiasCalculadosVacaciones.Text = diasCalculados.ToString() + " días";
        }

        //EL TIPO DE PERMISO SOLICITADO SE VERÁ REFLEJADO EN EL REGISTRO
        private void btnSolicitarSG_Click(object sender, EventArgs e)
        {
            tipoPermiso = "DÍA LIBRE SIN GOCE DE SUELDO";
            if (rbtFaltaInjustificada.Checked)
            {
                motivo = "Falta Injustificada: " + rtbxSinGoce.Text;
            }
            else
            {
                motivo = rtbxSinGoce.Text;
            }
            diasCalculadoSinGoce = diasEntre(dtpFecha1SG.Value, dtpFecha2SG.Value);
            if (dtpFecha1SG.Value <= dtpFecha2SG.Value)
            {
                enviarSolicitud(nomina, tipoPermiso, diasCalculadoSinGoce, dtpFecha1SG.Value, dtpFecha2SG.Value, motivo);
            }
            else
            {
                MessageBox.Show("Favor de Insertar un Plazo Correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSolicitarHoras_Click(object sender, EventArgs e)
        {
            tipoPermiso = "HORAS LIBRES";
            motivo = rtbxMotivoHora.Text;
            if (dtpHora.Value < dtpHora2.Value)
            {
                enviarSolicitud(nomina, tipoPermiso, 1, dtpHora.Value, dtpHora2.Value, motivo);
            }
            else
            {
                MessageBox.Show("Favor de Insertar un Plazo Correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSolicitarVacaciones_Click(object sender, EventArgs e)
        {
            tipoPermiso = "VACACIONES";

            diasCalculadoVacaciones = diasEntre(dtpFecha1Vacaciones.Value, dtpFecha2Vacaciones.Value);
            if (dtpFecha1Vacaciones.Value.Date <= dtpFecha2Vacaciones.Value.Date)
            {
                enviarSolicitud(nomina, tipoPermiso, diasCalculadoVacaciones, dtpFecha1Vacaciones.Value, dtpFecha2Vacaciones.Value, "VACACIONES");
            }
            else
            {
                MessageBox.Show("Favor de Insertar un Plazo Correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //MÉTODO PARA INSERTAR LA SOLICITUD A LA BASE DE DATOS CON TODOS LOS DATOS OBTENIDOS ANTERIORMENTE
        private void enviarSolicitud(int nomina, string tipo_permiso, int dias_pedidos, DateTime fecha_inicio, DateTime fecha_final, string motivo)
        {
            SqlCommand sqlCmd2;
            //EN CASO DE QUE LA SOLICITUD SEA DEL DIRECTOR, SERÁ APROBADA AUTOMÁTICAMENTE EN EL CAMPO DE JEFE DIRECTO
            // TENIENDO QUE SER SOLAMENTE APROBADA POR RECURSOS HUMANOS.
            if (VariablesGlobales.emailUsuario == "lomelin@teleton-son.org.mx")
            {
                 sqlCmd2 = new SqlCommand("INSERT INTO SOLICITUD_VACACIONES (nomina, tipo_permiso, dias_pedidos, fecha_inicio, fecha_final, motivo, estado_rh, estado_jefe) VALUES " +
                       "(" + nomina + ", '" + tipo_permiso + "', " + dias_pedidos + ", '" + fecha_inicio.ToString("MM/dd/yyyy HH:mm") + "', '" + fecha_final.ToString("MM/dd/yyyy HH:mm") + "', '" + motivo + "', 'PENDIENTE', 'APROBADA' )", conexion);
            }
            else
            {
                 sqlCmd2 = new SqlCommand("INSERT INTO SOLICITUD_VACACIONES (nomina, tipo_permiso, dias_pedidos, fecha_inicio, fecha_final, motivo, estado_rh, estado_jefe) VALUES " +
                       "(" + nomina + ", '" + tipo_permiso + "', " + dias_pedidos + ", '" + fecha_inicio.ToString("MM/dd/yyyy HH:mm") + "', '" + fecha_final.ToString("MM/dd/yyyy HH:mm") + "', '" + motivo + "', 'PENDIENTE', 'PENDIENTE' )", conexion);
            }
            conexion.Open();
            try
            {
                sqlCmd2.ExecuteNonQuery();
                MessageBox.Show("Se ha enviado exitosamente la solicitud.", "Petición Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //enviarCorreo();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
            dtpHora2.Value = dtpHora.Value.Date + dtpHora2.Value.TimeOfDay;
        }

        private void dtpHora2_ValueChanged(object sender, EventArgs e)
        {
            dtpHora.Value = dtpHora2.Value.Date + dtpHora.Value.TimeOfDay;
        }

        //BOTON PARA REGRESAR AL MENÚ PRINCIPAL O SUPER DEPENDIENDO DEL TIPO DE USUARIO.
        private void pbxRegresar_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "admin" || tipoUsuario == "jefe" || tipoUsuario == "jefe_almacen" || tipoUsuario == "vacaciones")
            {
                frmMenuSuper frmMenuSuper = new frmMenuSuper();
                frmMenuSuper.Show();
                this.Dispose();
            }
            else
            {
                Form frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Dispose();
            }
        }

    }


}
