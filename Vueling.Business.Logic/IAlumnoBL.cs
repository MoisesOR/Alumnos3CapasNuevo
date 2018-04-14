﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Models;
using static Vueling.Common.Logic.Enums.TiposFichero;

namespace Vueling.Business.Logic
{
    public interface IAlumnoBL
    {
        Alumno Add(Alumno alumno);
        void CargarDatosDeLosAlumnos(TipoFichero tipoFichero);
        List<Alumno> Leer();
        List<Alumno> Filtrar(string clave, string valor);
        int CalcularEdad(DateTime fechaNacimiento);
    }
}
