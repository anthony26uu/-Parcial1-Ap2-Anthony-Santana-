﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RCategoria.aspx.cs" Inherits="_Parcial1_Ap2_Anthony_Santana_.Ui.Registros.RCategoria" %>


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

</head>
<body>
    <form id="form1" runat="server" >
         
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
						<li><a href="RPresupuesto.aspx">Presupuesto</a></li>
					
						
					</ul>
				</li>
				<li><a href="">Consultas</a>
					<ul>
						<li><a href="../Consultas/CPresupuesto.aspx">Presupuesto</a></li>
                        <li><a href="../Consultas/CCategorias.aspx">Categorias</a></li>
						
					</ul>
				</li>
				
               
			    <li>
                    <br />
                </li>
			</ul>
		</div>
	</body>
</html>

        

 
     

          <h1 class="page-header text-center">

                   Reporte de Compras <span class=" 	glyphicon glyphicon-shopping-cart"></span></h1  >
         

        
                  
   <!--Texbos Buscar y descrpcion o nombre -->
           
                
             <span class="label label-primary">ID Categoria</span>
              <asp:TextBox ID="Textid" placeholder="Id a Buscar"  class="input-lg"  runat="server" Height="30px" Width="134px" ValidationGroup="buscar"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textid" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="buscar"></asp:RequiredFieldValidator>
              <asp:Button ID="Button1"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Buscar" OnClick="Button1_Click" Height="31px" />
     
    
             <asp:TextBox ID="Textnombre"  placeholder="Descripcion" class="input-lg" runat="server" Height="30px" Width="162px"></asp:TextBox>
 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Textnombre" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
 
           <br />
                <br />
             
   <!--Botones -->
         
             <div class="left">
        <asp:Button ID="Button2"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Nuevo" OnClick="Button2_Click" Height="36px" />
        <asp:Button ID="Button3"  CssClass="btn btn-primary btn-md boton" runat="server" OnClick="Button3_Click" Text="Guardar" Height="36px" ValidationGroup="guardar" />
        <asp:Button ID="Button4"  CssClass="btn btn-primary btn-md boton" runat="server" Text="Eliminar" OnClick="Button4_Click" Height="36px" ValidationGroup="buscar" />
  </div>

    </form>
   

    <p>
        </p>

                 <!--Mensaje de copyright -->
        <div class="list-group-item-success">

            <div class="text-center">

           
             
                <p><span class="glyphicon glyphicon-copyright-mark"></span>     Anthony Javier Santana  Polanco 2014-0527       </p>
           
                    </div>
                
       </div>


</body>
</html>