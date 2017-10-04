using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }


        public Categorias()
        {

        }
     
        public Categorias(int catgoriaID, string nombre)
        {
            this.CategoriaId = catgoriaID;
            this.NombreCategoria = nombre;
        }

    }
}
