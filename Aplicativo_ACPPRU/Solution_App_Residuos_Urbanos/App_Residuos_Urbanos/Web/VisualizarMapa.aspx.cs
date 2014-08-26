using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicalLayer;
using BusinessEntities;
namespace App_Residuos_Urbanos.Web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        public List<BECoordenada> listaCoordenadas = null;
        string error = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarCoordenadas();
        }

        void cargarCoordenadas()
        {
            try
            {
                BLLCoordenada bllLocalizacao = new BLLCoordenada();
                listaCoordenadas = new List<BECoordenada>();
                listaCoordenadas = bllLocalizacao.ObterCorrdenadas();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }

    }
}