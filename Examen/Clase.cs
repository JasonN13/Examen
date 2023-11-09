using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Clase : Alumnos
    {
        public string? nombreclase;
        public double Horaclase;
        public string? NombreCatedratico;

        public override void MostrarAlumno()
        {
            Console.WriteLine("Datos del alumno");
            Console.WriteLine("Nombre" + Nombre);
            Console.WriteLine("Numero de cuenta" + numerodecuenta);
            Console.WriteLine("Email" + Email);
            Console.WriteLine("");
            Console.WriteLine("Nombre clase" + nombreclase);
            Console.WriteLine("Hora clase" + Horaclase);
            Console.WriteLine("Nombre catedratico" + NombreCatedratico);


        }
    }
}
