using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicalLayer;

namespace App_Residuos_Urbanos.Web
{
    public partial class MantPessoas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLLPessoa bllPessoa = new BLLPessoa();
            DataTable dt = new DataTable();

            dt = bllPessoa.GetPessoas();

            gvPessoas.DataSource = dt;
            gvPessoas.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPersona.aspx");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AtualizarPessoa.aspx");
        }
    }

}