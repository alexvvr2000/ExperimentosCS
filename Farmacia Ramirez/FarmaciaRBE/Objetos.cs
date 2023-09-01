using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FarmaciaRBE
{
    public class Medico
    {
        private string _Cedula = "";
        private string _Nombre = "";
        private string _NumeroCita = "";


        public bool TodosCamposLlenos
        {
            get
            {
                return _Cedula != "" && _Nombre != "" && _NumeroCita != "";
            }
        }

        public string Cedula
        {
            set
            {
                bool EsCorrecto = Regex.IsMatch(value, @"^[A-Z0-9]{5,}$");
                _Cedula = EsCorrecto ? value : "";
            }
            get
            {
                return _Cedula;
            }
        }

        public string Nombre
        {
            set
            {
                bool EsCorrecto = Regex.IsMatch(value, @"^([A-Z][a-z]{2,20}\s?){2,}$");
                _Nombre = EsCorrecto ? value : "";
            }

            get
            {
                return _Nombre;
            }
        }

        public string NumeroCita
        {
            set
            {
                bool EsCorrecto = Regex.IsMatch(value, @"^[0-9]{1,}$");
                _NumeroCita = EsCorrecto ? value : "";
            }

            get
            {
                return _NumeroCita;
            }
        }
    }

    public class CentroMedico
    {
        private string _Unidad = "";
        private string _Consutorio = "";

        public bool TodosCamposLlenos
        {
            get
            {
                return _Unidad != "" && _Consutorio != "";
            }
        }

        public string Consultorio
        {
            set
            {
                bool esCorrecto = Regex.IsMatch(value, @"^\d{1,}$");
                _Consutorio = esCorrecto ? value : "";
            }
            get {
                return _Consutorio;
            }
        }

        public string Unidad
        {
            set
            {
                bool esCorrecto = Regex.IsMatch(value, @"^([A-Z][a-z]{2,}\s?){1,}$");
                _Unidad = esCorrecto ? value : "";
            }
            get
            {
                return _Unidad;
            }
        }
    }

    public class Paciente
    {
        private string _NSS = "";
        private string _NombreCompleto = "";
        private string _CURP = "";
        private string _CP = "";
        private string _Delegacion = "";

        public bool TodosCamposLlenos
        {
            get
            {
                return NombreCompleto != "" && NSS != "" && CURP != "" && CP != "" && Delegacion != "";
            }
        }

        public string NombreCompleto
        {
            get
            {
                return _NombreCompleto;
            }
            set
            {
                bool EsCorrecto = ChecarNombres(value);
                _NombreCompleto = EsCorrecto ? value : "";
            }
        }

        public string NSS
        {
            set
            {
                bool EsCorrecto = Regex.IsMatch(value, @"^\d{11}$");
                _NSS = EsCorrecto ? value : "" ;
            }
            get
            {
                return _NSS;
            }
        }

        public string CP
        {
            set
            {
                bool EsCorrecto = Regex.IsMatch(value, @"^\d{5}$");

                _CP = EsCorrecto ? value : "";
            }
            get
            {
                return _CP;
            }
        }

        public string Delegacion
        {
            get
            {
                return _Delegacion;
            }
            set
            {
                bool EsCorrecto = ChecarNombres(value, true);
                _Delegacion = EsCorrecto ? value : "";
            }
        }

        public string CURP
        {
            set
            {
                bool EsCorrecto = Regex.IsMatch(value, @"^([A-Z]{3,})(\d{6})(H|M)([A-Z]{1,2}|[A-Z]{3})([A-Z]{2,})(\d{1,})$");
                _CURP = EsCorrecto ? value : "";
            }

            get
            {
                return _CURP;
            }
        }

        private bool ChecarNombres(string NombrePrueba, bool Pais = false)
        {
            char minimoP = Pais ? '1' : '2';
            string Regexp = @"^([A-Z][a-z]{2,}\s?){*,}$".Replace('*', minimoP);
            return Regex.IsMatch(NombrePrueba, Regexp);
        }
    }

    public class Receta
    {
        public Medico doctor = new Medico();
        public Paciente paciente = new Paciente();
        public CentroMedico centroMedico = new CentroMedico();

        public bool TodosLlenos
        {
            get
            {
                return
                    doctor.TodosCamposLlenos && paciente.TodosCamposLlenos
                    && centroMedico.TodosCamposLlenos && Cuerpo != "";
            }
        }

        public string Cuerpo = "";
        public DateTime Fecha = DateTime.Now;

        public string Turno
        {
            get
            {
                return Fecha.Hour < 12 ? "Matutino" : "Vespertino";
            }
        }

        public string ID {
            get
            {
                if (TodosLlenos) {
                    return $"{paciente.NombreCompleto}_{Fecha:dd-MM-yy hh-mm tt}_{paciente.NSS}";
                }
                else
                {
                    return "";
                }
            }
        }

        public void GuardarTxt(string Folder)
        {
            string DirArchivo = Path.Combine(Folder, $"{ID}.txt");

            if (File.Exists(DirArchivo))
            {
                File.Delete(DirArchivo);
            }

            using (StreamWriter Receta = new StreamWriter(DirArchivo, append: true))
            {
                Receta.Write($"{doctor.Cedula}\n");
                Receta.Write($"{doctor.Nombre}\n");
                Receta.Write($"{doctor.NumeroCita}\n");
                Receta.Write($"{centroMedico.Unidad}\n");
                Receta.Write($"{centroMedico.Consultorio}\n");
                Receta.Write($"{paciente.NSS}\n");
                Receta.Write($"{paciente.CURP}\n");
                Receta.Write($"{paciente.CP}\n");
                Receta.Write($"{paciente.NombreCompleto}");
                Receta.Write($"{paciente.Delegacion}\n");
                Receta.Write($"{Turno}\n");
                Receta.Write($"{Fecha}\n");
                Receta.Write($"{Cuerpo}");
            }
        }

        public static IEnumerable<Dictionary<string, string>> FolderRecetas(string Folder)
        {
            DirectoryInfo Carpeta = new DirectoryInfo(Folder);
            FileInfo[] ArchivosCarpeta = Carpeta.GetFiles("*.txt");

            Regex RegexArchivo = new Regex(@"^([A-Za-z\s]+)_(.+)_(\d{11})(?=\.txt)");
            foreach(FileInfo Archivo in ArchivosCarpeta)
            {
                string NombreArchivo = Archivo.Name;

                if (RegexArchivo.IsMatch(NombreArchivo))
                {
                    Match PartesReceta = RegexArchivo.Match(NombreArchivo);

                    string Nombre = PartesReceta.Groups[1].Value;
                    string FechaCorrecta = Regex.Replace(PartesReceta.Groups[2].Value, @"(?<=\s\d{2})-(?=\d{2})", ":");
                    string NSS = PartesReceta.Groups[3].Value;
                    string IDReceta = $"{Nombre}_{PartesReceta.Groups[2].Value}_{NSS}";

                    Dictionary<string, string> Receta = new Dictionary<string, string>() {
                        {"Nombre", Nombre},
                        {"Fecha", FechaCorrecta},
                        {"NSS", NSS},
                        {"ID", IDReceta}
                    };

                    yield return Receta;
                }
            }
        }

        public static Dictionary<string, string> ObtenerReceta(string Folder, string ID)
        {
            string Directorio = Path.Combine(Folder, ID) + ".txt";
            Dictionary<string, string> Datos = new Dictionary<string, string>();
            using (StreamReader Receta = new StreamReader(Directorio))
            {
                string LineaActual = "";
                for(int Linea = 1; Linea <= 13; Linea++)
                {
                    if (Linea != 12)
                    {
                        LineaActual = Receta.ReadLine();
                    }
                    switch (Linea)
                    {
                        case 1:
                            Datos.Add("Cedula", LineaActual);
                            break;
                        case 2:
                            Datos.Add("DNombre", LineaActual);
                            break;
                        case 3:
                            Datos.Add("DCita", LineaActual);
                            break;
                        case 4:
                            Datos.Add("CMCita", LineaActual);
                            break;
                        case 5:
                            Datos.Add("CMUnidad", LineaActual);
                            break;
                        case 6:
                            Datos.Add("NSS", LineaActual);
                            break;
                        case 7:
                            Datos.Add("CURP", LineaActual);
                            break;
                        case 8:
                            Datos.Add("CP", LineaActual);
                            break;
                        case 9:
                            Datos.Add("PNombre", LineaActual);
                            break;
                        case 10:
                            Datos.Add("PDelegacion", LineaActual);
                            break;
                        case 11:
                            Datos.Add("Turno", LineaActual);
                            break;
                        case 12:
                            Datos.Add("Fecha", LineaActual);
                            break;
                        default:
                            Datos.Add("Cuerpo", Receta.ReadToEnd());
                            break;
                    }
                }
            }

            return Datos;
        }
    }
}
