<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Intranet.Master" AutoEventWireup="true" CodeBehind="VerificarInformacao.aspx.cs" Inherits="App_Residuos_Urbanos.Web.VerificarInformacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolderTitulo" runat="server">
   <h1> Verificar Informação</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../css/BootStrap.mim.css"/>
    <style type="text/css">

       
    </style>
    
    <script type="text/javascript">

        $(function () {
            $(".close").click(function () {
                $("#DivMensagem").alert('close');
            });
        });

        function MostrarOcultarDiv(res) {

           // var resultado = res;
            var div = document.getElementById("DivMensagem");

            if (res == 0) {
                div.style.display = "inline-block";
            } else if (res == 1) {
                div.style.display = "none";
            }
                          
        }

        function MostrarOcultarDiv2() {
            var div = document.getElementById("DivMensagemSucesso");

            if (div.style.display == "none")
                div.style.display = "inline-block";
            else
                div.style.display = "none";
        }

        function MostrarOcultarDiv3() {
            var div = document.getElementById("DivMensagemDeletes");

            if (div.style.display == "none")
                div.style.display = "inline-block";
            else
                div.style.display = "none";
        }

    </script>
    <form id="form1" runat="server">
    <table style="width: 100%">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
       
<td colspan="2" style="text-align:center">
    
    <asp:Image  ID="ImageVerificacao" runat="server"/>
            <br />
    <br />

    <div id="DivMensagem" class="alert alert-info" style="display:none">
   <a href="#" class="close" data-dismiss="alert">&times;</a>
   <strong>¡Ultima Imagem!</strong> Não tem mais disponiveis.
</div>

 <div id="DivMensagemSucesso" class="alert alert-success" style="display:none">
  <button type="button" class="close" data-dismiss="alert">&times;</button>
  <strong>¡Sucesso!</strong> Foto Adicionada ao Mapa.
</div>

    <div  id="DivMensagemDeletes" class="alert alert-warning alert-dismissable" style="display:none">
  <button type="button" class="close" data-dismiss="alert">&times;</button>
  <strong>¡Excluido!</strong> Foto excluida.
</div>
            </td>

        </tr>
        <tr>
            <td style="text-align:right">
                <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" />
            </td>
            <td style="text-align:left">
                <asp:Button ID="btnProximo" runat="server" Text="Proximo" OnClick="btnProximo_Click" />
            </td>
        </tr>
        <tr>
            <td style="text-align:center">
                <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar/Aprovar" OnClick="btnAdicionar_Click" />
            </td>
            <td style="text-align:center">
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir/Desaprovar" OnClick="btnExcluir_Click" />
            </td>
        </tr>
    </table>
  
         <br />
         <br />
    </form>
</asp:Content>

