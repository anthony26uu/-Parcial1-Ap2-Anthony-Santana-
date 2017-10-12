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
    public partial class RPresupuesto : System.Web.UI.Page
    {
        Presupuestos presupuestos = new Presupuestos();

        protected void Page_Load(object sender, EventArgs e)
        {

            TextFecha.Text = (DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
            TextBoxID.Focus();
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            
        }

        private void Limpiar()
        {
            TextBoxDescrip.Text = "";
            TextBoxMonto.Text = "";
            TextBoxID.Text = "";
            TextFecha.Text = (DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
            RequiredFieldValidator5.Text = "";
            RequiredFieldValidator6.Text = "";
            RequiredFieldValidator1.Text = "";
            TextBoxID.Focus();

        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public Presupuestos LlenarCampos()
        {
            presupuestos.PresupuestoId = Utilidades.TOINT(TextBoxID.Text);
            presupuestos.Descripcion = TextBoxDescrip.Text;
            presupuestos.Fecha = Convert.ToDateTime(TextFecha.Text);
            presupuestos.Monto = Convert.ToDecimal(TextBoxMonto.Text);
            return presupuestos;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {

           
            int id = 0;
           
                if (IsValid)
                {

                    presupuestos =   LlenarCampos();


                    if (id != presupuestos.PresupuestoId)
                    {

                        if (PresupuestoBLL.Mofidicar(presupuestos))
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto modificado con exito');</script>");

                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto No pudo ser modificado');</script>");

                        }


                    }
                    else
                    {

                        if (PresupuestoBLL.Guardar(presupuestos))
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Nuevo Presupuesto agregado!');</script>");

                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se pudo  agregado presupuesto');</script>");

                        }


                    }

                }
                Limpiar();


            
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Presupuesto con este id');</script>");
                Limpiar();


            }
            else
            {
                int id = int.Parse(TextBoxID.Text);

                var presu = PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
                if (presu != null)
                {
                    PresupuestoBLL.Eliminar(presu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('El Presupuesto se ha Eliminado  con exito');</script>");

                    Limpiar();
                }

                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se pudo eliminar El Presupuesto compruebe existencia');</script>");
                    Limpiar();
                }
            }


        }

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {


                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Presupuesto con ese id');</script>");
                Limpiar();
            }
            else

            {

                int id = int.Parse(TextBoxID.Text);
                var presu = PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
                if (presu != null)
                {

                    TextBoxMonto.Text = Convert.ToString(presu.Monto);
                    TextFecha.Text = (presu.Fecha.Year + "-" + presu.Fecha.Month + "-" + presu.Fecha.Day);
                    TextBoxDescrip.Text = presu.Descripcion;
                    DropDownList1.Text = presu.NombreCategoria;

                 //   Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Resultados');</script>");


                }
                else
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe presupuesto ese id');</script>");
                    Limpiar();

                }
            }
        }
    }
}