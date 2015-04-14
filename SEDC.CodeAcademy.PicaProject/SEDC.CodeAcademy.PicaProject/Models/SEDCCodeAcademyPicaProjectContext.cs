using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SEDC.CodeAcademy.PicaProject.Models
{
    public class SEDCCodeAcademyPicaProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SEDCCodeAcademyPicaProjectContext() : base("name=SEDCCodeAcademyPicaProjectContext")
        {
        }

        public System.Data.Entity.DbSet<SEDC.CodeAcademy.PicaProject.Models.Pizza> Pizzas { get; set; }

        public System.Data.Entity.DbSet<SEDC.CodeAcademy.PicaProject.Models.Order> Orders { get; set; }
    
    }
}
