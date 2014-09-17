<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Intranet.Master" AutoEventWireup="true" CodeBehind="AtualizarPessoa.aspx.cs" Inherits="App_Residuos_Urbanos.Web.AtualizarPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolderTitulo" runat="server">
    <h1>Atualizar Pessoa</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        
    <div>
        <table>
            
            <tr>
                <td>Num. Documento</td>
                <td>
                    <asp:TextBox ID="txtNumDoc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
                </td>
            </tr>

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
                <td>
                    <asp:HiddenField ID="hdIdPessoa" runat="server" />
                    <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnEliminar" runat="server" Text="Deletar" OnClick="btnEliminar_Click" />
                </td>
            </tr>
        </table>
    
    </div>

    </asp:Content>