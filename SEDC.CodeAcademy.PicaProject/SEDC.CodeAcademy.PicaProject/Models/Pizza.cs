using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.CodeAcademy.PicaProject.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

       
    }
}