namespace APP_NET
{
    partial class FrmAgregarPublicacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalarioMax = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSalarioMinimo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbExperiencia = new System.Windows.Forms.Label();
            this.btnExperiencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbModalidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbJornada = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.TextBox();
            this.btnRegresar = new APP_NET.Controls.Bordes_Boton();
            this.btnAgregarPublicacion = new APP_NET.Controls.Bordes_Boton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 58);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar  Publicación";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "------------";
            // 
            // btnSalarioMax
            // 
            this.btnSalarioMax.BorderRadius = 15;
            this.btnSalarioMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSalarioMax.DefaultText = "";
            this.btnSalarioMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSalarioMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnSalarioMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSalarioMax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSalarioMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSalarioMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalarioMax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSalarioMax.Location = new System.Drawing.Point(366, 268);
            this.btnSalarioMax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalarioMax.Name = "btnSalarioMax";
            this.btnSalarioMax.PlaceholderText = "Maximo";
            this.btnSalarioMax.SelectedText = "";
            this.btnSalarioMax.Size = new System.Drawing.Size(128, 32);
            this.btnSalarioMax.TabIndex = 55;
            // 
            // BtnSalarioMinimo
            // 
            this.BtnSalarioMinimo.BorderRadius = 15;
            this.BtnSalarioMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BtnSalarioMinimo.DefaultText = "";
            this.BtnSalarioMinimo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BtnSalarioMinimo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BtnSalarioMinimo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BtnSalarioMinimo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BtnSalarioMinimo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BtnSalarioMinimo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSalarioMinimo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BtnSalarioMinimo.Location = new System.Drawing.Point(212, 268);
            this.BtnSalarioMinimo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSalarioMinimo.Name = "BtnSalarioMinimo";
            this.BtnSalarioMinimo.PlaceholderText = "Minimo";
            this.BtnSalarioMinimo.SelectedText = "";
            this.BtnSalarioMinimo.Size = new System.Drawing.Size(128, 32);
            this.BtnSalarioMinimo.TabIndex = 54;
            // 
            // lbSalario
            // 
            this.lbSalario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.Location = new System.Drawing.Point(300, 246);
            this.lbSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(116, 19);
            this.lbSalario.TabIndex = 53;
            this.lbSalario.Text = "Rango Salarial";
            // 
            // lbExperiencia
            // 
            this.lbExperiencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExperiencia.Location = new System.Drawing.Point(17, 246);
            this.lbExperiencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExperiencia.Name = "lbExperiencia";
            this.lbExperiencia.Size = new System.Drawing.Size(184, 19);
            this.lbExperiencia.TabIndex = 52;
            this.lbExperiencia.Text = "Experiencia Minima Requerida";
            // 
            // btnExperiencia
            // 
            this.btnExperiencia.BorderRadius = 15;
            this.btnExperiencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnExperiencia.DefaultText = "";
            this.btnExperiencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnExperiencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnExperiencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnExperiencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnExperiencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExperiencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExperiencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExperiencia.Location = new System.Drawing.Point(17, 268);
            this.btnExperiencia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExperiencia.Name = "btnExperiencia";
            this.btnExperiencia.PlaceholderText = "Experiencia";
            this.btnExperiencia.SelectedText = "";
            this.btnExperiencia.Size = new System.Drawing.Size(128, 32);
            this.btnExperiencia.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Jornada Laboral";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Modalidad";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategoria.BorderRadius = 15;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategoria.ItemHeight = 30;
            this.cmbCategoria.Location = new System.Drawing.Point(11, 192);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(174, 36);
            this.cmbCategoria.TabIndex = 57;
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.BackColor = System.Drawing.Color.Transparent;
            this.cmbModalidad.BorderRadius = 15;
            this.cmbModalidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbModalidad.ItemHeight = 30;
            this.cmbModalidad.Location = new System.Drawing.Point(253, 192);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(176, 36);
            this.cmbModalidad.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Titulo de la Publicaciòn";
            // 
            // btnTitulo
            // 
            this.btnTitulo.BorderRadius = 15;
            this.btnTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTitulo.DefaultText = "";
            this.btnTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTitulo.Location = new System.Drawing.Point(11, 117);
            this.btnTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.PlaceholderText = "Titulo";
            this.btnTitulo.SelectedText = "";
            this.btnTitulo.Size = new System.Drawing.Size(635, 32);
            this.btnTitulo.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Ciudad";
            // 
            // cmbJornada
            // 
            this.cmbJornada.BackColor = System.Drawing.Color.Transparent;
            this.cmbJornada.BorderRadius = 15;
            this.cmbJornada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJornada.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJornada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJornada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbJornada.ItemHeight = 30;
            this.cmbJornada.Location = new System.Drawing.Point(494, 192);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(2);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(180, 36);
            this.cmbJornada.TabIndex = 59;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.Transparent;
            this.cmbCiudad.BorderRadius = 15;
            this.cmbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCiudad.ItemHeight = 30;
            this.cmbCiudad.Location = new System.Drawing.Point(506, 267);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(180, 36);
            this.cmbCiudad.TabIndex = 63;
            this.cmbCiudad.DropDown += new System.EventHandler(this.cmbCiudad_DropDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 331);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Descripción de la Publicaciòn";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(20, 364);
            this.btnDescripcion.Multiline = true;
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(666, 147);
            this.btnDescripcion.TabIndex = 65;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRegresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnRegresar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnRegresar.BorderRadius = 32;
            this.btnRegresar.BorderSize = 0;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(20, 528);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(136, 32);
            this.btnRegresar.TabIndex = 67;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextColor = System.Drawing.Color.White;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPublicacion
            // 
            this.btnAgregarPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnAgregarPublicacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnAgregarPublicacion.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarPublicacion.BorderRadius = 32;
            this.btnAgregarPublicacion.BorderSize = 0;
            this.btnAgregarPublicacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarPublicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPublicacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPublicacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPublicacion.Location = new System.Drawing.Point(494, 528);
            this.btnAgregarPublicacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPublicacion.Name = "btnAgregarPublicacion";
            this.btnAgregarPublicacion.Size = new System.Drawing.Size(187, 32);
            this.btnAgregarPublicacion.TabIndex = 66;
            this.btnAgregarPublicacion.Text = "Agregar Publicacion";
            this.btnAgregarPublicacion.TextColor = System.Drawing.Color.White;
            this.btnAgregarPublicacion.UseVisualStyleBackColor = false;
            this.btnAgregarPublicacion.Click += new System.EventHandler(this.btnAgregarPublicacion_Click);
            // 
            // FrmAgregarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(747, 604);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarPublicacion);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalarioMax);
            this.Controls.Add(this.BtnSalarioMinimo);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbExperiencia);
            this.Controls.Add(this.btnExperiencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarPublicacion";
            this.Text = "FrmAgregarEditarPublicacion";
            this.Load += new System.EventHandler(this.FrmAgregarEditarPublicacion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAgregarPublicacion_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox btnSalarioMax;
        public Guna.UI2.WinForms.Guna2TextBox BtnSalarioMinimo;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbExperiencia;
        public Guna.UI2.WinForms.Guna2TextBox btnExperiencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModalidad;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox btnTitulo;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJornada;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox btnDescripcion;
        private Controls.Bordes_Boton btnAgregarPublicacion;
        private Controls.Bordes_Boton btnRegresar;
    }
}