using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicalLayer;
using BusinessEntities;

namespace App_Residuos_Urbanos.Web
{
    public partial class AtualizarPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            BLLPessoa bllPessoa = new BLLPessoa();
            BEPessoa pessoa = new BEPessoa();

            pessoa = bllPessoa.GetPessoa(txtNumDoc.Text);

            txtNome.Text = pessoa.str_nome;
            txtSob.Text = pessoa.str_sobrenome;
            txtTel.Text = pessoa.str_telefone;
            txtEmail.Text = pessoa.str_email;
            txtEnder.Text = pessoa.str_endereco;

            hdIdPessoa.Value = pessoa.int_idPessoa.ToString();

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            BLLPessoa bllPessoa = new BLLPessoa();
            BEPessoa pessoa = new BEPessoa();

            pessoa.str_nome = txtNome.Text;
            pessoa.str_sobrenome = txtSob.Text;
            pessoa.str_telefone = txtTel.Text;
            pessoa.str_email = txtEmail.Text;
            pessoa.str_endereco = txtEnder.Text;

            pessoa.int_idPessoa = int.Parse(hdIdPessoa.Value);

            bllPessoa.AtualizarPessoa(pessoa);

            Response.Redirect("MantPessoas.aspx");

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BLLPessoa bllPessoa = new BLLPessoa();
            bllPessoa.DeletarPessoa(int.Parse(hdIdPessoa.Value));

            Response.Redirect("MantPessoas.aspx");

        }
    }
}