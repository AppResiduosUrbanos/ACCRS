<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Intranet.Master" AutoEventWireup="true" CodeBehind="MantPessoas.aspx.cs" Inherits="App_Residuos_Urbanos.Web.MantPessoas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolderTitulo" runat="server">
    <h1>Mantener Pessoas</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">
    <div>Manutenção de Pessoas</div>
        <br/>
        <br/>
    <div>
        <asp:GridView ID="gvPessoas" runat="server">           
        </asp:GridView>
    </div>
    <br/>
        <br/>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
                    </td>
                </tr>
            </table>
     </div>
    </form>
</asp:Content>
