﻿
namespace PermisosVacacionales
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnVacaciones = new System.Windows.Forms.Button();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCaus = new System.Windows.Forms.Button();
            this.pbxCerrarSesion = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNomina = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVacaciones
            // 
            this.btnVacaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVacaciones.BackColor = System.Drawing.Color.Purple;
            this.btnVacaciones.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnVacaciones.ForeColor = System.Drawing.Color.White;
            this.btnVacaciones.Location = new System.Drawing.Point(13, 182);
            this.btnVacaciones.Name = "btnVacaciones";
            this.btnVacaciones.Size = new System.Drawing.Size(266, 149);
            this.btnVacaciones.TabIndex = 0;
            this.btnVacaciones.Text = "PERMISOS Y VACACIONES";
            this.btnVacaciones.UseVisualStyleBackColor = false;
            this.btnVacaciones.Click += new System.EventHandler(this.btnVacaciones_Click);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDirectorio.BackColor = System.Drawing.Color.Purple;
            this.btnDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDirectorio.ForeColor = System.Drawing.Color.White;
            this.btnDirectorio.Location = new System.Drawing.Point(285, 182);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(267, 149);
            this.btnDirectorio.TabIndex = 1;
            this.btnDirectorio.Text = "DIRECTORIO COLABORADORES";
            this.btnDirectorio.UseVisualStyleBackColor = false;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.BackColor = System.Drawing.Color.Purple;
            this.btnCheckIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(13, 337);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(266, 149);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "ALTA COLABORADORES";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCaus
            // 
            this.btnCaus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaus.BackColor = System.Drawing.Color.Purple;
            this.btnCaus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCaus.ForeColor = System.Drawing.Color.White;
            this.btnCaus.Location = new System.Drawing.Point(285, 337);
            this.btnCaus.Name = "btnCaus";
            this.btnCaus.Size = new System.Drawing.Size(267, 149);
            this.btnCaus.TabIndex = 3;
            this.btnCaus.Text = "CAUS";
            this.btnCaus.UseVisualStyleBackColor = false;
            // 
            // pbxCerrarSesion
            // 
            this.pbxCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.pbxCerrarSesion.Image = global::PermisosVacacionales.Properties.Resources.cerrar_sesion;
            this.pbxCerrarSesion.Location = new System.Drawing.Point(12, 12);
            this.pbxCerrarSesion.Name = "pbxCerrarSesion";
            this.pbxCerrarSesion.Size = new System.Drawing.Size(40, 40);
            this.pbxCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrarSesion.TabIndex = 4;
            this.pbxCerrarSesion.TabStop = false;
            this.pbxCerrarSesion.Click += new System.EventHandler(this.pbxCerrarSesion_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoEllipsis = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(124, 114);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(428, 21);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "[Correo]";
            // 
            // lblNomina
            // 
            this.lblNomina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomina.AutoEllipsis = true;
            this.lblNomina.BackColor = System.Drawing.Color.Transparent;
            this.lblNomina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomina.ForeColor = System.Drawing.Color.White;
            this.lblNomina.Location = new System.Drawing.Point(124, 93);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(428, 21);
            this.lblNomina.TabIndex = 14;
            this.lblNomina.Text = "[Nomina]";
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoEllipsis = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(124, 156);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(428, 21);
            this.lblPuesto.TabIndex = 13;
            this.lblPuesto.Text = "[Puesto]";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoEllipsis = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(124, 135);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(428, 21);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "[Area]";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(124, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(428, 25);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "[Nombre]";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxImagen.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagen.Image = global::PermisosVacacionales.Properties.Resources.IconoUsuario;
            this.pbxImagen.Location = new System.Drawing.Point(12, 58);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(106, 118);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 16;
            this.pbxImagen.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PermisosVacacionales.Properties.Resources.Fondo_Teleton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 494);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbxCerrarSesion);
            this.Controls.Add(this.btnCaus);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.btnVacaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(844, 533);
            this.MinimumSize = new System.Drawing.Size(580, 533);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVacaciones;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCaus;
        private System.Windows.Forms.PictureBox pbxCerrarSesion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxImagen;
    }
}