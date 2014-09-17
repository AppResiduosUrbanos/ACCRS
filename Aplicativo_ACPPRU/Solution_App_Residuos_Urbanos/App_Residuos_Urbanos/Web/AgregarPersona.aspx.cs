using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntities;
using BusinessLogicalLayer;

namespace App_Residuos_Urbanos.Web.Mantenimiento
{
    public partial class AgregarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BLLPessoa bllPessoa = new BLLPessoa();
            DataTable dt = new DataTable();
            dt = bllPessoa.GetTipoDocumento();
            ddlTipDoc.DataSource = dt;
            ddlTipDoc.DataTextField = "nome_body";
            ddlTipDoc.DataValueField = "idBody";

            ddlTipDoc.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            BLLPessoa bllPessoa = new BLLPessoa();
            BEPessoa pessoa = new BEPessoa();

            pessoa.str_nome = txtNome.Text;
            pessoa.str_sobrenome = txtSob.Text;
            pessoa.str_telefone = txtTel.Text;
            pessoa.str_email = txtEmail.Text;
            pessoa.str_endereco = txtEnder.Text;
            pessoa.int_cpf = Convert.ToInt32(txtCpf.Text);
            pessoa.int_idTipDoc = Convert.ToInt32(ddlTipDoc.SelectedValue);
            pessoa.str_numDoc = txtNumDoc.Text;
            pessoa.str_cidade = txtCiu.Text;

            bllPessoa.IncluirPessoa(pessoa);

            Response.Redirect("MantPessoas.aspx");
        }
        
    }
}