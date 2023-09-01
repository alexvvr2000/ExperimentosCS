namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxDomicilio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxApMat = new System.Windows.Forms.TextBox();
            this.boxApPat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxAdelanto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // boxEstado
            // 
            this.boxEstado.Location = new System.Drawing.Point(375, 32);
            this.boxEstado.Multiline = true;
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(213, 20);
            this.boxEstado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Domicilio: ";
            // 
            // boxDomicilio
            // 
            this.boxDomicilio.Location = new System.Drawing.Point(375, 64);
            this.boxDomicilio.Multiline = true;
            this.boxDomicilio.Name = "boxDomicilio";
            this.boxDomicilio.Size = new System.Drawing.Size(213, 20);
            this.boxDomicilio.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(636, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Mostrar_PAGARE);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido Materno:";
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(111, 13);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(190, 20);
            this.boxNombre.TabIndex = 15;
            // 
            // boxApMat
            // 
            this.boxApMat.Location = new System.Drawing.Point(111, 79);
            this.boxApMat.Name = "boxApMat";
            this.boxApMat.Size = new System.Drawing.Size(190, 20);
            this.boxApMat.TabIndex = 16;
            // 
            // boxApPat
            // 
            this.boxApPat.Location = new System.Drawing.Point(111, 45);
            this.boxApPat.Name = "boxApPat";
            this.boxApPat.Size = new System.Drawing.Size(190, 20);
            this.boxApPat.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adelanto:";
            // 
            // boxAdelanto
            // 
            this.boxAdelanto.Location = new System.Drawing.Point(375, 98);
            this.boxAdelanto.Multiline = true;
            this.boxAdelanto.Name = "boxAdelanto";
            this.boxAdelanto.Size = new System.Drawing.Size(213, 20);
            this.boxAdelanto.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxTel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.boxAdelanto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.boxEstado);
            this.panel1.Controls.Add(this.boxApPat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxApMat);
            this.panel1.Controls.Add(this.boxDomicilio);
            this.panel1.Controls.Add(this.boxNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 152);
            this.panel1.TabIndex = 20;
            // 
            // boxTel
            // 
            this.boxTel.Location = new System.Drawing.Point(111, 114);
            this.boxTel.Name = "boxTel";
            this.boxTel.Size = new System.Drawing.Size(190, 20);
            this.boxTel.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(636, 50);
            this.label7.TabIndex = 21;
            this.label7.Text = "PAGARE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 258);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Creacion de Pagare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxDomicilio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.TextBox boxApMat;
        private System.Windows.Forms.TextBox boxApPat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxAdelanto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxTel;
        private System.Windows.Forms.Label label8;
    }
}

