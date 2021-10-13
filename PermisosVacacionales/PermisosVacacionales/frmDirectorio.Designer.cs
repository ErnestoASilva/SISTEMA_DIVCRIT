
namespace PermisosVacacionales
{
    partial class frmDirectorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectorio));
            this.cbxTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.tbxOficina = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.tbxExtension = new System.Windows.Forms.TextBox();
            this.tbxPuesto = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipoBusqueda
            // 
            this.cbxTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoBusqueda.FormattingEnabled = true;
            this.cbxTipoBusqueda.Items.AddRange(new object[] {
            "nombre",
            "area"});
            this.cbxTipoBusqueda.Location = new System.Drawing.Point(12, 79);
            this.cbxTipoBusqueda.Name = "cbxTipoBusqueda";
            this.cbxTipoBusqueda.Size = new System.Drawing.Size(170, 28);
            this.cbxTipoBusqueda.TabIndex = 11;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCorreo.Enabled = false;
            this.tbxCorreo.Location = new System.Drawing.Point(92, 139);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(365, 26);
            this.tbxCorreo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Correo: ";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.Location = new System.Drawing.Point(182, 258);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(129, 109);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 14;
            this.pbxImagen.TabStop = false;
            // 
            // tbxArea
            // 
            this.tbxArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxArea.Enabled = false;
            this.tbxArea.Location = new System.Drawing.Point(92, 215);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(365, 26);
            this.tbxArea.TabIndex = 13;
            // 
            // tbxOficina
            // 
            this.tbxOficina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOficina.Enabled = false;
            this.tbxOficina.Location = new System.Drawing.Point(92, 177);
            this.tbxOficina.Name = "tbxOficina";
            this.tbxOficina.Size = new System.Drawing.Size(365, 26);
            this.tbxOficina.TabIndex = 12;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(8, 56);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(65, 20);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(12, 109);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(191, 26);
            this.tbxBuscar.TabIndex = 7;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // tbxExtension
            // 
            this.tbxExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExtension.Enabled = false;
            this.tbxExtension.Location = new System.Drawing.Point(92, 101);
            this.tbxExtension.Name = "tbxExtension";
            this.tbxExtension.Size = new System.Drawing.Size(365, 26);
            this.tbxExtension.TabIndex = 11;
            // 
            // tbxPuesto
            // 
            this.tbxPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPuesto.Enabled = false;
            this.tbxPuesto.Location = new System.Drawing.Point(92, 63);
            this.tbxPuesto.Name = "tbxPuesto";
            this.tbxPuesto.Size = new System.Drawing.Size(365, 26);
            this.tbxPuesto.TabIndex = 10;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNombre.Enabled = false;
            this.tbxNombre.Location = new System.Drawing.Point(92, 25);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(365, 26);
            this.tbxNombre.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(6, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Área: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Oficina: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Extensión: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puesto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbxDatos.Controls.Add(this.tbxCorreo);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.pbxImagen);
            this.gbxDatos.Controls.Add(this.tbxArea);
            this.gbxDatos.Controls.Add(this.tbxOficina);
            this.gbxDatos.Controls.Add(this.tbxExtension);
            this.gbxDatos.Controls.Add(this.tbxPuesto);
            this.gbxDatos.Controls.Add(this.tbxNombre);
            this.gbxDatos.Controls.Add(this.label9);
            this.gbxDatos.Controls.Add(this.label7);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.Location = new System.Drawing.Point(410, 130);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(479, 392);
            this.gbxDatos.TabIndex = 9;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Colaborador";
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            this.dgvColaboradores.AllowUserToResizeRows = false;
            this.dgvColaboradores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvColaboradores.BackgroundColor = System.Drawing.Color.White;
            this.dgvColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvColaboradores.Location = new System.Drawing.Point(12, 140);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.Size = new System.Drawing.Size(379, 382);
            this.dgvColaboradores.TabIndex = 6;
            this.dgvColaboradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradores_CellClick);
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(12, 12);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(40, 40);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 18;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // frmDirectorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PermisosVacacionales.Properties.Resources.Fondo_Teleton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 534);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.cbxTipoBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.dgvColaboradores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(917, 555);
            this.Name = "frmDirectorio";
            this.Text = "frmDirectorio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDirectorio_FormClosed);
            this.Load += new System.EventHandler(this.frmDirectorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoBusqueda;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.TextBox tbxOficina;
        private System.Windows.Forms.Label lblBuscar;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox tbxExtension;
        private System.Windows.Forms.TextBox tbxPuesto;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.PictureBox pbxRegresar;
    }
}