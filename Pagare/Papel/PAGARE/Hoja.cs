using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PAGARE
{
    public partial class Hoja : Form
    {

        public Hoja(Dictionary<string,string> Nuevos_Datos, int NumeroPagare = 1)
        {
            InitializeComponent();

            boxNumero.Text = NumeroPagare.ToString();
            boxDinero.Text = Nuevos_Datos["Adelanto"];
            boxLugar.Text = Nuevos_Datos["Estado"];
            boxFecha.Text = FechaActual();

            int Dinero = Convert.ToInt32(Nuevos_Datos["Adelanto"]);
            lblDinero.Text = Convert.ToString(Dinero * 3);
            boxFirma.Text = Nuevos_Datos["Nombre"];

            boxNombre.Text = Nuevos_Datos["Nombre"] + " " + Nuevos_Datos["Apellido paterno"];
            boxDireccion.Text = Nuevos_Datos["Domicilio"];
            boxCiudad.Text = boxLugar.Text;
            boxTelefono.Text = Nuevos_Datos["Telefono"];
        }

        private string FechaActual()
        {
            DateTime FechaAc = DateTime.Now;
            return FechaAc.ToString("yyyy-dd-MM");
        }
    }
}
