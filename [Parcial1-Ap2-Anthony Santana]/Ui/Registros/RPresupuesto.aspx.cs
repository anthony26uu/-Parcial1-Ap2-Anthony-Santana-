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
        Presupuestos p = new Presupuestos();
        protected void Page_Load(object sender, EventArgs e)
        {

            TextFecha.Text = (DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);

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

            TextBoxID.Focus();

        }
      

        protected void Button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            var guardar = new Presupuestos();
            int id = 0;
            try
            {
                if (IsValid)
                {

                        guardar.PresupuestoId = (Utilidades.TOINT(TextBoxID.Text));
                        guardar.Descripcion = TextBoxDescrip.Text;
                        guardar.Monto = Convert.ToDecimal(TextBoxMonto.Text);
                    

                        guardar.Fecha = Convert.ToDateTime(TextFecha.Text);





                    if (id != guardar.PresupuestoId)
                            {

                           
                               PresupuestoBLL.Mofidicar(guardar);

                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto modificado con exito');</script>");


                            }
                            else
                            {
                                PresupuestoBLL.Mofidicar(guardar);
                                PresupuestoBLL.Guardar(guardar);
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Nuevo Presupuesto agregado!');</script>");


                            }
                      

                    
                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
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
                var bll = new PresupuestoBLL();
                var presu = PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
                if (PresupuestoBLL.Eliminar(presu))
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('El Presupuesto se ha Eliminado  con exito');</script>");

                    Limpiar();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se pudo eliminar El Presupuesto');</script>");


                }
            }

        }

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {


                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe Presupuesto con este ido');</script>");


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


                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Resultados');</script>");


                }
                else
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe presupuesto ese id');</script>");


                }
            }
        }
    }
}