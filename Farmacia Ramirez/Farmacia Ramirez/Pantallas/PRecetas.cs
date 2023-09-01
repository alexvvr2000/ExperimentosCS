using System;
using FarmaciaRBE;
using System.Windows.Forms;
using System.IO;

namespace Farmacia_Ramirez.Pantallas
{
    public partial class PRecetas : Form
    {
        private Receta receta = new Receta();
        private string FolderRecetas
        {
            get
            {
                string DirReceta = @"C:\Recetas";

                if (!Directory.Exists(DirReceta))
                {
                    Directory.CreateDirectory(DirReceta);
                }

                return DirReceta;
            }
        }

        public PRecetas()
        {
            InitializeComponent();
            PanelCrearReceta.BringToFront();
        }

        private void AgregarDatoMedico(object sender, EventArgs e)
        {
            TextBox CasillaActual = (TextBox)sender;
            string NombreCasilla = CasillaActual.Name;

            switch (NombreCasilla)
            {
                case "txtCedula":
                    receta.doctor.Cedula = CasillaActual.Text;
                    break;
                case "txtNombre":
                    receta.doctor.Nombre = CasillaActual.Text;
                    break;
                case "txtNumeroCita":
                    receta.doctor.NumeroCita = CasillaActual.Text;
                    break;
            }

            btnGuardarReceta.Enabled = receta.TodosLlenos;
        }

        private void AgregarDatoCM(object sender, EventArgs e)
        {
            TextBox CasillaActual = (TextBox)sender;
            string NombreCasilla = CasillaActual.Name;

            switch (NombreCasilla)
            {
                case "txtCMUnidad":
                    receta.centroMedico.Unidad = CasillaActual.Text;
                    break;
                case "txtCMConsultorio":
                    receta.centroMedico.Consultorio = CasillaActual.Text;
                    break;
            }

            btnGuardarReceta.Enabled = receta.TodosLlenos;
        }

        private void AgregarDatoUS(object sender, EventArgs e)
        {
            TextBox CasillaActual = (TextBox)sender;
            string NombreCasilla = CasillaActual.Name;

            switch (NombreCasilla)
            {
                case "txtNSS":
                    receta.paciente.NSS = CasillaActual.Text;
                    break;
                case "txtDelegacion":
                    receta.paciente.Delegacion = CasillaActual.Text;
                    break;
                case "txtCURP":
                    receta.paciente.CURP = CasillaActual.Text;
                    break;
                case "txtCP":
                    receta.paciente.CP = CasillaActual.Text;
                    break;
                case "txtNCompleto":
                    receta.paciente.NombreCompleto = CasillaActual.Text;
                    break;
            }

            btnGuardarReceta.Enabled = receta.TodosLlenos;
        }

        private void AgregarCuerpo(object sender, EventArgs e)
        {
            string CuerpoReceta = @txtCuerpoReceta.Text;
            receta.Cuerpo = CuerpoReceta;

            btnGuardarReceta.Enabled = receta.TodosLlenos;
        }

        private void GuardarReceta(object sender, EventArgs e)
        {
            receta.GuardarTxt(FolderRecetas);
        }
    }
}
