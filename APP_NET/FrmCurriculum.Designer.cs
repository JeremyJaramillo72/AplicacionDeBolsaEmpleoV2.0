namespace APP_NET
{
    partial class FrmCurriculum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurriculum));
            this.lblArchivoCargado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarCurriculum = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPostular = new APP_NET.Controls.Bordes_Boton();
            this.btnRegresar = new APP_NET.Controls.Bordes_Boton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArchivoCargado
            // 
            this.lblArchivoCargado.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivoCargado.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoCargado.Location = new System.Drawing.Point(281, 265);
            this.lblArchivoCargado.Name = "lblArchivoCargado";
            this.lblArchivoCargado.Size = new System.Drawing.Size(163, 18);
            this.lblArchivoCargado.TabIndex = 0;
            this.lblArchivoCargado.Text = "Ningún archivo seleccionado";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(767, 64);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Curriculum";
            // 
            // btnCargarCurriculum
            // 
            this.btnCargarCurriculum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarCurriculum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarCurriculum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarCurriculum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarCurriculum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargarCurriculum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargarCurriculum.FillColor = System.Drawing.Color.White;
            this.btnCargarCurriculum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargarCurriculum.ForeColor = System.Drawing.Color.Transparent;
            this.btnCargarCurriculum.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarCurriculum.Image")));
            this.btnCargarCurriculum.Location = new System.Drawing.Point(27, 85);
            this.btnCargarCurriculum.Name = "btnCargarCurriculum";
            this.btnCargarCurriculum.Size = new System.Drawing.Size(665, 162);
            this.btnCargarCurriculum.TabIndex = 42;
            this.btnCargarCurriculum.Text = "guna2Button1";
            this.btnCargarCurriculum.Click += new System.EventHandler(this.btnCargarCurriculum_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(27, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 162);
            this.panel1.TabIndex = 44;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // btnPostular
            // 
            this.btnPostular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnPostular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.btnPostular.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnPostular.BorderRadius = 32;
            this.btnPostular.BorderSize = 0;
            this.btnPostular.FlatAppearance.BorderSize = 0;
            this.btnPostular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostular.ForeColor = System.Drawing.Color.White;
            this.btnPostular.Location = new System.Drawing.Point(520, 252);
            this.btnPostular.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostular.Name = "btnPostular";
            this.btnPostular.Size = new System.Drawing.Size(172, 32);
            this.btnPostular.TabIndex = 43;
            this.btnPostular.Text = "Enviar Postulacion";
            this.btnPostular.TextColor = System.Drawing.Color.White;
            this.btnPostular.UseVisualStyleBackColor = false;
            this.btnPostular.Click += new System.EventHandler(this.btnPostular_Click_1);
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
            this.btnRegresar.Location = new System.Drawing.Point(11, 252);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(136, 32);
            this.btnRegresar.TabIndex = 41;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextColor = System.Drawing.Color.White;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPostular);
            this.Controls.Add(this.btnCargarCurriculum);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblArchivoCargado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCurriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCurriculum";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblArchivoCargado;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Controls.Bordes_Boton btnRegresar;
        private Controls.Bordes_Boton btnPostular;
        private Guna.UI2.WinForms.Guna2Button btnCargarCurriculum;
        private System.Windows.Forms.Panel panel1;
    }
}