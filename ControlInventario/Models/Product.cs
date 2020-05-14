using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace ControlInventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public String ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SupplirdId { get; set; }
    }
}