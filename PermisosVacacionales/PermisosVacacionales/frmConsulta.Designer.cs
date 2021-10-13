
namespace PermisosVacacionales
{
    partial class frmConsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNomina = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.lblDiasDisponibles = new System.Windows.Forms.Label();
            this.lblPermiso_Dias = new System.Windows.Forms.Label();
            this.labelPersmisos = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.dtpFecha1CG = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpFecha2CG = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpSolicitud = new System.Windows.Forms.TabControl();
            this.tabConGoce = new System.Windows.Forms.TabPage();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.tbxOtro = new System.Windows.Forms.TextBox();
            this.rbtFallecimiento = new System.Windows.Forms.RadioButton();
            this.tbxFallecimiento = new System.Windows.Forms.TextBox();
            this.rbtNacimiento = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtMatrimonio = new System.Windows.Forms.RadioButton();
            this.btnSolicitarCG = new System.Windows.Forms.Button();
            this.rbtComision = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtCursos = new System.Windows.Forms.RadioButton();
            this.lblDiasCalcualdos = new System.Windows.Forms.Label();
            this.rbtTitulacion = new System.Windows.Forms.RadioButton();
            this.tabSinGoce = new System.Windows.Forms.TabPage();
            this.rtbxSinGoce = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSolicitarSG = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDiasSinGoce = new System.Windows.Forms.Label();
            this.rbtFaltaInjustificada = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFecha1SG = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2SG = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabHoras = new System.Windows.Forms.TabPage();
            this.dtpHora2 = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.rtbxMotivoHora = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSolicitarHoras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabVacaciones = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDiasCalculadosVacaciones = new System.Windows.Forms.Label();
            this.btnSolicitarVacaciones = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFecha1Vacaciones = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2Vacaciones = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPermiso_Horas = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPermiso_SinGoce = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.tbpSolicitud.SuspendLayout();
            this.tabConGoce.SuspendLayout();
            this.tabSinGoce.SuspendLayout();
            this.tabHoras.SuspendLayout();
            this.tabVacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbxFoto.Image = global::PermisosVacacionales.Properties.Resources.IconoUsuario;
            this.pbxFoto.Location = new System.Drawing.Point(12, 64);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(105, 119);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(124, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(541, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "[Nombre]";
            // 
            // lblArea
            // 
            this.lblArea.AutoEllipsis = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(124, 141);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(543, 21);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "[Area]";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoEllipsis = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(124, 162);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(543, 21);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "[Puesto]";
            // 
            // lblNomina
            // 
            this.lblNomina.AutoEllipsis = true;
            this.lblNomina.BackColor = System.Drawing.Color.Transparent;
            this.lblNomina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomina.ForeColor = System.Drawing.Color.White;
            this.lblNomina.Location = new System.Drawing.Point(124, 99);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(541, 21);
            this.lblNomina.TabIndex = 4;
            this.lblNomina.Text = "[Nomina]";
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.BackColor = System.Drawing.Color.Transparent;
            this.labelDias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDias.ForeColor = System.Drawing.Color.White;
            this.labelDias.Location = new System.Drawing.Point(12, 204);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(252, 21);
            this.labelDias.TabIndex = 5;
            this.labelDias.Text = "Dias de Vacaciones Disponibles";
            // 
            // lblDiasDisponibles
            // 
            this.lblDiasDisponibles.AutoSize = true;
            this.lblDiasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasDisponibles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblDiasDisponibles.Location = new System.Drawing.Point(12, 225);
            this.lblDiasDisponibles.Name = "lblDiasDisponibles";
            this.lblDiasDisponibles.Size = new System.Drawing.Size(53, 21);
            this.lblDiasDisponibles.TabIndex = 6;
            this.lblDiasDisponibles.Text = "[dias]";
            // 
            // lblPermiso_Dias
            // 
            this.lblPermiso_Dias.AutoSize = true;
            this.lblPermiso_Dias.BackColor = System.Drawing.Color.Transparent;
            this.lblPermiso_Dias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso_Dias.ForeColor = System.Drawing.Color.White;
            this.lblPermiso_Dias.Location = new System.Drawing.Point(12, 289);
            this.lblPermiso_Dias.Name = "lblPermiso_Dias";
            this.lblPermiso_Dias.Size = new System.Drawing.Size(88, 21);
            this.lblPermiso_Dias.TabIndex = 8;
            this.lblPermiso_Dias.Text = "[permisos]";
            // 
            // labelPersmisos
            // 
            this.labelPersmisos.AutoSize = true;
            this.labelPersmisos.BackColor = System.Drawing.Color.Transparent;
            this.labelPersmisos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersmisos.ForeColor = System.Drawing.Color.White;
            this.labelPersmisos.Location = new System.Drawing.Point(12, 268);
            this.labelPersmisos.Name = "labelPersmisos";
            this.labelPersmisos.Size = new System.Drawing.Size(379, 21);
            this.labelPersmisos.TabIndex = 7;
            this.labelPersmisos.Text = "Permisos de Días con Goce de Sueldo Restantes";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoEllipsis = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(124, 120);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(541, 21);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "[Correo]";
            // 
            // dtpFecha1CG
            // 
            this.dtpFecha1CG.Location = new System.Drawing.Point(18, 71);
            this.dtpFecha1CG.Name = "dtpFecha1CG";
            this.dtpFecha1CG.Size = new System.Drawing.Size(404, 27);
            this.dtpFecha1CG.TabIndex = 0;
            this.dtpFecha1CG.ValueChanged += new System.EventHandler(this.dtpFecha1CG_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(8, 556);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 21);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "[Fecha]";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpFecha2CG
            // 
            this.dtpFecha2CG.Location = new System.Drawing.Point(18, 144);
            this.dtpFecha2CG.Name = "dtpFecha2CG";
            this.dtpFecha2CG.Size = new System.Drawing.Size(404, 27);
            this.dtpFecha2CG.TabIndex = 1;
            this.dtpFecha2CG.ValueChanged += new System.EventHandler(this.dtpFecha2CG_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "DEL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "AL:";
            // 
            // tbpSolicitud
            // 
            this.tbpSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpSolicitud.Controls.Add(this.tabConGoce);
            this.tbpSolicitud.Controls.Add(this.tabSinGoce);
            this.tbpSolicitud.Controls.Add(this.tabHoras);
            this.tbpSolicitud.Controls.Add(this.tabVacaciones);
            this.tbpSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbpSolicitud.Location = new System.Drawing.Point(671, 12);
            this.tbpSolicitud.Name = "tbpSolicitud";
            this.tbpSolicitud.SelectedIndex = 0;
            this.tbpSolicitud.Size = new System.Drawing.Size(449, 565);
            this.tbpSolicitud.TabIndex = 12;
            // 
            // tabConGoce
            // 
            this.tabConGoce.BackColor = System.Drawing.Color.Purple;
            this.tabConGoce.Controls.Add(this.rbtOtro);
            this.tabConGoce.Controls.Add(this.tbxOtro);
            this.tabConGoce.Controls.Add(this.rbtFallecimiento);
            this.tabConGoce.Controls.Add(this.tbxFallecimiento);
            this.tabConGoce.Controls.Add(this.rbtNacimiento);
            this.tabConGoce.Controls.Add(this.label1);
            this.tabConGoce.Controls.Add(this.rbtMatrimonio);
            this.tabConGoce.Controls.Add(this.btnSolicitarCG);
            this.tabConGoce.Controls.Add(this.rbtComision);
            this.tabConGoce.Controls.Add(this.label5);
            this.tabConGoce.Controls.Add(this.rbtCursos);
            this.tabConGoce.Controls.Add(this.lblDiasCalcualdos);
            this.tabConGoce.Controls.Add(this.rbtTitulacion);
            this.tabConGoce.Controls.Add(this.label3);
            this.tabConGoce.Controls.Add(this.dtpFecha1CG);
            this.tabConGoce.Controls.Add(this.dtpFecha2CG);
            this.tabConGoce.Controls.Add(this.label2);
            this.tabConGoce.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tabConGoce.Location = new System.Drawing.Point(4, 30);
            this.tabConGoce.Name = "tabConGoce";
            this.tabConGoce.Padding = new System.Windows.Forms.Padding(3);
            this.tabConGoce.Size = new System.Drawing.Size(441, 531);
            this.tabConGoce.TabIndex = 0;
            this.tabConGoce.Text = "Con Goce";
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.ForeColor = System.Drawing.Color.White;
            this.rbtOtro.Location = new System.Drawing.Point(18, 444);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(78, 25);
            this.rbtOtro.TabIndex = 19;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "OTRO:";
            this.rbtOtro.UseVisualStyleBackColor = true;
            this.rbtOtro.CheckedChanged += new System.EventHandler(this.rbtOtro_CheckedChanged);
            // 
            // tbxOtro
            // 
            this.tbxOtro.Enabled = false;
            this.tbxOtro.Location = new System.Drawing.Point(101, 442);
            this.tbxOtro.Name = "tbxOtro";
            this.tbxOtro.Size = new System.Drawing.Size(321, 27);
            this.tbxOtro.TabIndex = 23;
            // 
            // rbtFallecimiento
            // 
            this.rbtFallecimiento.AutoSize = true;
            this.rbtFallecimiento.ForeColor = System.Drawing.Color.White;
            this.rbtFallecimiento.Location = new System.Drawing.Point(18, 411);
            this.rbtFallecimiento.Name = "rbtFallecimiento";
            this.rbtFallecimiento.Size = new System.Drawing.Size(157, 25);
            this.rbtFallecimiento.TabIndex = 18;
            this.rbtFallecimiento.TabStop = true;
            this.rbtFallecimiento.Text = "FALLECIMIENTO:";
            this.rbtFallecimiento.UseVisualStyleBackColor = true;
            this.rbtFallecimiento.CheckedChanged += new System.EventHandler(this.rbtFallecimiento_CheckedChanged);
            // 
            // tbxFallecimiento
            // 
            this.tbxFallecimiento.Enabled = false;
            this.tbxFallecimiento.Location = new System.Drawing.Point(181, 411);
            this.tbxFallecimiento.Name = "tbxFallecimiento";
            this.tbxFallecimiento.Size = new System.Drawing.Size(241, 27);
            this.tbxFallecimiento.TabIndex = 22;
            // 
            // rbtNacimiento
            // 
            this.rbtNacimiento.AutoSize = true;
            this.rbtNacimiento.ForeColor = System.Drawing.Color.White;
            this.rbtNacimiento.Location = new System.Drawing.Point(18, 378);
            this.rbtNacimiento.Name = "rbtNacimiento";
            this.rbtNacimiento.Size = new System.Drawing.Size(209, 25);
            this.rbtNacimiento.TabIndex = 17;
            this.rbtNacimiento.TabStop = true;
            this.rbtNacimiento.Text = "NACIMIENTO DE HIJOS";
            this.rbtNacimiento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "PERMISOS CON GOCE DE SUELDO\r\n";
            // 
            // rbtMatrimonio
            // 
            this.rbtMatrimonio.AutoSize = true;
            this.rbtMatrimonio.ForeColor = System.Drawing.Color.White;
            this.rbtMatrimonio.Location = new System.Drawing.Point(18, 345);
            this.rbtMatrimonio.Name = "rbtMatrimonio";
            this.rbtMatrimonio.Size = new System.Drawing.Size(139, 25);
            this.rbtMatrimonio.TabIndex = 16;
            this.rbtMatrimonio.TabStop = true;
            this.rbtMatrimonio.Text = "MATRIMONIO";
            this.rbtMatrimonio.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarCG
            // 
            this.btnSolicitarCG.Location = new System.Drawing.Point(164, 492);
            this.btnSolicitarCG.Name = "btnSolicitarCG";
            this.btnSolicitarCG.Size = new System.Drawing.Size(112, 33);
            this.btnSolicitarCG.TabIndex = 14;
            this.btnSolicitarCG.Text = "SOLICITAR";
            this.btnSolicitarCG.UseVisualStyleBackColor = true;
            this.btnSolicitarCG.Click += new System.EventHandler(this.btnSolicitarCG_Click);
            // 
            // rbtComision
            // 
            this.rbtComision.AutoSize = true;
            this.rbtComision.ForeColor = System.Drawing.Color.White;
            this.rbtComision.Location = new System.Drawing.Point(18, 312);
            this.rbtComision.Name = "rbtComision";
            this.rbtComision.Size = new System.Drawing.Size(342, 25);
            this.rbtComision.TabIndex = 15;
            this.rbtComision.TabStop = true;
            this.rbtComision.Text = "COMISIÓN (MÉDICA/ADMINISTRATIVA)";
            this.rbtComision.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "ESTAS SOLICITANDO:";
            // 
            // rbtCursos
            // 
            this.rbtCursos.AutoSize = true;
            this.rbtCursos.ForeColor = System.Drawing.Color.White;
            this.rbtCursos.Location = new System.Drawing.Point(18, 279);
            this.rbtCursos.Name = "rbtCursos";
            this.rbtCursos.Size = new System.Drawing.Size(309, 25);
            this.rbtCursos.TabIndex = 14;
            this.rbtCursos.TabStop = true;
            this.rbtCursos.Text = "CURSOS, CONGRESOS, SEMINARIOS";
            this.rbtCursos.UseVisualStyleBackColor = true;
            // 
            // lblDiasCalcualdos
            // 
            this.lblDiasCalcualdos.AutoSize = true;
            this.lblDiasCalcualdos.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasCalcualdos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasCalcualdos.ForeColor = System.Drawing.Color.White;
            this.lblDiasCalcualdos.Location = new System.Drawing.Point(18, 213);
            this.lblDiasCalcualdos.Name = "lblDiasCalcualdos";
            this.lblDiasCalcualdos.Size = new System.Drawing.Size(53, 21);
            this.lblDiasCalcualdos.TabIndex = 13;
            this.lblDiasCalcualdos.Text = "[dias]";
            // 
            // rbtTitulacion
            // 
            this.rbtTitulacion.AutoSize = true;
            this.rbtTitulacion.ForeColor = System.Drawing.Color.White;
            this.rbtTitulacion.Location = new System.Drawing.Point(18, 246);
            this.rbtTitulacion.Name = "rbtTitulacion";
            this.rbtTitulacion.Size = new System.Drawing.Size(124, 25);
            this.rbtTitulacion.TabIndex = 13;
            this.rbtTitulacion.TabStop = true;
            this.rbtTitulacion.Text = "TITULACIÓN";
            this.rbtTitulacion.UseVisualStyleBackColor = true;
            // 
            // tabSinGoce
            // 
            this.tabSinGoce.BackColor = System.Drawing.Color.Purple;
            this.tabSinGoce.Controls.Add(this.rtbxSinGoce);
            this.tabSinGoce.Controls.Add(this.label12);
            this.tabSinGoce.Controls.Add(this.btnSolicitarSG);
            this.tabSinGoce.Controls.Add(this.label8);
            this.tabSinGoce.Controls.Add(this.lblDiasSinGoce);
            this.tabSinGoce.Controls.Add(this.rbtFaltaInjustificada);
            this.tabSinGoce.Controls.Add(this.label10);
            this.tabSinGoce.Controls.Add(this.dtpFecha1SG);
            this.tabSinGoce.Controls.Add(this.dtpFecha2SG);
            this.tabSinGoce.Controls.Add(this.label11);
            this.tabSinGoce.Controls.Add(this.label4);
            this.tabSinGoce.Location = new System.Drawing.Point(4, 30);
            this.tabSinGoce.Name = "tabSinGoce";
            this.tabSinGoce.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinGoce.Size = new System.Drawing.Size(441, 531);
            this.tabSinGoce.TabIndex = 1;
            this.tabSinGoce.Text = "Sin Goce";
            // 
            // rtbxSinGoce
            // 
            this.rtbxSinGoce.Location = new System.Drawing.Point(18, 312);
            this.rtbxSinGoce.Name = "rtbxSinGoce";
            this.rtbxSinGoce.Size = new System.Drawing.Size(404, 88);
            this.rtbxSinGoce.TabIndex = 24;
            this.rtbxSinGoce.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "MOTIVO:";
            // 
            // btnSolicitarSG
            // 
            this.btnSolicitarSG.Location = new System.Drawing.Point(164, 492);
            this.btnSolicitarSG.Name = "btnSolicitarSG";
            this.btnSolicitarSG.Size = new System.Drawing.Size(112, 33);
            this.btnSolicitarSG.TabIndex = 22;
            this.btnSolicitarSG.Text = "SOLICITAR";
            this.btnSolicitarSG.UseVisualStyleBackColor = true;
            this.btnSolicitarSG.Click += new System.EventHandler(this.btnSolicitarSG_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "ESTAS SOLICITANDO:";
            // 
            // lblDiasSinGoce
            // 
            this.lblDiasSinGoce.AutoSize = true;
            this.lblDiasSinGoce.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasSinGoce.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasSinGoce.ForeColor = System.Drawing.Color.White;
            this.lblDiasSinGoce.Location = new System.Drawing.Point(18, 213);
            this.lblDiasSinGoce.Name = "lblDiasSinGoce";
            this.lblDiasSinGoce.Size = new System.Drawing.Size(53, 21);
            this.lblDiasSinGoce.TabIndex = 19;
            this.lblDiasSinGoce.Text = "[dias]";
            // 
            // rbtFaltaInjustificada
            // 
            this.rbtFaltaInjustificada.AutoSize = true;
            this.rbtFaltaInjustificada.ForeColor = System.Drawing.Color.White;
            this.rbtFaltaInjustificada.Location = new System.Drawing.Point(18, 246);
            this.rbtFaltaInjustificada.Name = "rbtFaltaInjustificada";
            this.rbtFaltaInjustificada.Size = new System.Drawing.Size(202, 25);
            this.rbtFaltaInjustificada.TabIndex = 20;
            this.rbtFaltaInjustificada.Text = "FALTA INJUSTIFICADA";
            this.rbtFaltaInjustificada.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "AL:";
            // 
            // dtpFecha1SG
            // 
            this.dtpFecha1SG.Location = new System.Drawing.Point(18, 71);
            this.dtpFecha1SG.Name = "dtpFecha1SG";
            this.dtpFecha1SG.Size = new System.Drawing.Size(404, 27);
            this.dtpFecha1SG.TabIndex = 15;
            this.dtpFecha1SG.ValueChanged += new System.EventHandler(this.dtpFecha1SG_ValueChanged);
            // 
            // dtpFecha2SG
            // 
            this.dtpFecha2SG.Location = new System.Drawing.Point(18, 144);
            this.dtpFecha2SG.Name = "dtpFecha2SG";
            this.dtpFecha2SG.Size = new System.Drawing.Size(404, 27);
            this.dtpFecha2SG.TabIndex = 16;
            this.dtpFecha2SG.ValueChanged += new System.EventHandler(this.dtpFecha2SG_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "DEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "PERMISOS SIN GOCE DE SUELDO";
            // 
            // tabHoras
            // 
            this.tabHoras.BackColor = System.Drawing.Color.Purple;
            this.tabHoras.Controls.Add(this.dtpHora2);
            this.tabHoras.Controls.Add(this.dtpHora);
            this.tabHoras.Controls.Add(this.rtbxMotivoHora);
            this.tabHoras.Controls.Add(this.label24);
            this.tabHoras.Controls.Add(this.label23);
            this.tabHoras.Controls.Add(this.label22);
            this.tabHoras.Controls.Add(this.label21);
            this.tabHoras.Controls.Add(this.btnSolicitarHoras);
            this.tabHoras.Controls.Add(this.label6);
            this.tabHoras.Location = new System.Drawing.Point(4, 30);
            this.tabHoras.Name = "tabHoras";
            this.tabHoras.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoras.Size = new System.Drawing.Size(441, 531);
            this.tabHoras.TabIndex = 2;
            this.tabHoras.Text = "Hora";
            // 
            // dtpHora2
            // 
            this.dtpHora2.Location = new System.Drawing.Point(55, 141);
            this.dtpHora2.Name = "dtpHora2";
            this.dtpHora2.Size = new System.Drawing.Size(363, 27);
            this.dtpHora2.TabIndex = 32;
            this.dtpHora2.Value = new System.DateTime(2021, 9, 20, 0, 0, 0, 0);
            this.dtpHora2.ValueChanged += new System.EventHandler(this.dtpHora2_ValueChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.Location = new System.Drawing.Point(55, 108);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(363, 27);
            this.dtpHora.TabIndex = 31;
            this.dtpHora.Value = new System.DateTime(2021, 9, 20, 0, 0, 0, 0);
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // rtbxMotivoHora
            // 
            this.rtbxMotivoHora.Location = new System.Drawing.Point(18, 226);
            this.rtbxMotivoHora.Name = "rtbxMotivoHora";
            this.rtbxMotivoHora.Size = new System.Drawing.Size(404, 88);
            this.rtbxMotivoHora.TabIndex = 30;
            this.rtbxMotivoHora.Text = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(18, 202);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 21);
            this.label24.TabIndex = 29;
            this.label24.Text = "MOTIVO:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(22, 146);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 21);
            this.label23.TabIndex = 28;
            this.label23.Text = "A:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(14, 113);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 21);
            this.label22.TabIndex = 26;
            this.label22.Text = "DE:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(14, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 21);
            this.label21.TabIndex = 24;
            this.label21.Text = "HORARIO:";
            // 
            // btnSolicitarHoras
            // 
            this.btnSolicitarHoras.Location = new System.Drawing.Point(164, 492);
            this.btnSolicitarHoras.Name = "btnSolicitarHoras";
            this.btnSolicitarHoras.Size = new System.Drawing.Size(112, 33);
            this.btnSolicitarHoras.TabIndex = 23;
            this.btnSolicitarHoras.Text = "SOLICITAR";
            this.btnSolicitarHoras.UseVisualStyleBackColor = true;
            this.btnSolicitarHoras.Click += new System.EventHandler(this.btnSolicitarHoras_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(88, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 50);
            this.label6.TabIndex = 15;
            this.label6.Text = " PERMISOS PARA \r\nAUSENTARSE POR HORAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabVacaciones
            // 
            this.tabVacaciones.BackColor = System.Drawing.Color.Purple;
            this.tabVacaciones.Controls.Add(this.label16);
            this.tabVacaciones.Controls.Add(this.lblDiasCalculadosVacaciones);
            this.tabVacaciones.Controls.Add(this.btnSolicitarVacaciones);
            this.tabVacaciones.Controls.Add(this.label14);
            this.tabVacaciones.Controls.Add(this.dtpFecha1Vacaciones);
            this.tabVacaciones.Controls.Add(this.dtpFecha2Vacaciones);
            this.tabVacaciones.Controls.Add(this.label15);
            this.tabVacaciones.Controls.Add(this.label7);
            this.tabVacaciones.Location = new System.Drawing.Point(4, 30);
            this.tabVacaciones.Name = "tabVacaciones";
            this.tabVacaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacaciones.Size = new System.Drawing.Size(441, 531);
            this.tabVacaciones.TabIndex = 3;
            this.tabVacaciones.Text = "Vacaciones";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(18, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 21);
            this.label16.TabIndex = 24;
            this.label16.Text = "ESTAS SOLICITANDO:";
            // 
            // lblDiasCalculadosVacaciones
            // 
            this.lblDiasCalculadosVacaciones.AutoSize = true;
            this.lblDiasCalculadosVacaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasCalculadosVacaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasCalculadosVacaciones.ForeColor = System.Drawing.Color.White;
            this.lblDiasCalculadosVacaciones.Location = new System.Drawing.Point(18, 216);
            this.lblDiasCalculadosVacaciones.Name = "lblDiasCalculadosVacaciones";
            this.lblDiasCalculadosVacaciones.Size = new System.Drawing.Size(53, 21);
            this.lblDiasCalculadosVacaciones.TabIndex = 25;
            this.lblDiasCalculadosVacaciones.Text = "[dias]";
            // 
            // btnSolicitarVacaciones
            // 
            this.btnSolicitarVacaciones.Location = new System.Drawing.Point(164, 492);
            this.btnSolicitarVacaciones.Name = "btnSolicitarVacaciones";
            this.btnSolicitarVacaciones.Size = new System.Drawing.Size(112, 33);
            this.btnSolicitarVacaciones.TabIndex = 23;
            this.btnSolicitarVacaciones.Text = "SOLICITAR";
            this.btnSolicitarVacaciones.UseVisualStyleBackColor = true;
            this.btnSolicitarVacaciones.Click += new System.EventHandler(this.btnSolicitarVacaciones_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "AL:";
            // 
            // dtpFecha1Vacaciones
            // 
            this.dtpFecha1Vacaciones.Location = new System.Drawing.Point(18, 71);
            this.dtpFecha1Vacaciones.Name = "dtpFecha1Vacaciones";
            this.dtpFecha1Vacaciones.Size = new System.Drawing.Size(404, 27);
            this.dtpFecha1Vacaciones.TabIndex = 17;
            this.dtpFecha1Vacaciones.ValueChanged += new System.EventHandler(this.dtpFecha1Vacaciones_ValueChanged);
            // 
            // dtpFecha2Vacaciones
            // 
            this.dtpFecha2Vacaciones.Location = new System.Drawing.Point(18, 144);
            this.dtpFecha2Vacaciones.Name = "dtpFecha2Vacaciones";
            this.dtpFecha2Vacaciones.Size = new System.Drawing.Size(404, 27);
            this.dtpFecha2Vacaciones.TabIndex = 18;
            this.dtpFecha2Vacaciones.ValueChanged += new System.EventHandler(this.dtpFecha2Vacaciones_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(18, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "DEL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(144, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "VACACIONES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPermiso_Horas
            // 
            this.lblPermiso_Horas.AutoSize = true;
            this.lblPermiso_Horas.BackColor = System.Drawing.Color.Transparent;
            this.lblPermiso_Horas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso_Horas.ForeColor = System.Drawing.Color.White;
            this.lblPermiso_Horas.Location = new System.Drawing.Point(12, 429);
            this.lblPermiso_Horas.Name = "lblPermiso_Horas";
            this.lblPermiso_Horas.Size = new System.Drawing.Size(88, 21);
            this.lblPermiso_Horas.TabIndex = 14;
            this.lblPermiso_Horas.Text = "[permisos]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(227, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Permisos de Horas Restantes";
            // 
            // lblPermiso_SinGoce
            // 
            this.lblPermiso_SinGoce.AutoSize = true;
            this.lblPermiso_SinGoce.BackColor = System.Drawing.Color.Transparent;
            this.lblPermiso_SinGoce.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso_SinGoce.ForeColor = System.Drawing.Color.White;
            this.lblPermiso_SinGoce.Location = new System.Drawing.Point(12, 360);
            this.lblPermiso_SinGoce.Name = "lblPermiso_SinGoce";
            this.lblPermiso_SinGoce.Size = new System.Drawing.Size(88, 21);
            this.lblPermiso_SinGoce.TabIndex = 16;
            this.lblPermiso_SinGoce.Text = "[permisos]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 339);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(370, 21);
            this.label19.TabIndex = 15;
            this.label19.Text = "Permisos de Días Sin Goce de Sueldo Restantes";
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(12, 12);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(40, 40);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 17;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PermisosVacacionales.Properties.Resources.Fondo_Teleton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 589);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.lblPermiso_SinGoce);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblPermiso_Horas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbpSolicitud);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblPermiso_Dias);
            this.Controls.Add(this.labelPersmisos);
            this.Controls.Add(this.lblDiasDisponibles);
            this.Controls.Add(this.labelDias);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbxFoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1148, 628);
            this.MinimumSize = new System.Drawing.Size(1148, 628);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsulta_FormClosed);
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.tbpSolicitud.ResumeLayout(false);
            this.tabConGoce.ResumeLayout(false);
            this.tabConGoce.PerformLayout();
            this.tabSinGoce.ResumeLayout(false);
            this.tabSinGoce.PerformLayout();
            this.tabHoras.ResumeLayout(false);
            this.tabHoras.PerformLayout();
            this.tabVacaciones.ResumeLayout(false);
            this.tabVacaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.Label lblDiasDisponibles;
        private System.Windows.Forms.Label lblPermiso_Dias;
        private System.Windows.Forms.Label labelPersmisos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DateTimePicker dtpFecha1CG;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpFecha2CG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbpSolicitud;
        private System.Windows.Forms.TabPage tabConGoce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiasCalcualdos;
        private System.Windows.Forms.TabPage tabSinGoce;
        private System.Windows.Forms.Button btnSolicitarCG;
        private System.Windows.Forms.TabPage tabHoras;
        private System.Windows.Forms.TabPage tabVacaciones;
        private System.Windows.Forms.TextBox tbxOtro;
        private System.Windows.Forms.TextBox tbxFallecimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtFallecimiento;
        private System.Windows.Forms.RadioButton rbtNacimiento;
        private System.Windows.Forms.RadioButton rbtMatrimonio;
        private System.Windows.Forms.RadioButton rbtComision;
        private System.Windows.Forms.RadioButton rbtCursos;
        private System.Windows.Forms.RadioButton rbtTitulacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDiasSinGoce;
        private System.Windows.Forms.RadioButton rbtFaltaInjustificada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFecha1SG;
        private System.Windows.Forms.DateTimePicker dtpFecha2SG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbxSinGoce;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSolicitarSG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFecha1Vacaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha2Vacaciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPermiso_Horas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSolicitarHoras;
        private System.Windows.Forms.Button btnSolicitarVacaciones;
        private System.Windows.Forms.Label lblPermiso_SinGoce;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpHora2;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.RichTextBox rtbxMotivoHora;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDiasCalculadosVacaciones;
        private System.Windows.Forms.PictureBox pbxRegresar;
    }
}