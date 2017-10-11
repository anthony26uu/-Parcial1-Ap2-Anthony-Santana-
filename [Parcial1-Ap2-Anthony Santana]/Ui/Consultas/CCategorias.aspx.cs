using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Anthony_Santana_.Ui.Consultas
{
    public partial class CCategorias : System.Web.UI.Page
    {

        public static List<Categorias> Lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            Categorias presupuesto = new Categorias();
            PresupuestoGrid.DataSource = CategoriaBLL.GetListodo();
            PresupuestoGrid.DataBind();
            Lista = CategoriaBLL.GetListodo();
            buscaText.Focus();

        }


        public void Selecionar(int id)
        {

            if (DropFiltro.SelectedIndex == 0)
            {
                buscaText.Text = "";



                if (CategoriaBLL.GetListodo().Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Categorias');</script>");
                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {
                    Lista = CategoriaBLL.GetListodo();
                    PresupuestoGrid.DataSource = Lista;


                }
            }
            else if (DropFiltro.SelectedIndex == 1)
            {


                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo ID Vaccio');</script>");
                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {


                    if (CategoriaBLL.GetList(p => p.CategoriaId == id) != null)
                    {
                        Lista = CategoriaBLL.GetList(p => p.CategoriaId == id);

                        if (Lista.Count == 0)
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Categorias con este Id');</script>");
                            buscaText.Text = "";
                            buscaText.Focus();
                        }
                        else
                        {
                            PresupuestoGrid.DataSource = Lista;
                            PresupuestoGrid.DataBind();
                        }






                    }
                    else if (PresupuestoGrid.DataSource == null)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Categoria con este Id');</script>");
                        buscaText.Text = "";
                        buscaText.Focus();

                    }

                }
            }

            else if (DropFiltro.SelectedIndex == 2)
            {
                if (buscaText.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe escribir la descripcion a buscar');</script>");

                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {
                    Lista = CategoriaBLL.GetList(c => c.NombreCategoria == buscaText.Text);
                    if (Lista.Count == 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado categoria con esa descripcion');</script>");
                        buscaText.Text = "";
                        buscaText.Focus();
                    }
                    else
                    {
                        PresupuestoGrid.DataSource = Lista;
                        PresupuestoGrid.DataBind();
                    }





                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }
    }
}