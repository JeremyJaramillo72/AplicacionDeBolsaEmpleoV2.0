namespace APP_NET
{
    partial class Perfil_Pro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProvincia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Ft_Perfil = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gncmbArea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gncmbTitulo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaño = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AREAS = new APP_NET.Controls.Bordes_Boton();
            this.btnguardar = new APP_NET.Controls.Bordes_Boton();
            this.bordes_Boton1 = new APP_NET.Controls.Bordes_Boton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ft_Perfil)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.check);
            this.panel1.Controls.Add(this.cmbProvincia);
            this.panel1.Controls.Add(this.cmbCiudad);
            this.panel1.Controls.Add(this.Ft_Perfil);
            this.panel1.Controls.Add(this.bordes_Boton1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 783);
            this.panel1.TabIndex = 1;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.Transparent;
            this.cmbProvincia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProvincia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProvincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProvincia.ItemHeight = 30;
            this.cmbProvincia.Location = new System.Drawing.Point(16, 613);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(223, 36);
            this.cmbProvincia.TabIndex = 20;
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincia_SelectionChangeCommitted);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.Transparent;
            this.cmbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCiudad.ItemHeight = 30;
            this.cmbCiudad.Location = new System.Drawing.Point(11, 704);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(223, 36);
            this.cmbCiudad.TabIndex = 19;
            // 
            // Ft_Perfil
            // 
            this.Ft_Perfil.Location = new System.Drawing.Point(31, 78);
            this.Ft_Perfil.Name = "Ft_Perfil";
            this.Ft_Perfil.Size = new System.Drawing.Size(174, 118);
            this.Ft_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ft_Perfil.TabIndex = 17;
            this.Ft_Perfil.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Provincia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idiomas";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Información Personal";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil Profesional";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_AREAS);
            this.panel2.Controls.Add(this.Users);
            this.panel2.Controls.Add(this.gncmbArea);
            this.panel2.Controls.Add(this.gncmbTitulo);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtaño);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 783);
            this.panel2.TabIndex = 2;
            // 
            // Users
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Users.ColumnHeadersHeight = 4;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Users.DefaultCellStyle = dataGridViewCellStyle12;
            this.Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Users.Location = new System.Drawing.Point(634, 77);
            this.Users.Name = "Users";
            this.Users.RowHeadersVisible = false;
            this.Users.RowHeadersWidth = 51;
            this.Users.RowTemplate.Height = 24;
            this.Users.Size = new System.Drawing.Size(18, 10);
            this.Users.TabIndex = 23;
            this.Users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Users.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Users.ThemeStyle.HeaderStyle.Height = 4;
            this.Users.ThemeStyle.ReadOnly = false;
            this.Users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Users.ThemeStyle.RowsStyle.Height = 24;
            this.Users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gncmbArea
            // 
            this.gncmbArea.BackColor = System.Drawing.Color.Transparent;
            this.gncmbArea.BorderRadius = 15;
            this.gncmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gncmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gncmbArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gncmbArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gncmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gncmbArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gncmbArea.ItemHeight = 30;
            this.gncmbArea.Location = new System.Drawing.Point(359, 160);
            this.gncmbArea.Name = "gncmbArea";
            this.gncmbArea.Size = new System.Drawing.Size(271, 36);
            this.gncmbArea.TabIndex = 22;
            // 
            // gncmbTitulo
            // 
            this.gncmbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.gncmbTitulo.BorderRadius = 15;
            this.gncmbTitulo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gncmbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gncmbTitulo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gncmbTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gncmbTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gncmbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gncmbTitulo.ItemHeight = 30;
            this.gncmbTitulo.Location = new System.Drawing.Point(51, 160);
            this.gncmbTitulo.Name = "gncmbTitulo";
            this.gncmbTitulo.Size = new System.Drawing.Size(255, 36);
            this.gncmbTitulo.TabIndex = 21;
            this.gncmbTitulo.SelectionChangeCommitted += new System.EventHandler(this.gncmbTitulo_SelectionChangeCommitted);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 465);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(505, 184);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.label10.Location = new System.Drawing.Point(227, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 39);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sobre Mí";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Titulo Profesional";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Area de Trabajo";
            // 
            // txtaño
            // 
            this.txtaño.BorderRadius = 15;
            this.txtaño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaño.DefaultText = "";
            this.txtaño.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaño.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaño.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtaño.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaño.Location = new System.Drawing.Point(51, 370);
            this.txtaño.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaño.Name = "txtaño";
            this.txtaño.PlaceholderText = "";
            this.txtaño.SelectedText = "";
            this.txtaño.Size = new System.Drawing.Size(136, 35);
            this.txtaño.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Años de Experiencia";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.label6.Location = new System.Drawing.Point(185, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "Experiencia Profesional";
            // 
            // check
            // 
            this.check.AutoScroll = true;
            this.check.Location = new System.Drawing.Point(18, 386);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(234, 103);
            this.check.TabIndex = 25;
            // 
            // btn_AREAS
            // 
            this.btn_AREAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btn_AREAS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btn_AREAS.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btn_AREAS.BorderRadius = 40;
            this.btn_AREAS.BorderSize = 0;
            this.btn_AREAS.FlatAppearance.BorderSize = 0;
            this.btn_AREAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AREAS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AREAS.ForeColor = System.Drawing.Color.White;
            this.btn_AREAS.Location = new System.Drawing.Point(269, 212);
            this.btn_AREAS.Name = "btn_AREAS";
            this.btn_AREAS.Size = new System.Drawing.Size(126, 54);
            this.btn_AREAS.TabIndex = 24;
            this.btn_AREAS.Text = "Ingresar más Areas";
            this.btn_AREAS.TextColor = System.Drawing.Color.White;
            this.btn_AREAS.UseVisualStyleBackColor = false;
            this.btn_AREAS.Click += new System.EventHandler(this.btn_AREAS_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnguardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnguardar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnguardar.BorderRadius = 40;
            this.btnguardar.BorderSize = 0;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.Location = new System.Drawing.Point(216, 700);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(150, 40);
            this.btnguardar.TabIndex = 19;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextColor = System.Drawing.Color.Black;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.bordes_Boton4_Click);
            // 
            // bordes_Boton1
            // 
            this.bordes_Boton1.BackColor = System.Drawing.Color.White;
            this.bordes_Boton1.BackgroundColor = System.Drawing.Color.White;
            this.bordes_Boton1.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.bordes_Boton1.BorderRadius = 40;
            this.bordes_Boton1.BorderSize = 0;
            this.bordes_Boton1.FlatAppearance.BorderSize = 0;
            this.bordes_Boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordes_Boton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bordes_Boton1.ForeColor = System.Drawing.Color.Black;
            this.bordes_Boton1.Location = new System.Drawing.Point(43, 226);
            this.bordes_Boton1.Name = "bordes_Boton1";
            this.bordes_Boton1.Size = new System.Drawing.Size(150, 40);
            this.bordes_Boton1.TabIndex = 11;
            this.bordes_Boton1.Text = "Editar Foto";
            this.bordes_Boton1.TextColor = System.Drawing.Color.Black;
            this.bordes_Boton1.UseVisualStyleBackColor = false;
            this.bordes_Boton1.Click += new System.EventHandler(this.bordes_Boton1_Click);
            // 
            // Perfil_Pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 783);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil_Pro";
            this.Text = "Perfil_Pro";
            this.Load += new System.EventHandler(this.Perfil_Pro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ft_Perfil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtaño;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Controls.Bordes_Boton bordes_Boton1;
        public System.Windows.Forms.PictureBox Ft_Perfil;
        private Controls.Bordes_Boton btnguardar;
        private Guna.UI2.WinForms.Guna2ComboBox gncmbTitulo;
        private Guna.UI2.WinForms.Guna2ComboBox gncmbArea;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProvincia;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
        private Guna.UI2.WinForms.Guna2DataGridView Users;
        private Controls.Bordes_Boton btn_AREAS;
        private System.Windows.Forms.FlowLayoutPanel check;
    }
}