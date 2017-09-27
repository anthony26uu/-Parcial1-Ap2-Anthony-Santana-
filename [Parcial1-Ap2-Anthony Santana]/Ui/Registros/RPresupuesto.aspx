<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RPresupuesto.aspx.cs" Inherits="_Parcial1_Ap2_Anthony_Santana_.Ui.Registros.RPresupuesto" %>



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
       <form id="form1" runat="server" >
       
    
            <!--Menu -->
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
				font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
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

		<div id="header" >
			<ul class="nav">
				

				<li><a href="">Registros</a>
					<ul>
						<li><a href="RPresupuesto.aspx">Registro Presupuestos</a></li>
						
						
					</ul>
				</li>
				<li><a href="">Consultas</a>
					<ul>
						<li><a href="../Consultas/CPresupuesto.aspx">Presupuestos</a></li>
						
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
            
       
        
       
      
                
          <div class="text-center">
                <h1 class="page-header text-center"> Registro Presupuestos  <span class="glyphicon glyphicon-list-alt"></span></h1>
               </div>
        <span class="label label-primary">ID Presupuesto </span>
         
            <asp:TextBox ID="TextBoxID" class="input-lg" placeholder="ID a buscar "  runat="server"   Height="30px"  Width="160px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxID" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="buscar"></asp:RequiredFieldValidator>
            <asp:Button ID="BotonBuscar" CssClass="btn btn-primary btn-md boton" runat="server" Text="Buscar" Height="32px" ValidationGroup="buscar" OnClick="BotonBuscar_Click"  />
        
             <br />
        
        <br />
                   <br />
              <!--Texbox -->
             
             <div class="input-group">
         
                <asp:TextBox ID="TextBoxDescrip" placeholder="Descripcion Presupuesto"  class="input-lg"   runat="server"  Height="30px" Width="199px" ValidationGroup="guardar"></asp:TextBox>
   
           <!--Texbox -->
        
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxDescrip" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
        
               <asp:TextBox ID="TextFecha" runat="server" placeholder="00/00/0000 "  class="input-lg"  ReadOnly="True" Width="201px" Height="30px" ValidationGroup="guardar"></asp:TextBox>

       
          <!--Texbox -->

                <asp:TextBox ID="TextBoxMonto" placeholder="99999.99"  class="input-lg"  runat="server"   Height="30px" Width="199px" ValidationGroup="guardar"></asp:TextBox>

                 <asp:RegularExpressionValidator ID="RegularExpressionValidator7"
    ControlToValidate="TextBoxMonto" runat="server"
    ErrorMessage="Solo Numeros"
    ValidationExpression="\d+" ForeColor="Red" ValidationGroup="guardar"></asp:RegularExpressionValidator>
       
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxMonto" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
               
                <br />
                <br />
                     </div>

   
             <!--Botones -->
         
             <div class="left">
                <asp:Button ID="Button4"  CssClass="btn btn-primary btn-md boton"  runat="server" Text="Nuevo"  Height="36px" Width="88px" OnClick="Button4_Click" />
                <asp:Button ID="ButtonGuardar" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Guardar" Height="36px" Width="88px" ValidationGroup="guardar" OnClick="Button2_Click" />
                <asp:Button ID="ButtonEliminar" CssClass="btn btn-primary btn-md boton"  runat="server" Text="Eliminar" Height="36px" Width="88px" ValidationGroup="buscar" OnClick="ButtonEliminar_Click" />
            </div>
                      
          <br />

                  <!--Mensaje de copyright -->
        <div class="list-group-item-success">

            <div class="text-center">

           
             
                <p><span class="glyphicon glyphicon-copyright-mark"></span>     Anthony Javier Santana  Polanco 2014-0527       </p>
           
                    </div>
                
       </div>

            
                
           
      
               
    </form>
        
     
          
</body>
     
                
</html>
