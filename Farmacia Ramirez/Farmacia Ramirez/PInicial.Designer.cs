
namespace Farmacia_Ramirez
{
    partial class FormInicial
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
            this.BtnRecetas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPantallas = new System.Windows.Forms.Panel();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnCitas = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnConsulta);
            this.panel1.Controls.Add(this.BtnCitas);
            this.panel1.Controls.Add(this.BtnInventario);
            this.panel1.Controls.Add(this.BtnRecetas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 71);
            this.panel1.TabIndex = 0;
            // 
            // BtnRecetas
            // 
            this.BtnRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecetas.Location = new System.Drawing.Point(30, 6);
            this.BtnRecetas.Name = "BtnRecetas";
            this.BtnRecetas.Size = new System.Drawing.Size(167, 62);
            this.BtnRecetas.TabIndex = 4;
            this.BtnRecetas.Text = "Recetas";
            this.BtnRecetas.UseVisualStyleBackColor = true;
            this.BtnRecetas.Click += new System.EventHandler(this.CambiarFormulario);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farmacias Ramirez";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPantallas
            // 
            this.PanelPantallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPantallas.Location = new System.Drawing.Point(0, 53);
            this.PanelPantallas.Name = "PanelPantallas";
            this.PanelPantallas.Size = new System.Drawing.Size(733, 341);
            this.PanelPantallas.TabIndex = 2;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Location = new System.Drawing.Point(203, 6);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(165, 62);
            this.BtnInventario.TabIndex = 5;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // BtnCitas
            // 
            this.BtnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCitas.Location = new System.Drawing.Point(545, 6);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Size = new System.Drawing.Size(168, 62);
            this.BtnCitas.TabIndex = 7;
            this.BtnCitas.Text = "Citas";
            this.BtnCitas.UseVisualStyleBackColor = true;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Location = new System.Drawing.Point(374, 6);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(165, 62);
            this.BtnConsulta.TabIndex = 8;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 465);
            this.Controls.Add(this.PanelPantallas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(749, 504);
            this.MinimumSize = new System.Drawing.Size(749, 504);
            this.Name = "FormInicial";
            this.Text = "Farmacias R | Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRecetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelPantallas;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnConsulta;
    }
}

