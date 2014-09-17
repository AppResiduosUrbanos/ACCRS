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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccesar_Click(object sender, EventArgs e)
        {
            BLLPessoa bll = new BLLPessoa();
            DataTable dt = new DataTable();

            dt = bll.Logueo(txtEmail.Text, txtSenha.Text);

            if (dt.Rows.Count > 0)
                Response.Redirect("IntranetPrincipal.aspx");
            else
                Response.Redirect("Login.aspx");
        }
    }
}