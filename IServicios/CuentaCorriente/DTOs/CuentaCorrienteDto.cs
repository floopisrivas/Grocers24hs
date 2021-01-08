﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.CuentaCorriente.DTOs
{
    public class CuentaCorrienteDto
    {

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public string FechaStr => Fecha.ToShortDateString();

        public string HoraStr => Fecha.ToShortDateString();

        public decimal Monto { get; set; }

        public string MontoStr => Monto.ToString("C");


    }
}
