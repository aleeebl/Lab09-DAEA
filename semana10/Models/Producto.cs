﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace semana10.Models
{
    public class Producto
    {
  
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
