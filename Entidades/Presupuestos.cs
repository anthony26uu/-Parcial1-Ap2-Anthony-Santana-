using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Presupuestos
    {
        [Key]
        public int PresupuestoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public string NombreCategoria { get; set; }
        //public int IDCategoria { get; set; }


        public Presupuestos(int presupuestoId, DateTime fecha, string descripcion, decimal monto, string nombrecategoria)
        {
            this.PresupuestoId = presupuestoId;
            this.Fecha = fecha;
            this.Descripcion = descripcion;
            this.Monto = monto;
          ///  this.IDCategoria = iDCategoria;
            this.NombreCategoria = nombrecategoria;



        }
        public Presupuestos()
        {


        }
    }
}
