using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosVacacionales
{
    public partial class frmDirectorio : Form
    {
        public frmDirectorio()
        {
            InitializeComponent();
        }

        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";
        static string cadena = "Data Source = DESKTOP-H64H067; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";

        SqlConnection conexion = new SqlConnection(cadena);


        private void frmDirectorio_Load(object sender, EventArgs e)
        {
            //SE INICIA CON EL ELEMENTO CERO DEL COMBOBOX (LA PRIMERA PERSONA EN ORDEN ALFABETICO)
            cbxTipoBusqueda.SelectedIndex = 0;

            try
            {
                //CREACIÓN Y EJECUCIÓN DE COMANDO SELECT PARA OBTENER TODOS LOS REGISTROS DE LA TABLA COLABORADORES
                conexion.Open();

                string consulta = "SELECT nombre AS 'Nombre', puesto AS 'Puesto', extension AS 'Extensión', correo AS 'Correo', oficina AS 'Oficina', area AS 'Área' FROM COLABORADORES ORDER BY nombre";
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvColaboradores.ReadOnly = true;
                dgvColaboradores.DataSource = ds.Tables[0];

                dgvColaboradores.BackgroundColor = Color.White;

                DataGridViewColumn column = dgvColaboradores.Columns[0];
                column.Width = 166;

                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo establecer la conexión con el servidor, favor de conectarse a la red local.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //SE USA EL EVENTO TextChanged PARA QUE SE BUSQUE AL COLABORADOR MIENTRAS ESCRIBIMOS
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //CREACIÓN Y EJECUCIÓN DE LA CONSULTA PARA CONSEGUIR A LAS PERSONAS QUE SATISFACEN NUESTRO FILTRO
                conexion.Open();
                string consulta = "SELECT nombre, puesto, extension, correo, oficina, area FROM COLABORADORES WHERE " + cbxTipoBusqueda.Text.Trim() + " LIKE '%" + tbxBuscar.Text.Trim() + "%' ORDER BY nombre";
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvColaboradores.ReadOnly = true;
                dgvColaboradores.DataSource = ds.Tables[0];
                conexion.Close();
            }
            catch (Exception)
            {

            }
        }

        //ESTE EVENTO SE LLAMA CADA VEZ QUE LE DAMOS CLICK A CUALQUIER CELDA DEL DIAGRAMVIEW
        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SE TOMA LA CELDA SELECCIONADA Y EXTRAEMOS TODOS LOS DATOS DE SU RENGLÓN PARA MOSTRARLOS EN LABELS
            tbxNombre.Text = dgvColaboradores.CurrentRow.Cells[0].Value.ToString();
            tbxPuesto.Text = dgvColaboradores.CurrentRow.Cells[1].Value.ToString();
            tbxExtension.Text = dgvColaboradores.CurrentRow.Cells[2].Value.ToString();
            tbxCorreo.Text = dgvColaboradores.CurrentRow.Cells[3].Value.ToString();
            tbxOficina.Text = dgvColaboradores.CurrentRow.Cells[4].Value.ToString();
            tbxArea.Text = dgvColaboradores.CurrentRow.Cells[5].Value.ToString();

            conexion.Open();
            try
            {
                //CREACIÓN Y EJECUCIÓN DE LA CONSULTA PARA OBTENER LA IMAGEN DEL COLABORADOR (EN CASO DE QUE TENGA UNA)
                SqlCommand comandoFoto = new SqlCommand("SELECT imagen FROM COLABORADORES WHERE nombre = '" + tbxNombre.Text + "'", conexion);
                byte[] img = (byte[])comandoFoto.ExecuteScalar();
                MemoryStream ms = new MemoryStream(img);
                pbxImagen.Image = Image.FromStream(ms);

            }
            catch (Exception)
            {
                //SI EL COLABORADOR NO TIENE IMAGEN SIMPLEMENTE NO SE MUESTRA NADA
                pbxImagen.Image = null;
            }
            conexion.Close();
        }

        private void pbxRegresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenuPrincipal();
            MenuPrincipal.Show();
            this.Dispose();
        }

        private void frmDirectorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
