<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CPresupuesto.aspx.cs" Inherits="_Parcial1_Ap2_Anthony_Santana_.Ui.Consultas.CPresupuesto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

             <!--Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
   


  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    <!--Hoja de estilos Css -->

</head>
<body>
    <form id="form1" runat="server">

          <html>
	<head>
		<title>Menu Desplegable</title>
<style type="text/css">
			
			* {
				margin:0px;
				padding:0px;
			}
			
			#header {
                border:ridge;
				margin:auto;
				width:100%;
				font-family:Arial, Helvetica, sans-serif;
            height: 60px;
        }
			
			ul, ol {

				list-style:none;
			}
			
			.nav {
				width:100%;
				margin:auto;
            height: 55px;
        }
 
			.nav > li {
				float:left;
			}
			
			.nav li a {
				background-color:steelblue;
				color:#fff;
				text-decoration:none;
				padding:10px 12px;
				display:block;
			}
			
			.nav li a:hover {
				background-color:#434343;
			}
			
			.nav li ul {

				display:none;
				position:absolute;
				min-width:140px;
			}
			
			.nav li:hover > ul {
				display:block;
			}
			
			.nav li ul li {
				position:relative;
			}
			
			.nav li ul li ul {
				right:-140px;
				top:0px;
			}
			
		.boton {
           
		}
			
		</style>

	</head>
	<body>
		<div id="header">
			<ul class="nav">
				
           

				<li><a href="">Registros</a>
					<ul>
						<li><a href="../Registros/RPresupuesto.aspx">Registro Presupuestos</a></li>
						
					</ul>
				</li>
				<li><a href="">Consultas</a>
					<ul>
						<li><a href="CPresupuesto.aspx">Presupuesto</a></li>
						
					</ul>
				</li>
			
                </li>
                <li></li>
                <li></li>
			    <li>
                    <br />
                </li>
			</ul>
		</div>
	</body>
</html>


          <header>
            <h1 class="page-header text-center">

                  CONSULTA PRESUPUESTOS <span class="glyphicon glyphicon-list-alt"></span></h1>
        </header>

         
       
          <span class="label label-primary">Selecione-</span>
          <asp:DropDownList ID="DropFiltro" CssClass="custom-select" runat="server" Height="30px" > 
            
              <asp:ListItem>Todo</asp:ListItem>
              <asp:ListItem>ID</asp:ListItem>
              <asp:ListItem>Fecha</asp:ListItem>
              <asp:ListItem>Nombre</asp:ListItem>
          </asp:DropDownList>
      
               

       
           
          <span class="label label-primary">ID / Nombre</span>
        
          <asp:TextBox ID="buscaText" runat="server"    class="input-lg" placeholder="ID a buscar" Height="30px" ></asp:TextBox>
        
         <asp:Button ID="Button1" runat="server" Text="Buscar" Height="36px" Width="88px" CssClass="btn btn-primary btn-md boton" OnClick="Button1_Click" ValidationGroup="buscar" />
 
              <br />
              <br />
        
         <span class="label label-primary">Desde</span>
          
       
            &nbsp;&nbsp;<asp:TextBox ID="desdeFecha"  class="input-lg" placeholder="0000-00-00 "  runat="server" Width="141px" Height="30px" ValidationGroup="buscar"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;<span class="label label-primary">Hasta</span>
            
            <asp:TextBox ID="hastaFecha"   class="input-lg" placeholder="2017-00-00 " runat="server" Height="30px" Width="162px" ValidationGroup="buscar"></asp:TextBox>
        
          <br />    
        <br />
             


                <asp:GridView ID="PresupuestoGrid" runat="server"  BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="18px" Width="505px">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
           <br />
        <a href="../Reportes/Ventanas/PresupuestoReport.aspx" class="btn btn-info btn-lg">
          <span class="glyphicon glyphicon-print"></span> Imprimir
        </a> 
               <br />
     

        </form>
             <!--Mensaje de copyright -->
        <div class="list-group-item-success">

            <div class="text-center">

           
             
                <p><span class="glyphicon glyphicon-copyright-mark"></span>     Anthony Javier Santana  Polanco 2014-0527       </p>
           
                    </div>
            

</body>
</html>
