
namespace PermisosVacacionales
{
    partial class frmActualizarVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarVacaciones));
            this.nudDiasVacacionesPedidos = new System.Windows.Forms.NumericUpDown();
            this.dtpDiaEntrada = new System.Windows.Forms.DateTimePicker();
            this.tbxCorreoJefe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudDiasExtra = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNombreActualizar = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            this.lblDiasDisponibles = new System.Windows.Forms.Label();
            this.gbxDiasExtra = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasVacacionesPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.gbxDiasExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDiasVacacionesPedidos
            // 
            this.nudDiasVacacionesPedidos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nudDiasVacacionesPedidos.Location = new System.Drawing.Point(255, 151);
            this.nudDiasVacacionesPedidos.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudDiasVacacionesPedidos.Name = "nudDiasVacacionesPedidos";
            this.nudDiasVacacionesPedidos.Size = new System.Drawing.Size(315, 27);
            this.nudDiasVacacionesPedidos.TabIndex = 49;
            // 
            // dtpDiaEntrada
            // 
            this.dtpDiaEntrada.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpDiaEntrada.Location = new System.Drawing.Point(255, 114);
            this.dtpDiaEntrada.Name = "dtpDiaEntrada";
            this.dtpDiaEntrada.Size = new System.Drawing.Size(315, 27);
            this.dtpDiaEntrada.TabIndex = 48;
            // 
            // tbxCorreoJefe
            // 
            this.tbxCorreoJefe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbxCorreoJefe.Location = new System.Drawing.Point(255, 188);
            this.tbxCorreoJefe.Name = "tbxCorreoJefe";
            this.tbxCorreoJefe.Size = new System.Drawing.Size(315, 27);
            this.tbxCorreoJefe.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(59, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 21);
            this.label14.TabIndex = 46;
            this.label14.Text = "Correo Jefe Inmediato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(116, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Día de Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Dias de Vacaciones Pedidos:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(255, 221);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(315, 35);
            this.btnLimpiar.TabIndex = 50;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudDiasExtra
            // 
            this.nudDiasExtra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nudDiasExtra.Location = new System.Drawing.Point(186, 31);
            this.nudDiasExtra.Name = "nudDiasExtra";
            this.nudDiasExtra.Size = new System.Drawing.Size(315, 27);
            this.nudDiasExtra.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Agregar Dias Extra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Seleccione Colaborador: ";
            // 
            // cbxNombreActualizar
            // 
            this.cbxNombreActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNombreActualizar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxNombreActualizar.FormattingEnabled = true;
            this.cbxNombreActualizar.Location = new System.Drawing.Point(255, 51);
            this.cbxNombreActualizar.Name = "cbxNombreActualizar";
            this.cbxNombreActualizar.Size = new System.Drawing.Size(315, 29);
            this.cbxNombreActualizar.TabIndex = 39;
            this.cbxNombreActualizar.SelectedIndexChanged += new System.EventHandler(this.cbxNombreActualizar_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(344, 262);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(138, 51);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(12, 12);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(40, 40);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 52;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // lblDiasDisponibles
            // 
            this.lblDiasDisponibles.AutoSize = true;
            this.lblDiasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasDisponibles.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDiasDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblDiasDisponibles.Location = new System.Drawing.Point(12, 452);
            this.lblDiasDisponibles.Name = "lblDiasDisponibles";
            this.lblDiasDisponibles.Size = new System.Drawing.Size(0, 21);
            this.lblDiasDisponibles.TabIndex = 53;
            // 
            // gbxDiasExtra
            // 
            this.gbxDiasExtra.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiasExtra.Controls.Add(this.btnAgregar);
            this.gbxDiasExtra.Controls.Add(this.label2);
            this.gbxDiasExtra.Controls.Add(this.nudDiasExtra);
            this.gbxDiasExtra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gbxDiasExtra.ForeColor = System.Drawing.Color.White;
            this.gbxDiasExtra.Location = new System.Drawing.Point(22, 319);
            this.gbxDiasExtra.Name = "gbxDiasExtra";
            this.gbxDiasExtra.Size = new System.Drawing.Size(548, 127);
            this.gbxDiasExtra.TabIndex = 54;
            this.gbxDiasExtra.TabStop = false;
            this.gbxDiasExtra.Text = "Días Extra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(205, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 51);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmActualizarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PermisosVacacionales.Properties.Resources.Fondo_Teleton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 482);
            this.Controls.Add(this.gbxDiasExtra);
            this.Controls.Add(this.lblDiasDisponibles);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.nudDiasVacacionesPedidos);
            this.Controls.Add(this.cbxNombreActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDiaEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbxCorreoJefe);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 521);
            this.MinimumSize = new System.Drawing.Size(614, 521);
            this.Name = "frmActualizarVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActualizarVacaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmActualizarVacaciones_FormClosed);
            this.Load += new System.EventHandler(this.frmActualizarVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasVacacionesPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.gbxDiasExtra.ResumeLayout(false);
            this.gbxDiasExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiasVacacionesPedidos;
        private System.Windows.Forms.DateTimePicker dtpDiaEntrada;
        private System.Windows.Forms.TextBox tbxCorreoJefe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown nudDiasExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNombreActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pbxRegresar;
        private System.Windows.Forms.Label lblDiasDisponibles;
        private System.Windows.Forms.GroupBox gbxDiasExtra;
        private System.Windows.Forms.Button btnAgregar;
    }
}