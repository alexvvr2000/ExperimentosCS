using System;
using FarmaciaRBE;

namespace TestsFarmacia
{
    class Program
    {
        private string FolderTests = @"C:\TestsFarmacia";

        static void Main(string[] args)
        {
            Medico MedicoPrueba = new Medico()
            {
                Nombre = "Alejandro Valenzuela Rivera",
                Cedula = "FKLAJF4728134",
                NumeroCita = "2356"
            };

            Console.WriteLine($"Nombre: {MedicoPrueba.Nombre}");
            Console.WriteLine($"Cedula: {MedicoPrueba.Cedula}");
            Console.WriteLine($"NumeroCita: {MedicoPrueba.NumeroCita}");
        }
    }
}
