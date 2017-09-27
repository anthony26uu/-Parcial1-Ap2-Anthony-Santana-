using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class PresupuestoBLL
    {

        public static bool Guardar(Presupuestos nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<Presupuestos>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }

        public static bool Mofidicar(Presupuestos existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Presupuestos>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }



        public static bool Eliminar(Presupuestos id)
        {
            bool resultado = false;
            using (var db = new Repositorio<Presupuestos>())
            {
                resultado = db.Eliminar(id);

            }
            return resultado;
        }


        public static Presupuestos Buscar(Expression<Func<Presupuestos, bool>> tipo)
        {
            Presupuestos Result = null;
            using (var repoitorio = new Repositorio<Presupuestos>())

            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }



        public static List<Entidades.Presupuestos> GetListodo()
        {
            List<Entidades.Presupuestos> lista = new List<Presupuestos>();
            using (var db = new DAL.Repositorio<Presupuestos>())
            {
                try
                {
                    return db.ListaTodo();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


        public static List<Entidades.Presupuestos> GetList(Expression<Func<Entidades.Presupuestos, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Presupuestos>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
