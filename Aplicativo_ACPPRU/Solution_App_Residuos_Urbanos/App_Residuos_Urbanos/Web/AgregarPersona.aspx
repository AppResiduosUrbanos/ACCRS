<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Intranet.Master" AutoEventWireup="true" CodeBehind="AgregarPersona.aspx.cs" Inherits="App_Residuos_Urbanos.Web.Mantenimiento.AgregarPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolderTitulo" runat="server">
    <h1>Adicionar Pessoa</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
     <table  >
            <tr>
                <td>Nome</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Sobrenome</td>
                <td>
                    <asp:TextBox ID="txtSob" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefone</td>
                <td>
                    <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Endereço</td>
                <td>
                    <asp:TextBox ID="txtEnder" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>cpf</td>
                <td>
                    <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tipo Documento</td>
                <td>
                    <asp:DropDownList ID="ddlTipDoc" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Num. Documento</td>
                <td>
                    <asp:TextBox ID="txtNumDoc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Ciudade</td>
                <td>
                    <asp:TextBox ID="txtCiu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
