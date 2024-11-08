﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class Tarea
    {
        public string NombreTarea { get; set; }
        public double Duracion { get; set; } 
        public Empleado EmpleadoAsignado { get; set; }

        public Tarea(string nombreTarea, double duracion, Empleado empleado)
        {
            NombreTarea = nombreTarea;
            Duracion = duracion;
            EmpleadoAsignado = empleado;
        }
    }
}
