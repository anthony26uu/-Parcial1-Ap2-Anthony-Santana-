using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 public   class RegistroDb :DbContext
    {

        public RegistroDb(): base("ConStr")
        {


        }
        public DbSet<Presupuestos> presupuestoDb { get; set; }
        public DbSet<Categorias> categoriaDb { get; set; }



    }
}
