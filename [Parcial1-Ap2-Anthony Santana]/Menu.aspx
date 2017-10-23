<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="_Parcial1_Ap2_Anthony_Santana_.Menu" %>




<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <!--Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>



    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">

        <html>
        <head>
            <title>Menu Desplegable</title>
            <style type="text/css">
                * {
                    margin: 0px;
                    padding: 0px;
                }

                #header {
                    border: ridge;
                    margin: auto;
                    width: 100%;
                    font-family: Arial, Helvetica, sans-serif;
                    height: 60px;
                }

                ul, ol {
                    list-style: none;
                }

                .nav {
                    width: 100%;
                    margin: auto;
                    height: 55px;
                }

                    .nav > li {
                        float: left;
                    }

                    .nav li a {
                        background-color: steelblue;
                        color: #fff;
                        text-decoration: none;
                        padding: 10px 12px;
                        display: block;
                    }

                        .nav li a:hover {
                            background-color: #434343;
                        }

                    .nav li ul {
                        display: none;
                        position: absolute;
                        min-width: 140px;
                    }

                    .nav li:hover > ul {
                        display: block;
                    }

                    .nav li ul li {
                        position: relative;
                    }

                        .nav li ul li ul {
                            right: -140px;
                            top: 0px;
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






        <h1 class="page-header text-center">INICIO <span class="glyphicon glyphicon-list-alt"></span></h1>
        <p class="page-header text-center">
            <asp:Image ID="Image1" runat="server" Height="363px" ImageUrl="~/Ui/descarga.jpg" Width="874px" />
        </p>




        <!--Texbos Buscar y descrpcion o nombre -->


    </form>

    <!--Mensaje de copyright -->
    <div class="list-group-item-success">

        <div class="text-center">



            <p><span class="glyphicon glyphicon-copyright-mark"></span>Anthony Javier Santana  Polanco 2014-0527       </p>

        </div>

    </div>


</body>
</html>
