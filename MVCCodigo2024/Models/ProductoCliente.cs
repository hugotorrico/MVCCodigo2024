using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodigo2024.Models
{
    public class ProductoCliente
    {

        public List<Producto> Productos { get; set; }
        public List<Cliente> Clientes { get; set; }

    }
}