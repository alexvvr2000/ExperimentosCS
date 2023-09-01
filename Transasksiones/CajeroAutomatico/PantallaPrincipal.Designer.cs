
namespace CajeroAutomatico
{
    partial class Pantalla_principal
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.tabTransferencias = new System.Windows.Forms.TabControl();
            this.PanelRetiro = new System.Windows.Forms.TabPage();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelDeposito = new System.Windows.Forms.TabPage();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PanelTransferencias = new System.Windows.Forms.TabPage();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelSaldo = new System.Windows.Forms.TabPage();
            this.btnVerSaldo = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            this.PanelOpciones.SuspendLayout();
            this.tabTransferencias.SuspendLayout();
            this.PanelRetiro.SuspendLayout();
            this.PanelDeposito.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.PanelTransferencias.SuspendLayout();
            this.PanelSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.BtnLogin);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.txtNumCuenta);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Location = new System.Drawing.Point(14, 9);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(546, 433);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Controls.Add(this.BtnCerrarSesion);
            this.PanelOpciones.Controls.Add(this.tabTransferencias);
            this.PanelOpciones.Location = new System.Drawing.Point(14, 9);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(546, 429);
            this.PanelOpciones.TabIndex = 7;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 379);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(546, 50);
            this.BtnCerrarSesion.TabIndex = 1;
            this.BtnCerrarSesion.Text = "Cerrar sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.CerrarSesionBtn);
            // 
            // tabTransferencias
            // 
            this.tabTransferencias.Controls.Add(this.PanelRetiro);
            this.tabTransferencias.Controls.Add(this.PanelDeposito);
            this.tabTransferencias.Controls.Add(this.tabPage4);
            this.tabTransferencias.Controls.Add(this.PanelTransferencias);
            this.tabTransferencias.Controls.Add(this.PanelSaldo);
            this.tabTransferencias.Location = new System.Drawing.Point(20, 17);
            this.tabTransferencias.Name = "tabTransferencias";
            this.tabTransferencias.SelectedIndex = 0;
            this.tabTransferencias.Size = new System.Drawing.Size(543, 426);
            this.tabTransferencias.TabIndex = 2;
            // 
            // PanelRetiro
            // 
            this.PanelRetiro.Controls.Add(this.btnRetiro);
            this.PanelRetiro.Controls.Add(this.txtRetiro);
            this.PanelRetiro.Controls.Add(this.label5);
            this.PanelRetiro.Location = new System.Drawing.Point(4, 22);
            this.PanelRetiro.Name = "PanelRetiro";
            this.PanelRetiro.Padding = new System.Windows.Forms.Padding(3);
            this.PanelRetiro.Size = new System.Drawing.Size(535, 400);
            this.PanelRetiro.TabIndex = 1;
            this.PanelRetiro.Text = "Retiro de efectivo";
            this.PanelRetiro.UseVisualStyleBackColor = true;
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(114, 171);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(255, 23);
            this.btnRetiro.TabIndex = 2;
            this.btnRetiro.Text = "Retirar";
            this.btnRetiro.UseVisualStyleBackColor = true;
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(114, 145);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(255, 20);
            this.txtRetiro.TabIndex = 1;
            this.txtRetiro.TextChanged += new System.EventHandler(this.ValidarDinero);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Introduzca el dinero a recoger";
            // 
            // PanelDeposito
            // 
            this.PanelDeposito.Controls.Add(this.btnDeposito);
            this.PanelDeposito.Controls.Add(this.txtDeposito);
            this.PanelDeposito.Controls.Add(this.label6);
            this.PanelDeposito.Location = new System.Drawing.Point(4, 22);
            this.PanelDeposito.Name = "PanelDeposito";
            this.PanelDeposito.Padding = new System.Windows.Forms.Padding(3);
            this.PanelDeposito.Size = new System.Drawing.Size(535, 400);
            this.PanelDeposito.TabIndex = 2;
            this.PanelDeposito.Text = "Deposito de efectivo";
            this.PanelDeposito.UseVisualStyleBackColor = true;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(123, 128);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(237, 23);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(123, 106);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(237, 20);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.TextChanged += new System.EventHandler(this.ValidarDinero);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Introduzca el dinero a introducir";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.btnMovimientos);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(535, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movimientos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuario: <usuario>";
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Location = new System.Drawing.Point(49, 251);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(397, 23);
            this.btnMovimientos.TabIndex = 1;
            this.btnMovimientos.Text = "Actualizar";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 147);
            this.listBox1.TabIndex = 0;
            // 
            // PanelTransferencias
            // 
            this.PanelTransferencias.Controls.Add(this.btnTransferencias);
            this.PanelTransferencias.Controls.Add(this.txtDinero);
            this.PanelTransferencias.Controls.Add(this.label9);
            this.PanelTransferencias.Controls.Add(this.txtCuenta);
            this.PanelTransferencias.Controls.Add(this.label8);
            this.PanelTransferencias.Location = new System.Drawing.Point(4, 22);
            this.PanelTransferencias.Name = "PanelTransferencias";
            this.PanelTransferencias.Padding = new System.Windows.Forms.Padding(3);
            this.PanelTransferencias.Size = new System.Drawing.Size(535, 400);
            this.PanelTransferencias.TabIndex = 4;
            this.PanelTransferencias.Text = "Transeferencias";
            this.PanelTransferencias.UseVisualStyleBackColor = true;
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Location = new System.Drawing.Point(118, 155);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(242, 23);
            this.btnTransferencias.TabIndex = 5;
            this.btnTransferencias.Text = "button1";
            this.btnTransferencias.UseVisualStyleBackColor = true;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(118, 129);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(242, 20);
            this.txtDinero.TabIndex = 4;
            this.txtDinero.TextChanged += new System.EventHandler(this.ValidarDinero);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Introduzca la cantidad de dinero";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(118, 86);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(242, 20);
            this.txtCuenta.TabIndex = 2;
            this.txtCuenta.TextChanged += new System.EventHandler(this.ValidarDinero);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Introduzca la Cuenta a transferir";
            // 
            // PanelSaldo
            // 
            this.PanelSaldo.Controls.Add(this.btnVerSaldo);
            this.PanelSaldo.Controls.Add(this.lblSaldo);
            this.PanelSaldo.Controls.Add(this.label3);
            this.PanelSaldo.Location = new System.Drawing.Point(4, 22);
            this.PanelSaldo.Name = "PanelSaldo";
            this.PanelSaldo.Padding = new System.Windows.Forms.Padding(3);
            this.PanelSaldo.Size = new System.Drawing.Size(535, 400);
            this.PanelSaldo.TabIndex = 0;
            this.PanelSaldo.Text = "Consulta de saldo";
            this.PanelSaldo.UseVisualStyleBackColor = true;
            // 
            // btnVerSaldo
            // 
            this.btnVerSaldo.Location = new System.Drawing.Point(187, 196);
            this.btnVerSaldo.Name = "btnVerSaldo";
            this.btnVerSaldo.Size = new System.Drawing.Size(117, 23);
            this.btnVerSaldo.TabIndex = 2;
            this.btnVerSaldo.Text = "Actualizar saldo";
            this.btnVerSaldo.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(224, 180);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(35, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "XXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Enabled = false;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(127, 244);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(291, 40);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.EntrarSistema);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de cuenta:";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(127, 218);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(291, 20);
            this.txtNumCuenta.TabIndex = 4;
            this.txtNumCuenta.TextChanged += new System.EventHandler(this.VerificarUsuario);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Bienvenido! Introduzca sus datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "transasKciones";
            // 
            // Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 453);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelOpciones);
            this.Name = "Pantalla_principal";
            this.Text = "Pantalla_principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pantalla_principal_FormClosed);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.PanelOpciones.ResumeLayout(false);
            this.tabTransferencias.ResumeLayout(false);
            this.PanelRetiro.ResumeLayout(false);
            this.PanelRetiro.PerformLayout();
            this.PanelDeposito.ResumeLayout(false);
            this.PanelDeposito.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.PanelTransferencias.ResumeLayout(false);
            this.PanelTransferencias.PerformLayout();
            this.PanelSaldo.ResumeLayout(false);
            this.PanelSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.TabControl tabTransferencias;
        private System.Windows.Forms.TabPage PanelSaldo;
        private System.Windows.Forms.TabPage PanelRetiro;
        private System.Windows.Forms.TabPage PanelDeposito;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerSaldo;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage PanelTransferencias;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTransferencias;
    }
}