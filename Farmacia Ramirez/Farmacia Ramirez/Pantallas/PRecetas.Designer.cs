
namespace Farmacia_Ramirez.Pantallas
{
    partial class PRecetas
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
            this.BtnVerRecetas = new System.Windows.Forms.Button();
            this.BtnCrearReceta = new System.Windows.Forms.Button();
            this.PanelCrearReceta = new System.Windows.Forms.Panel();
            this.btnGuardarReceta = new System.Windows.Forms.Button();
            this.txtCuerpoReceta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNCompleto = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.txtDelegacion = new System.Windows.Forms.TextBox();
            this.txtNSS = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCMConsultorio = new System.Windows.Forms.TextBox();
            this.txtCMUnidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroCita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.PanelVerRecetas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaRecetas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.PanelCrearReceta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelVerRecetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnVerRecetas);
            this.panel1.Controls.Add(this.BtnCrearReceta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 341);
            this.panel1.TabIndex = 0;
            // 
            // BtnVerRecetas
            // 
            this.BtnVerRecetas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnVerRecetas.Location = new System.Drawing.Point(0, 165);
            this.BtnVerRecetas.Name = "BtnVerRecetas";
            this.BtnVerRecetas.Size = new System.Drawing.Size(92, 176);
            this.BtnVerRecetas.TabIndex = 1;
            this.BtnVerRecetas.Text = "Ver todas las recetas";
            this.BtnVerRecetas.UseVisualStyleBackColor = true;
            this.BtnVerRecetas.Click += new System.EventHandler(this.VerRecetasPanel);
            // 
            // BtnCrearReceta
            // 
            this.BtnCrearReceta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCrearReceta.Location = new System.Drawing.Point(0, 0);
            this.BtnCrearReceta.Name = "BtnCrearReceta";
            this.BtnCrearReceta.Size = new System.Drawing.Size(92, 159);
            this.BtnCrearReceta.TabIndex = 0;
            this.BtnCrearReceta.Text = "Crear nueva receta";
            this.BtnCrearReceta.UseVisualStyleBackColor = true;
            this.BtnCrearReceta.Click += new System.EventHandler(this.CrearRecetaPanel);
            // 
            // PanelCrearReceta
            // 
            this.PanelCrearReceta.Controls.Add(this.btnGuardarReceta);
            this.PanelCrearReceta.Controls.Add(this.txtCuerpoReceta);
            this.PanelCrearReceta.Controls.Add(this.panel3);
            this.PanelCrearReceta.Controls.Add(this.panel5);
            this.PanelCrearReceta.Controls.Add(this.LblTitulo);
            this.PanelCrearReceta.Controls.Add(this.panel2);
            this.PanelCrearReceta.Location = new System.Drawing.Point(98, 12);
            this.PanelCrearReceta.Name = "PanelCrearReceta";
            this.PanelCrearReceta.Size = new System.Drawing.Size(623, 317);
            this.PanelCrearReceta.TabIndex = 1;
            // 
            // btnGuardarReceta
            // 
            this.btnGuardarReceta.Enabled = false;
            this.btnGuardarReceta.Location = new System.Drawing.Point(185, 131);
            this.btnGuardarReceta.Name = "btnGuardarReceta";
            this.btnGuardarReceta.Size = new System.Drawing.Size(147, 33);
            this.btnGuardarReceta.TabIndex = 6;
            this.btnGuardarReceta.Text = "Guardar";
            this.btnGuardarReceta.UseVisualStyleBackColor = true;
            this.btnGuardarReceta.Click += new System.EventHandler(this.GuardarReceta);
            // 
            // txtCuerpoReceta
            // 
            this.txtCuerpoReceta.Location = new System.Drawing.Point(7, 177);
            this.txtCuerpoReceta.Multiline = true;
            this.txtCuerpoReceta.Name = "txtCuerpoReceta";
            this.txtCuerpoReceta.Size = new System.Drawing.Size(610, 137);
            this.txtCuerpoReceta.TabIndex = 5;
            this.txtCuerpoReceta.TextChanged += new System.EventHandler(this.AgregarCuerpo);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtNCompleto);
            this.panel3.Controls.Add(this.txtCP);
            this.panel3.Controls.Add(this.txtCURP);
            this.panel3.Controls.Add(this.txtDelegacion);
            this.panel3.Controls.Add(this.txtNSS);
            this.panel3.Location = new System.Drawing.Point(341, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 137);
            this.panel3.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nombre completo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "CP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "CURP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Delegacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "NSS";
            // 
            // txtNCompleto
            // 
            this.txtNCompleto.Location = new System.Drawing.Point(3, 110);
            this.txtNCompleto.Name = "txtNCompleto";
            this.txtNCompleto.Size = new System.Drawing.Size(273, 20);
            this.txtNCompleto.TabIndex = 9;
            this.txtNCompleto.TextChanged += new System.EventHandler(this.AgregarDatoUS);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(130, 62);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(146, 20);
            this.txtCP.TabIndex = 8;
            this.txtCP.TextChanged += new System.EventHandler(this.AgregarDatoUS);
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(3, 62);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(122, 20);
            this.txtCURP.TabIndex = 7;
            this.txtCURP.TextChanged += new System.EventHandler(this.AgregarDatoUS);
            // 
            // txtDelegacion
            // 
            this.txtDelegacion.Location = new System.Drawing.Point(130, 17);
            this.txtDelegacion.Name = "txtDelegacion";
            this.txtDelegacion.Size = new System.Drawing.Size(146, 20);
            this.txtDelegacion.TabIndex = 6;
            this.txtDelegacion.TextChanged += new System.EventHandler(this.AgregarDatoUS);
            // 
            // txtNSS
            // 
            this.txtNSS.Location = new System.Drawing.Point(3, 17);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(122, 20);
            this.txtNSS.TabIndex = 5;
            this.txtNSS.TextChanged += new System.EventHandler(this.AgregarDatoUS);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtCMConsultorio);
            this.panel5.Controls.Add(this.txtCMUnidad);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(182, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 91);
            this.panel5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Consultorio";
            // 
            // txtCMConsultorio
            // 
            this.txtCMConsultorio.Location = new System.Drawing.Point(3, 63);
            this.txtCMConsultorio.Name = "txtCMConsultorio";
            this.txtCMConsultorio.Size = new System.Drawing.Size(147, 20);
            this.txtCMConsultorio.TabIndex = 6;
            this.txtCMConsultorio.TextChanged += new System.EventHandler(this.AgregarDatoCM);
            // 
            // txtCMUnidad
            // 
            this.txtCMUnidad.Location = new System.Drawing.Point(3, 18);
            this.txtCMUnidad.Name = "txtCMUnidad";
            this.txtCMUnidad.Size = new System.Drawing.Size(147, 20);
            this.txtCMUnidad.TabIndex = 5;
            this.txtCMUnidad.TextChanged += new System.EventHandler(this.AgregarDatoCM);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Unidad";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(623, 29);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Crear Receta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNumeroCita);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Location = new System.Drawing.Point(4, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 139);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Numero de cita";
            // 
            // txtNumeroCita
            // 
            this.txtNumeroCita.Location = new System.Drawing.Point(3, 111);
            this.txtNumeroCita.Name = "txtNumeroCita";
            this.txtNumeroCita.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroCita.TabIndex = 5;
            this.txtNumeroCita.TextChanged += new System.EventHandler(this.AgregarDatoMedico);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(3, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.AgregarDatoMedico);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(3, 18);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(162, 20);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.TextChanged += new System.EventHandler(this.AgregarDatoMedico);
            // 
            // PanelVerRecetas
            // 
            this.PanelVerRecetas.Controls.Add(this.label6);
            this.PanelVerRecetas.Controls.Add(this.label2);
            this.PanelVerRecetas.Controls.Add(this.ListaRecetas);
            this.PanelVerRecetas.Location = new System.Drawing.Point(98, 3);
            this.PanelVerRecetas.Name = "PanelVerRecetas";
            this.PanelVerRecetas.Size = new System.Drawing.Size(623, 326);
            this.PanelVerRecetas.TabIndex = 7;
            this.PanelVerRecetas.Click += new System.EventHandler(this.VerRecetasPanel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(50, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Recuerde dar click en una para ver los detalles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de recetas en el sistema";
            // 
            // ListaRecetas
            // 
            this.ListaRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaRecetas.FormattingEnabled = true;
            this.ListaRecetas.ItemHeight = 16;
            this.ListaRecetas.Location = new System.Drawing.Point(53, 65);
            this.ListaRecetas.Name = "ListaRecetas";
            this.ListaRecetas.Size = new System.Drawing.Size(538, 196);
            this.ListaRecetas.TabIndex = 0;
            this.ListaRecetas.DoubleClick += new System.EventHandler(this.ObtenerReceta);
            // 
            // PRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCrearReceta);
            this.Controls.Add(this.PanelVerRecetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PRecetas";
            this.Text = "PRecetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.PanelCrearReceta.ResumeLayout(false);
            this.PanelCrearReceta.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelVerRecetas.ResumeLayout(false);
            this.PanelVerRecetas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCrearReceta;
        private System.Windows.Forms.Button BtnVerRecetas;
        private System.Windows.Forms.Panel PanelCrearReceta;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroCita;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCMConsultorio;
        private System.Windows.Forms.TextBox txtCMUnidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNCompleto;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.TextBox txtDelegacion;
        private System.Windows.Forms.TextBox txtNSS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCuerpoReceta;
        private System.Windows.Forms.Button btnGuardarReceta;
        private System.Windows.Forms.ListBox ListaRecetas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel PanelVerRecetas;
    }
}