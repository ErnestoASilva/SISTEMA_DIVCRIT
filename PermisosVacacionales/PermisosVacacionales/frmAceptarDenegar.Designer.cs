
namespace PermisosVacacionales
{
    partial class frmAceptarDenegar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAceptarDenegar));
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.cbxEstadoLista = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.lblNomina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoPermiso = new System.Windows.Forms.Label();
            this.lblDiasPedidos = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblEstadoRH = new System.Windows.Forms.Label();
            this.lblEstadoJefe = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxSolicitud = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.gbxSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 81);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(545, 486);
            this.dgvSolicitudes.TabIndex = 0;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellClick);
            this.dgvSolicitudes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_RowEnter);
            // 
            // cbxEstadoLista
            // 
            this.cbxEstadoLista.FormattingEnabled = true;
            this.cbxEstadoLista.Items.AddRange(new object[] {
            "PENDIENTE",
            "APROBADA",
            "RECHAZADA",
            "TODOS"});
            this.cbxEstadoLista.Location = new System.Drawing.Point(82, 56);
            this.cbxEstadoLista.Name = "cbxEstadoLista";
            this.cbxEstadoLista.Size = new System.Drawing.Size(141, 21);
            this.cbxEstadoLista.TabIndex = 2;
            this.cbxEstadoLista.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoLista_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(219, 447);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 42);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDenegar
            // 
            this.btnDenegar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDenegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDenegar.ForeColor = System.Drawing.Color.Black;
            this.btnDenegar.Location = new System.Drawing.Point(93, 447);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(120, 42);
            this.btnDenegar.TabIndex = 4;
            this.btnDenegar.Text = "DENEGAR";
            this.btnDenegar.UseVisualStyleBackColor = true;
            this.btnDenegar.Click += new System.EventHandler(this.btnDenegar_Click);
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.BackColor = System.Drawing.Color.Transparent;
            this.lblNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomina.ForeColor = System.Drawing.Color.White;
            this.lblNomina.Location = new System.Drawing.Point(6, 34);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(67, 20);
            this.lblNomina.TabIndex = 5;
            this.lblNomina.Text = "Nómina:";
            this.lblNomina.Click += new System.EventHandler(this.lblNomina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estado:";
            // 
            // lblTipoPermiso
            // 
            this.lblTipoPermiso.AutoSize = true;
            this.lblTipoPermiso.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPermiso.ForeColor = System.Drawing.Color.White;
            this.lblTipoPermiso.Location = new System.Drawing.Point(6, 92);
            this.lblTipoPermiso.Name = "lblTipoPermiso";
            this.lblTipoPermiso.Size = new System.Drawing.Size(126, 20);
            this.lblTipoPermiso.TabIndex = 7;
            this.lblTipoPermiso.Text = "Tipo de Permiso:";
            // 
            // lblDiasPedidos
            // 
            this.lblDiasPedidos.AutoSize = true;
            this.lblDiasPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiasPedidos.ForeColor = System.Drawing.Color.White;
            this.lblDiasPedidos.Location = new System.Drawing.Point(6, 121);
            this.lblDiasPedidos.Name = "lblDiasPedidos";
            this.lblDiasPedidos.Size = new System.Drawing.Size(106, 20);
            this.lblDiasPedidos.TabIndex = 8;
            this.lblDiasPedidos.Text = "Días Pedidos:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 150);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(102, 20);
            this.lblFechaInicio.TabIndex = 9;
            this.lblFechaInicio.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.White;
            this.lblFechaFinal.Location = new System.Drawing.Point(6, 179);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(96, 20);
            this.lblFechaFinal.TabIndex = 10;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotivo.ForeColor = System.Drawing.Color.White;
            this.lblMotivo.Location = new System.Drawing.Point(6, 208);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(59, 20);
            this.lblMotivo.TabIndex = 11;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblEstadoRH
            // 
            this.lblEstadoRH.AutoSize = true;
            this.lblEstadoRH.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstadoRH.ForeColor = System.Drawing.Color.White;
            this.lblEstadoRH.Location = new System.Drawing.Point(6, 333);
            this.lblEstadoRH.Name = "lblEstadoRH";
            this.lblEstadoRH.Size = new System.Drawing.Size(66, 20);
            this.lblEstadoRH.TabIndex = 12;
            this.lblEstadoRH.Text = "[estado]";
            // 
            // lblEstadoJefe
            // 
            this.lblEstadoJefe.AutoSize = true;
            this.lblEstadoJefe.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstadoJefe.ForeColor = System.Drawing.Color.White;
            this.lblEstadoJefe.Location = new System.Drawing.Point(6, 389);
            this.lblEstadoJefe.Name = "lblEstadoJefe";
            this.lblEstadoJefe.Size = new System.Drawing.Size(66, 20);
            this.lblEstadoJefe.TabIndex = 13;
            this.lblEstadoJefe.Text = "[estado]";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(6, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbxSolicitud
            // 
            this.gbxSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSolicitud.BackColor = System.Drawing.Color.Transparent;
            this.gbxSolicitud.Controls.Add(this.label2);
            this.gbxSolicitud.Controls.Add(this.label3);
            this.gbxSolicitud.Controls.Add(this.rtbMotivo);
            this.gbxSolicitud.Controls.Add(this.btnDenegar);
            this.gbxSolicitud.Controls.Add(this.btnAceptar);
            this.gbxSolicitud.Controls.Add(this.lblEstadoJefe);
            this.gbxSolicitud.Controls.Add(this.lblNombre);
            this.gbxSolicitud.Controls.Add(this.lblNomina);
            this.gbxSolicitud.Controls.Add(this.lblTipoPermiso);
            this.gbxSolicitud.Controls.Add(this.lblEstadoRH);
            this.gbxSolicitud.Controls.Add(this.lblDiasPedidos);
            this.gbxSolicitud.Controls.Add(this.lblMotivo);
            this.gbxSolicitud.Controls.Add(this.lblFechaInicio);
            this.gbxSolicitud.Controls.Add(this.lblFechaFinal);
            this.gbxSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxSolicitud.ForeColor = System.Drawing.Color.White;
            this.gbxSolicitud.Location = new System.Drawing.Point(573, 72);
            this.gbxSolicitud.Name = "gbxSolicitud";
            this.gbxSolicitud.Size = new System.Drawing.Size(433, 495);
            this.gbxSolicitud.TabIndex = 15;
            this.gbxSolicitud.TabStop = false;
            this.gbxSolicitud.Text = "Solicitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estado de Solicitud a Jefe Directo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado de Solicitud a Recursos Humanos:";
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMotivo.Enabled = false;
            this.rtbMotivo.Location = new System.Drawing.Point(10, 232);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(411, 63);
            this.rtbMotivo.TabIndex = 15;
            this.rtbMotivo.Text = "";
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(16, 12);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(40, 40);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 18;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // frmAceptarDenegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 585);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.gbxSolicitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoLista);
            this.Controls.Add(this.dgvSolicitudes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1034, 624);
            this.Name = "frmAceptarDenegar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes Pendientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAceptarDenegar_FormClosed);
            this.Load += new System.EventHandler(this.frmAceptarDenegar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.gbxSolicitud.ResumeLayout(false);
            this.gbxSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.ComboBox cbxEstadoLista;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDenegar;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoPermiso;
        private System.Windows.Forms.Label lblDiasPedidos;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblEstadoRH;
        private System.Windows.Forms.Label lblEstadoJefe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbxSolicitud;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxRegresar;
    }
}