namespace APP_NET.Formularios
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgPerfil = new System.Windows.Forms.PictureBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnMisPublicaciones = new APP_NET.Controls.Bordes_Boton();
            this.BtnReportes = new APP_NET.Controls.Bordes_Boton();
            this.BtnEmpleo = new APP_NET.Controls.Bordes_Boton();
            this.BtnMensajes = new APP_NET.Controls.Bordes_Boton();
            this.btnConexion = new APP_NET.Controls.Bordes_Boton();
            this.btnPerfil = new APP_NET.Controls.Bordes_Boton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).BeginInit();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ImgPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 74);
            this.panel2.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(1135, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 72);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(32, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarContraseñaToolStripMenuItem.Image")));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plataforma Networking";
            // 
            // ImgPerfil
            // 
            this.ImgPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPerfil.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImgPerfil.Location = new System.Drawing.Point(1172, 0);
            this.ImgPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgPerfil.Name = "ImgPerfil";
            this.ImgPerfil.Size = new System.Drawing.Size(87, 74);
            this.ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPerfil.TabIndex = 1;
            this.ImgPerfil.TabStop = false;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpciones.Controls.Add(this.btnMisPublicaciones);
            this.panelOpciones.Controls.Add(this.BtnReportes);
            this.panelOpciones.Controls.Add(this.BtnEmpleo);
            this.panelOpciones.Controls.Add(this.BtnMensajes);
            this.panelOpciones.Controls.Add(this.btnConexion);
            this.panelOpciones.Controls.Add(this.btnPerfil);
            this.panelOpciones.Controls.Add(this.pictureBox1);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 74);
            this.panelOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(270, 818);
            this.panelOpciones.TabIndex = 8;
            // 
            // btnMisPublicaciones
            // 
            this.btnMisPublicaciones.BackColor = System.Drawing.Color.White;
            this.btnMisPublicaciones.BackgroundColor = System.Drawing.Color.White;
            this.btnMisPublicaciones.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnMisPublicaciones.BorderRadius = 40;
            this.btnMisPublicaciones.BorderSize = 0;
            this.btnMisPublicaciones.FlatAppearance.BorderSize = 0;
            this.btnMisPublicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisPublicaciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisPublicaciones.ForeColor = System.Drawing.Color.Black;
            this.btnMisPublicaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnMisPublicaciones.Image")));
            this.btnMisPublicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisPublicaciones.Location = new System.Drawing.Point(13, 381);
            this.btnMisPublicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMisPublicaciones.Name = "btnMisPublicaciones";
            this.btnMisPublicaciones.Size = new System.Drawing.Size(239, 55);
            this.btnMisPublicaciones.TabIndex = 12;
            this.btnMisPublicaciones.Text = "Mis Publicaciones";
            this.btnMisPublicaciones.TextColor = System.Drawing.Color.Black;
            this.btnMisPublicaciones.UseVisualStyleBackColor = false;
            this.btnMisPublicaciones.Click += new System.EventHandler(this.btnMisPublicaciones_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.White;
            this.BtnReportes.BackgroundColor = System.Drawing.Color.White;
            this.BtnReportes.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.BtnReportes.BorderRadius = 40;
            this.BtnReportes.BorderSize = 0;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.Black;
            this.BtnReportes.Image = ((System.Drawing.Image)(resources.GetObject("BtnReportes.Image")));
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(13, 34);
            this.BtnReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(239, 55);
            this.BtnReportes.TabIndex = 11;
            this.BtnReportes.Text = "Estadisticas";
            this.BtnReportes.TextColor = System.Drawing.Color.Black;
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.bordes_Boton5_Click);
            // 
            // BtnEmpleo
            // 
            this.BtnEmpleo.BackColor = System.Drawing.Color.White;
            this.BtnEmpleo.BackgroundColor = System.Drawing.Color.White;
            this.BtnEmpleo.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.BtnEmpleo.BorderRadius = 40;
            this.BtnEmpleo.BorderSize = 0;
            this.BtnEmpleo.FlatAppearance.BorderSize = 0;
            this.BtnEmpleo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleo.ForeColor = System.Drawing.Color.Black;
            this.BtnEmpleo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleo.Image")));
            this.BtnEmpleo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleo.Location = new System.Drawing.Point(13, 300);
            this.BtnEmpleo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEmpleo.Name = "BtnEmpleo";
            this.BtnEmpleo.Size = new System.Drawing.Size(239, 55);
            this.BtnEmpleo.TabIndex = 10;
            this.BtnEmpleo.Text = "Empleos";
            this.BtnEmpleo.TextColor = System.Drawing.Color.Black;
            this.BtnEmpleo.UseVisualStyleBackColor = false;
            this.BtnEmpleo.Click += new System.EventHandler(this.bordes_Boton4_Click);
            // 
            // BtnMensajes
            // 
            this.BtnMensajes.BackColor = System.Drawing.Color.White;
            this.BtnMensajes.BackgroundColor = System.Drawing.Color.White;
            this.BtnMensajes.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.BtnMensajes.BorderRadius = 40;
            this.BtnMensajes.BorderSize = 0;
            this.BtnMensajes.FlatAppearance.BorderSize = 0;
            this.BtnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMensajes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensajes.ForeColor = System.Drawing.Color.Black;
            this.BtnMensajes.Image = ((System.Drawing.Image)(resources.GetObject("BtnMensajes.Image")));
            this.BtnMensajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMensajes.Location = new System.Drawing.Point(13, 226);
            this.BtnMensajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMensajes.Name = "BtnMensajes";
            this.BtnMensajes.Size = new System.Drawing.Size(239, 55);
            this.BtnMensajes.TabIndex = 9;
            this.BtnMensajes.Text = "Mensajes";
            this.BtnMensajes.TextColor = System.Drawing.Color.Black;
            this.BtnMensajes.UseVisualStyleBackColor = false;
            this.BtnMensajes.Click += new System.EventHandler(this.bordes_Boton3_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.White;
            this.btnConexion.BackgroundColor = System.Drawing.Color.White;
            this.btnConexion.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnConexion.BorderRadius = 40;
            this.btnConexion.BorderSize = 0;
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.ForeColor = System.Drawing.Color.Black;
            this.btnConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnConexion.Image")));
            this.btnConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexion.Location = new System.Drawing.Point(13, 157);
            this.btnConexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(239, 55);
            this.btnConexion.TabIndex = 8;
            this.btnConexion.Text = "Conexiones";
            this.btnConexion.TextColor = System.Drawing.Color.Black;
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.bordes_Boton2_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.White;
            this.btnPerfil.BackgroundColor = System.Drawing.Color.White;
            this.btnPerfil.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnPerfil.BorderRadius = 40;
            this.btnPerfil.BorderSize = 0;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(13, 96);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(239, 55);
            this.btnPerfil.TabIndex = 7;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextColor = System.Drawing.Color.Black;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.bordes_Boton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 666);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnCentral
            // 
            this.pnCentral.BackColor = System.Drawing.SystemColors.Control;
            this.pnCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnCentral.Location = new System.Drawing.Point(270, 74);
            this.pnCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(989, 818);
            this.pnCentral.TabIndex = 9;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 892);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox ImgPerfil;
        public System.Windows.Forms.Panel pnCentral;
        public Controls.Bordes_Boton btnMisPublicaciones;
        public Controls.Bordes_Boton btnPerfil;
        public Controls.Bordes_Boton BtnMensajes;
        public Controls.Bordes_Boton btnConexion;
        public Controls.Bordes_Boton BtnReportes;
        public Controls.Bordes_Boton BtnEmpleo;
    }
}