using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CajeroAutomatico
{
    public class Usuario
    {
        private readonly string Nombre = "";
        private int Saldo = 0;
        private readonly string NumCuenta = "";
        private bool datos_creados = false;

        private string DirectorioDatos
        {
            get
            {
                string Directorio = @"C:\Cajero";

                if (!Directory.Exists(Directorio))
                {
                    Directory.CreateDirectory(Directorio);
                }

                return Directorio;
            }
        }

        private string DirUsuario
        {
            get
            {
                string DirDatos = DirectorioDatos;
                string DirUsuario = Path.Combine(DirDatos, $"{NumCuenta}.txt");
                return DirUsuario;
            }
        }

        private string DirMovimientos
        {
            get
            {
                return Path.Combine(DirUsuario, $"movs_{NumCuenta}.txt");
            }
        }

        public static bool ExisteUsuario(string NumCuenta)
        {
            string DirectorioUsuarios = @"C:\Cajero";
            if (!Directory.Exists(DirectorioUsuarios)) {
                Directory.CreateDirectory(DirectorioUsuarios);
            }

            string DirectorioUsuario = Path.Combine(DirectorioUsuarios, $"{NumCuenta}.txt");
            return File.Exists(DirectorioUsuario);
        }

        public static IEnumerable ReportesUsuarios(string NumCuenta)
        {
            string DirectorioUsuarios = @"C:\Cajero";
            if (!Directory.Exists(DirectorioUsuarios)) {
                Directory.CreateDirectory(DirectorioUsuarios);
                yield return null;
            }

            string DirectorioUsuario = Path.Combine(DirectorioUsuarios, $"movs_{NumCuenta}.txt");
            if (!File.Exists(DirectorioUsuario) || !Usuario.ExisteUsuario(NumCuenta))
            {
                yield return null;
            }

            using (StreamReader ArchivoReporteUsuarios = new StreamReader(DirectorioUsuario))
            {
                string ReporteActual = ArchivoReporteUsuarios.ReadLine();

                while (ReporteActual != null)
                {
                    yield return ReporteActual;
                    ReporteActual = ArchivoReporteUsuarios.ReadLine();
                }
            }
        }

        public Usuario(string NumCuentaNuevo)
        {
            CrearDatosPrueba();

            if (!File.Exists(DirUsuario))
            {
                throw new FileNotFoundException($"Usuario {NumCuentaNuevo} no existe en base");
            }

            string DatoUsuario;
            using (StreamReader ArchivoUsuario = new StreamReader(DirUsuario))
            {
                DatoUsuario = ArchivoUsuario.ReadLine();
                string[] Datos = DatoUsuario.Split(',');

                NumCuenta = Datos[0];
                Nombre = Datos[1];
                Saldo = Int32.Parse(Datos[2]);
            }
        }

        private void CrearDatosPrueba()
        {
            if (datos_creados)
            {
                return;
            }

            Dictionary<string, string[]> DatosFalsos = new Dictionary<string, string[]>() {
                { "12345678" , new string[] { "JUAN TELLO", "5237" } },
                { "34567842" , new string[] { "PEDRO LOPEZ", "56832" } },
                { "87654325" , new string[] { "ROMAN PEREZ", "6323" } },
                { "93236892" , new string[] { "MARIA RODRIGUEZ", "57842" } },
            };

            foreach (string NumCuentaNuevo in DatosFalsos.Keys)
            {
                string DirNuevoUsuario = Path.Combine(DirectorioDatos, $"{NumCuentaNuevo}.txt");
                string ColumnaDatos = $"{NumCuentaNuevo},{string.Join(",", DatosFalsos[NumCuentaNuevo])}";

                using (StreamWriter NuevoArchivo = new StreamWriter(DirNuevoUsuario))
                {
                    NuevoArchivo.Write(ColumnaDatos);
                }
            }

            datos_creados = true;
        }

        public bool RetirarEfectivo(int Cantidad)
        {
            if (Cantidad > Saldo)
            {
                return false;
            }
            int SaldoAnterior = Saldo;
            Saldo -= Cantidad;

            bool se_actualizo = ActualizarDatos();
            if (se_actualizo) {
                EscribirMovimientos("RETIRO", Cantidad);
            } else
            {
                Saldo = SaldoAnterior;
            }

            return se_actualizo;
        }

        public int ObtenerSaldo()
        {
            return Saldo;
        }

        public bool Depositar(int Cantidad)
        {
            int SaldoAnterior = Saldo;
            Saldo += Cantidad;

            bool se_actualizo = ActualizarDatos();

            if (se_actualizo)
            {
                EscribirMovimientos("DEPOSITO", Cantidad);
            } else
            {
                Saldo = SaldoAnterior;
            }

            return se_actualizo;
        }

        public bool TransferirDinero(string NumCuenta, int Dinero)
        {
            if (!ExisteUsuario(NumCuenta) || Dinero > Saldo || Dinero < 1)
            {
                return false;
            }

            int SaldoAnterior = Saldo;
            Saldo -= Dinero;

            bool dinero_transferido = ActualizarSaldoUsuario(NumCuenta, Dinero);
            if (!dinero_transferido)
            {
                Saldo = SaldoAnterior;
                return false;
            }

            ReporteTransferencia(NumCuenta, Dinero);

            return true;
        }

        private bool ActualizarSaldoUsuario(string NumCuenta, int Saldo)
        {
            if (Saldo < 0 || !ExisteUsuario(NumCuenta))
            {
                return false;
            }

            string DirUsuario = Path.Combine(DirectorioDatos, $"{NumCuenta}.txt");
            string DatosUsuario;
            using (StreamReader ArchivoUsuario = new StreamReader(DirUsuario)) {
                DatosUsuario = ArchivoUsuario.ReadLine();
            }

            if (DatosUsuario == "")
            {
                return false;
            }

            string[] DatosNuevos = DatosUsuario.Split(',');
            int SaldoAnterior = int.Parse(DatosNuevos[2]);

            if (SaldoAnterior > Saldo)
            {
                return false;
            }

            DatosNuevos[2] = Saldo.ToString();

            File.Delete(DirUsuario);
            using (StreamWriter ArchivoNuevo = new StreamWriter(DirUsuario))
            {
                ArchivoNuevo.Write(String.Join(",", DatosNuevos));
            }

            return true;
        }

        private void EscribirMovimientos(string TipoMovimiento, int Dinero)
        {
            using (StreamWriter Movimientos = new StreamWriter(DirMovimientos, true)) {
                if (TipoMovimiento != "TRANSFERENCIA")
                {
                    Movimientos.Write($"Se hizo un movimiento de tipo {TipoMovimiento} de {Dinero}$");
                }
            }
        }

        private void ReporteTransferencia(string NumCuentaDestino, int Dinero){
            if (!ExisteUsuario(NumCuenta))
            {
                return;
            }

            using(StreamWriter RepUsuarioRemitente = new StreamWriter(DirMovimientos, true))
            {
                RepUsuarioRemitente.Write($"Transferencia de {Dinero} para {RepUsuarioRemitente}");
            }

            string DirUsuarioRemitenete = Path.Combine(NumCuentaDestino, $"movs_{NumCuentaDestino}.txt");
            using (StreamWriter RepUsuarioRemitente = new StreamWriter(DirUsuarioRemitenete, true))
            {
                RepUsuarioRemitente.Write($"Transferido {Dinero}$ de {NumCuenta}");
            }
        }

        private bool ActualizarDatos()
        {
            try
            {
                File.Delete(DirUsuario);

                string[] DatosNuevos = new string[] {NumCuenta, Nombre, Saldo.ToString()};
                using (StreamWriter UsuarioConDatosNuevos = new StreamWriter(DirUsuario))
                {
                    UsuarioConDatosNuevos.Write(String.Join(",", DatosNuevos));
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
