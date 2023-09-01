using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Pantalla_principal : Form
    {
        private bool SesionAbierta = false;
        private bool CerradoDesdeBtn = false;

        public Pantalla_principal()
        {
            InitializeComponent();
            PanelPrincipal.BringToFront();
        }

        private void VerificarUsuario(object sender, EventArgs e) {
            TextBox CampoUsuario = (TextBox)sender;
            string CodigoIntroducido = CampoUsuario.Text;
            BtnLogin.Enabled = Usuario.ExisteUsuario(CodigoIntroducido);
        }

        private void EntrarSistema(object sender, EventArgs e)
        {
            PanelOpciones.BringToFront();
            SesionAbierta = true;
            UsarioTransacciones = new Usuario(txtNumCuenta.Text);
        }

        private DialogResult CerrarSesion()
        {
            DialogResult OpcionSeleccionada = MessageBox.Show(
                "Esta seguro de cerrar la sesion",
                "Cerrado de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return OpcionSeleccionada;
        }

        private void CerrarSesionBtn(object sender, EventArgs e)
        {
            DialogResult Resultado = CerrarSesion();

            SesionAbierta = false;
            CerradoDesdeBtn = true;
            if(Resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Pantalla_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CerradoDesdeBtn || !SesionAbierta) {
                return;
            }

            DialogResult Resultado = CerrarSesion();

            bool Confirmado = Resultado == DialogResult.Yes;
            if(Confirmado && SesionAbierta)
            {
                Application.Exit();
            }
        }
    }
}
