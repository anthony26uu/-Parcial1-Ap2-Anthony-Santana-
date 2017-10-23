<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_Parcial1_Ap2_Anthony_Santana_.Login" %>



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


    





        <h1 class="page-header text-center">Iniciar Seccion <span class="glyphicon glyphicon-user"></span></h1>


        <div class="text-center">


            <!--Texbos Buscar y descrpcion o nombre -->



            <br />
            <asp:TextBox ID="Textid" placeholder="Usuario" class="input-lg" runat="server" Height="30px" Width="134px" ValidationGroup="buscar" OnTextChanged="Textid_TextChanged"></asp:TextBox>
            <br />

            <br />


            <asp:TextBox ID="Textnombre" placeholder="Contraseña" class="input-lg" runat="server" Height="30px" Width="162px"></asp:TextBox>

            <br />
            <br />
        </div>

        <!--Botones -->

        <div class="text-center">
            <asp:Button ID="Button3" CssClass="btn btn-primary btn-md boton" runat="server" Text="Iniciar" Height="36px" OnClick="Button3_Click" />
        </div>

    </form>


    <p>
    </p>

    <!--Mensaje de copyright -->
    <div class="list-group-item-success">

        <div class="text-center">



            <p><span class="glyphicon glyphicon-copyright-mark"></span>Anthony Javier Santana  Polanco 2014-0527       </p>

        </div>

    </div>


</body>
</html>
