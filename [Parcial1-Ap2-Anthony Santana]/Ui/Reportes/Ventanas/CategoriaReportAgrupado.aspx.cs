using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial1_Ap2_Anthony_Santana_.Ui.Reportes.Ventanas
{
    public partial class CategoriaReportAgrupado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            this.ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            this.ReportViewer1.Reset();            
            this.ReportViewer1.LocalReport.ReportPath = @"C:\Users\antho\Desktop\Nueva carpeta\[Parcial1-Ap2-Anthony Santana]\[Parcial1-Ap2-Anthony Santana]\Ui\Reportes\CategoriaReportAgrupado.rdlc";
            this.ReportViewer1.LocalReport.DataSources.Clear();
            this.ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetR", Consultas.CPresupuesto.Lista));
            this.ReportViewer1.LocalReport.Refresh();

        }
    }
}