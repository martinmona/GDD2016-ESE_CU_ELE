﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.Class
{
    public class Usuario
    {
        public decimal id { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public int intentos { get; set; }
        public bool habilitado { get; set; }
        public Usuario() { }
    }
}
