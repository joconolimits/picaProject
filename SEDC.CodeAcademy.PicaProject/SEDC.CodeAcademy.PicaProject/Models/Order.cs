using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.CodeAcademy.PicaProject.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int PizzaID { get; set; }
        public string Address { get; set; }

    }
}
