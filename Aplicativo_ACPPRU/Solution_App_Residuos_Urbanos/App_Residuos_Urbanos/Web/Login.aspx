<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Intranet.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="App_Residuos_Urbanos.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolderTitulo" runat="server">
    <h1>Login</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
    <div>
    <table>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Senha</td>
                <td>
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnAccesar" runat="server" Text="Accesar" OnClick="btnAccesar_Click" />
                </td>
            </tr>
     </table>
    </div>
    </form>
</asp:Content>
