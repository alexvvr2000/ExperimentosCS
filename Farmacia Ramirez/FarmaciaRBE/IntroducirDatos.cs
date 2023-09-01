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
            return Regex.IsMatch(Regexp, NombrePrueba);
        }
    }
}
