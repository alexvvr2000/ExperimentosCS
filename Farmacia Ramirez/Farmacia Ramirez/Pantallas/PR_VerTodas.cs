using FarmaciaRBE;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Farmacia_Ramirez.Pantallas
{
    public class PantallaReceta : Form
    {
        public string ID;

        public string Folder;

        public Panel Datos;

        public void CrearPanel(Panel datos)
        {
            Datos = datos;
            Datos.Dock = DockStyle.Fill;
            Datos.Visible = true;
            Datos.AutoScroll = true;

            Datos.Controls["btnGuardarReceta"].Visible = false;

            Dictionary<string, string> Dreceta = Receta.ObtenerReceta(Folder, ID);
            foreach(Control c in Datos.Controls)
            {
                if(c.Name == "btnGuardarReceta")
                {
                    c.Visible = false;
                }
            }

            Size = new System.Drawing.Size(640, 370);
            MaximumSize = Size;
            MinimumSize = Size;


            Controls.Add(Datos);
            Datos.Show();
        }
    }

    partial class PRecetas
    {
        public void VerRecetasPanel(object sender, EventArgs e)
        {
            PanelVerRecetas.BringToFront();

            ListaRecetas.Items.Clear();
            foreach (Dictionary<string, string> RFolder in Receta.FolderRecetas(FolderRecetas))
            {
                string ValorTabla = $"Nombre: {RFolder["Nombre"]}    Fecha: {RFolder["Fecha"]}    NSS: {RFolder["NSS"]}";
                ListaRecetas.Items.Add(ValorTabla);
            }
        }

        public void ObtenerReceta(object sender, EventArgs e)
        {
            Regex Re = new Regex(@"\s+((Fecha)|(NSS)):\s+");
            string ID = Re.Replace(ListaRecetas.SelectedItem.ToString(), "_").Replace("Nombre: ", "");
            PantallaReceta pantalla = new PantallaReceta()
            {
                ID = ID.Replace(":","-"),
                Folder = FolderRecetas
            };
            pantalla.CrearPanel(PanelCrearReceta);
            pantalla.ShowDialog();
        }

        public void CrearRecetaPanel(object sender, EventArgs e)
        {
            PanelCrearReceta.BringToFront();
        }
    }
}
