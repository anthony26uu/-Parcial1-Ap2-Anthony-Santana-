using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Anthony_Santana_.Ui.Consultas
{
    public partial class CPresupuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            Lista = PresupuestoBLL.GetListodo();
            Presupuestos presupuesto = new Presupuestos();
            PresupuestoGrid.DataSource = Lista;
            PresupuestoGrid.DataBind();
            
            buscaText.Focus();
            


        }
        public static List<Presupuestos> Lista { get; set; }
        
        public void Selecionar(int id)
        {

            if (DropFiltro.SelectedIndex == 0)
            {
                buscaText.Text = "";
                if (Lista.Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Presupuestos');</script>");
                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {
                    Lista = PresupuestoBLL.GetListodo();
                    PresupuestoGrid.DataSource = Lista;


                }
            }
            else if (DropFiltro.SelectedIndex == 1)
            {
                
                        Lista = PresupuestoBLL.GetList(p => p.PresupuestoId == id);

                        if (Lista.Count == 0)
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado presupuesto con este Id');</script>");
                            buscaText.Text = "";
                            buscaText.Focus();
                        }
                        else
                        {
                            PresupuestoGrid.DataSource = Lista;
                            PresupuestoGrid.DataBind();
                        }
                                        

                
            }

            else if (DropFiltro.SelectedIndex == 2)
            {

                if (desdeFecha.Text == "" && desdeFecha.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida ');</script>");

                    hastaFecha.Text = "";
                    desdeFecha.Text = "";
                    desdeFecha.Focus();
                }
                else
                {
                  
                    DateTime desde = DateTime.Now;
                    DateTime hasta = DateTime.Now;
                    if (desdeFecha.Text == "")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida ');</script>");
                        hastaFecha.Text = "";
                        desdeFecha.Text = "";
                        desdeFecha.Focus();
                    }
                    else
                    {
                        desde = Convert.ToDateTime(desdeFecha.Text);
                        hasta = Convert.ToDateTime(hastaFecha.Text);
                    }


                    if (desdeFecha.Text != "" && hastaFecha.Text != "")
                    {
                        if (desde <= hasta)
                        {
                           

                            Lista = PresupuestoBLL.GetList(p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date);
                            PresupuestoGrid.DataSource = Lista;
                            PresupuestoGrid.DataBind();

                            
                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida debe ser menor');</script>");
                            desdeFecha.Text = "";
                            hastaFecha.Text = "";
                            desdeFecha.Focus();
                        }
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Ingrese Fecha');</script>");
                        desdeFecha.Focus();
                    }

                }
            }
            else if (DropFiltro.SelectedIndex == 3)
            {
                if (buscaText.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe escribir la descripcion a buscar');</script>");

                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {
                    Lista = PresupuestoBLL.GetList(p => p.Descripcion == buscaText.Text);
                    if (Lista.Count == 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado presupuesto con esa descripcion');</script>");
                        buscaText.Text="";
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
            else if (DropFiltro.SelectedIndex == 4)
            {
                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {
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
                        command.CommandText = " SELECT  Presupuestos.CategoriaId, c.NombreCategoria AS Descripcion, " +
                            "  SUM(Presupuestos.Monto) AS Total  " +
                            "FROM Presupuestos INNER JOIN Categorias c ON Presupuestos.CategoriaId = c.CategoriaId " +
                            "where Presupuestos.CategoriaId = '" + Utilidades.TOINT(buscaText.Text) + "' " +
                            "GROUP BY Presupuestos.CategoriaId,c.NombreCategoria  ";

                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        SqlDataReader reader = null;
                        con.Open();
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Entidades.Presupuestos obj = new Presupuestos();
                            obj.CategoriaId = Convert.ToInt32(reader["CategoriaId"]);
                            obj.Descripcion = Convert.ToString(reader["Descripcion"]);
                            obj.Monto= Convert.ToDecimal(reader["Total"].ToString());
                            Lista.Add(obj);


                        }


                        if (con.ConnectionString == null)
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fallo en CONEXIÓN ');</script>");


                        }
                        else
                        {

                            con.Close();
                            if (adapter.Fill(data) != 0)
                            {
                                PresupuestoGrid.DataSource = data;

                                PresupuestoGrid.DataBind();
                                con.Close();



                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Resultados de su consulta agrupada');</script>");


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