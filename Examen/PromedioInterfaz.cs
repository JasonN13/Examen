﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal interface PromedioInterfaz
    {
        string mostrarPromedio();
        string mostrarPromedio(double nota1, double nota2, double nota3);
        double calcularPromedio();
        double calcularPromedio(double nota1, double nota2, double nota3);
    }
}
