﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiRESTCenso.Models
{
	public class clsCenso
	{
        //DEFINICIÓN DE LA ESTRUCTURA DE LOS DATOS APLICADOS 
		public int id { get; set; }
        public string curp { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string direccion { get; set; }
        public string actividadEconomica { get; set; }
    }
}