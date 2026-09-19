using System;
using System.Collections.Generic;
using System.Text;

namespace MySql
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public byte[] imagen { get; set; }

    }
}
