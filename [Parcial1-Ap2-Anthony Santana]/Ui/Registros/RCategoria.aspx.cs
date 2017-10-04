using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Anthony_Santana_.Ui.Registros
{
    public partial class RCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }

        private void Limpiar()
        {
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            Textnombre.Text = "";
            Textid.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textid.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe categoria con este id');</script>");

            }
            else
            {

                int id = int.Parse(Textid.Text);
                Categorias tipo;
                tipo = BLL.CategoriaBLL.Buscar(p => p.CategoriaId == id);
                if (tipo != null)
                {

                    Textnombre.Text = tipo.NombreCategoria;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Resultados de su busqueda');</script>");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe ninguna categoria con ese Id.');</script>");

                }
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textid.Text))
            {

                Limpiar();


            }
            else
            {
                int id = int.Parse(Textid.Text);
                var bll = new BLL.CategoriaBLL();
                var user = CategoriaBLL.Buscar(p => p.CategoriaId == id);
                if (BLL.CategoriaBLL.Eliminar(user))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('La categoria se ha Eliminado  con exito');</script>");

                    Limpiar();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se pudo eliminar la categoria.');</script>");

                }

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var guardar = new Categorias();
            int id = 0;
            try
            {
                if (IsValid)
                {


                    guardar.NombreCategoria = Textnombre.Text;
                    guardar.CategoriaId = (Utilidades.TOINT(Textid.Text));
                    if (id != guardar.CategoriaId)
                    {
                        CategoriaBLL.Mofidicar(guardar);

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Categoria modificada');</script>");


                    }
                    else
                    {
                        CategoriaBLL.Guardar(guardar);
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Nueva Categoria agregada con exito!');</script>");

                        Limpiar();
                    }

                }

            }
            catch (Exception)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Por favor llenar los campos');</script>");


                throw;
            }
        }
    }
}