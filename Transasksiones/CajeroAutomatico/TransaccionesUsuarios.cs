using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CajeroAutomatico
{
    partial class Pantalla_principal
    {
        private Usuario UsarioTransacciones = null;

        private bool ValidarNums(string Dato)
        {
            if(!Regex.IsMatch(Dato, @"^[0-9]{1,}$"))
            {
                return false;
            }

            int Dinero = int.Parse(Dato);
            return Dinero >= 1;
        }

        private void ValidarDinero(object sender, EventArgs e)
        {
            TextBox CajaSeleccionado = (TextBox)sender;
            string TextoActual = CajaSeleccionado.Text;

            string NombreBtn = CajaSeleccionado.Name;
            TabPage PanelActual = CajaSeleccionado.Parent as TabPage;
            string BtnValidacion = $"btn{NombreBtn.Substring(3)}";
            Button BtnActual = (Button)PanelActual.Controls[BtnValidacion];

            switch (NombreBtn)
            {
                case "txtRetiro":
                    int Saldo = UsarioTransacciones.ObtenerSaldo();
                    if (ValidarNums(TextoActual))
                    {
                        int DineroIntroducido = int.Parse(TextoActual);
                        BtnActual.Enabled = DineroIntroducido <= Saldo;
                    }
                    break;
                case "txtDeposito":
                    BtnActual.Enabled = ValidarNums(TextoActual);
                    break;
                default:
                    string CuentaIntroducida = PanelActual.Controls["txtCuenta"].Text;
                    string Dinero = PanelActual.Controls["txtDinero"].Text;

                    if (ValidarNums(Dinero)) {
                        int DineroParseado = int.Parse(TextoActual);
                        bool existe_usuario = Usuario.ExisteUsuario(CuentaIntroducida) && DineroParseado <= UsarioTransacciones.ObtenerSaldo();
                        BtnActual.Enabled = existe_usuario;
                    }
                    break;
            }
        }
    }
}
