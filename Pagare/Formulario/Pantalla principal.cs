using PAGARE;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private readonly Dictionary<string, string> Datos = new Dictionary<string, string> {

            { "Nombre", null},
            { "Apellido paterno", null },
            { "Apellido materno", null },
            { "Estado", null },
            { "Domicilio", null },
            { "Adelanto", null },
            { "Telefono", null }
        };

        private int Numero_Pagare;

        public Form1()
        {
            InitializeComponent();
        }

        private void Obtener_datos()
        {
            // Agrega los datos de los campos al diccionario global
            Datos["Nombre"] = boxNombre.Text;
            Datos["Apellido paterno"] = boxApPat.Text;
            Datos["Apellido materno"] = boxApMat.Text;
            Datos["Estado"] = boxEstado.Text;
            Datos["Domicilio"] = boxDomicilio.Text;
            Datos["Adelanto"] = boxAdelanto.Text;
            Datos["Telefono"] = boxTel.Text;
        }

        private void Mostrar_PAGARE(object sender, EventArgs e)
        {
            Numero_Pagare++;
            Obtener_datos();

            // Mostrando la hoja pagare en pantalla como una pantalla extra
            Hoja Pagare = new Hoja(Datos, Numero_Pagare);
            Pagare.ShowDialog();

            Borrar_datos();
        }

        private void Borrar_datos()
        {
            boxNombre.Clear();
            boxApMat.Clear();
            boxApPat.Clear();
            boxEstado.Clear();
            boxDomicilio.Clear();
            boxAdelanto.Clear();
            boxTel.Clear();
        }
    }
}
