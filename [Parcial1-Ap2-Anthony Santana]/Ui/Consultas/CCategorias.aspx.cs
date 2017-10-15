using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace _Parcial1_Ap2_Anthony_Santana_.Ui.Consultas
{
    public partial class CCategorias : System.Web.UI.Page
    {

        public static List<Categorias> Lista { get; set; }
        public static List<Presupuestos> Listat { get; set; }
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

            //Consulta Por monto
            else if (DropFiltro.SelectedIndex == 3)
            {
                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo ID Vaccio');</script>");
                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {                    
                        if (Lista.Count == 0)
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Categorias ');</script>");
                            buscaText.Text = "";
                            buscaText.Focus();
                        }
                        else
                        {
                            SqlConnection con = new SqlConnection();
                            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\antho\Desktop\Nueva carpeta\[Parcial1-Ap2-Anthony Santana]\[Parcial1-Ap2-Anthony Santana]\App_Data\RegistrosDb.mdf;Integrated Security=True;Connect Timeout=30";
                            SqlCommand command = new SqlCommand();
                            command.Connection = con;
                            command.CommandText = " SELECT  Presupuestos.CategoriaId, c.NombreCategoria AS Descripcion,  SUM(Presupuestos.Monto) AS Total  FROM Presupuestos INNER JOIN Categorias c ON Presupuestos.CategoriaId = c.CategoriaId where Presupuestos.CategoriaId = '" + Utilidades.TOINT(buscaText.Text) + "' GROUP BY Presupuestos.CategoriaId,c.NombreCategoria  ";
                            DataTable data = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            if (con.ConnectionString== null)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fallo en CONEXIÓN ');</script>");


                            }else
                            {

                            if (adapter.Fill(data) != 0)
                            {
                                PresupuestoGrid.DataSource = data;
                                PresupuestoGrid.DataBind();
                                con.Close();
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Cargo Correctamente');</script>");
                                                              
                            }
                            else
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se registro Presupuesto con este ID');</script>");
                                
                            }

                        }

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