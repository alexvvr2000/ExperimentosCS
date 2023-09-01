using System;
using Farmacia_Ramirez.Pantallas;
using System.Windows.Forms;

namespace Farmacia_Ramirez
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        public void CambiarFormulario(object sender, EventArgs e)
        {
            Button BotonClickeado = (Button)sender;
            string NombreBoton = BotonClickeado.Name;

            PanelPantallas.Controls.Clear();
            switch (NombreBoton)
            {
                case "BtnRecetas":
                    PRecetas NuevoFormulario = new PRecetas
                    {
                        TopLevel = false,
                        AutoScroll = true
                    };
                    PanelPantallas.Controls.Add(NuevoFormulario);
                    NuevoFormulario.Show();
                    break;
            }
        }
    }
}
