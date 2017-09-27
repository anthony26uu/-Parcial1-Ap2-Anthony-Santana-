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

            Presupuestos presupuesto = new Presupuestos();
            PresupuestoGrid.DataSource = PresupuestoBLL.GetListodo();
            PresupuestoGrid.DataBind();
            Lista = PresupuestoBLL.GetListodo();
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            RequiredFieldValidator3.Text = "";

            desdeFecha.Text = Convert.ToString(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);


 


        }
        public static List<Presupuestos> Lista { get; set; }


        public void Selecionar(int id)
        {



            if (DropFiltro.SelectedIndex == 0)
            {
                buscaText.Text = "";
                RequiredFieldValidator1.Enabled = false;
                RequiredFieldValidator2.Enabled = false;
                RequiredFieldValidator3.Enabled = false;



                if (PresupuestoBLL.GetListodo().Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado Presupuestos');</script>");

                }
                else
                {
                    Lista = PresupuestoBLL.GetListodo();
                    PresupuestoGrid.DataSource = Lista;


                }
            }
            else if (DropFiltro.SelectedIndex == 1)
            {
              
                RequiredFieldValidator2.Enabled = false;
                RequiredFieldValidator3.Enabled = false;
                if (string.IsNullOrWhiteSpace(buscaText.Text))
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo ID Vaccio');</script>");

                }
                else
                {


                    if (PresupuestoBLL.GetList(p => p.PresupuestoId == id) != null)
                    {
                        Lista = PresupuestoBLL.GetList(p => p.PresupuestoId == id);
                        PresupuestoGrid.DataSource = Lista;
                        PresupuestoGrid.DataBind();





                    }
                    else if (PresupuestoGrid.DataSource == null)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se han registrado presupuesto con este Id');</script>");


                    }

                }
            }

            else if (DropFiltro.SelectedIndex == 2)
            {
                RequiredFieldValidator1.Enabled = false;

                if (desdeFecha.Text == "" && desdeFecha.Text == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Fecha invalida ');</script>");

                }
                else
                {


                 DateTime desde = Convert.ToDateTime(desdeFecha.Text);
                DateTime hasta = Convert.ToDateTime(desdeFecha.Text);

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
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Ingrese Fecha');</script>");
                }

                }
            }
            else if (DropFiltro.SelectedIndex == 3)
            {
                if (buscaText.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe escribir el Nombre a buscar');</script>");
                }
                else
                {
                    Lista = PresupuestoBLL.GetList(p => p.Descripcion == buscaText.Text);
                    PresupuestoGrid.DataSource = Lista;
                    PresupuestoGrid.DataBind();
                }

            }

            



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Selecionar(Utilidades.TOINT(buscaText.Text));
        }
    }
}