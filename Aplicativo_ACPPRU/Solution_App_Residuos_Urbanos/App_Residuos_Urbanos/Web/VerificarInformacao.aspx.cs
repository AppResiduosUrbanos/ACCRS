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
    public partial class VerificarInformacao : System.Web.UI.Page
    {
        public List<BEImagem> listImagens = null;
        string error = "";
       
        #region ViewState
        public List<BEImagem> ListImagem_Aux
        {
            get
            {
                if (this.ViewState["ListImagem_Aux"] == null)
                {
                    this.ViewState["ListImagem_Aux"] = new List<BEImagem>();
                }
                return (List<BEImagem>)(this.ViewState["ListImagem_Aux"]);
            }
             set { this.ViewState["ListImagem_Aux"] = value; 
            }
            
        }

        public int PosicionImage
        {
            get
            {
                if (this.ViewState["PosicionImage"] != null)
                {
                    return (int)(this.ViewState["PosicionImage"]);
                }
                return new int();
            }
            set { this.ViewState["PosicionImage"] = value; }
        }

        public int CodigoImage
        {
            get
            {
                if (this.ViewState["CodigoImage"] != null)
                {
                    return (int)(this.ViewState["CodigoImage"]);
                }
                return new int();
            }
            set { this.ViewState["CodigoImage"] = value; }
        }

        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarImagens();
            }
           
        }

        public void cargarImagens()
        {
            try
            {
                BLLImagem bllLocalizacao = new BLLImagem();
                //listImagens = new List<BEImagem>();
                //listImagens = bllLocalizacao.ObterImagens();
                ListImagem_Aux = bllLocalizacao.ObterImagens();
                foreach (BusinessEntities.BEImagem imagens in ListImagem_Aux)
                {
                    ImageVerificacao.ImageUrl = imagens.str_pathImagem;
                    CodigoImage = imagens.int_idImagem;
                    PosicionImage = imagens.int_posicion;
                    break;
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }


        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:MostrarOcultarDiv2();</script>");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:MostrarOcultarDiv3();</script>");
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            
            int res=cargaImagem("A");
            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:MostrarOcultarDiv(" + res + ");</script>");
            
          
        }

        protected void btnProximo_Click(object sender, EventArgs e)
        {
            
            int res = cargaImagem("P");
            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:MostrarOcultarDiv(" + res + ");</script>");
            
           
        }

        int cargaImagem(string tipo)
        {
            BEImagem imagen = new BEImagem();
            if (PosicionImage == 0 && tipo.Equals("A"))
            {
                return 0;
            }
            else if (PosicionImage != 0 && tipo.Equals("A"))
            {
                PosicionImage--;
            }

             if (ListImagem_Aux.Count - 1 == PosicionImage && tipo.Equals("P")) 
             {
                 return 0;
             }
             else if (ListImagem_Aux.Count - 1 != PosicionImage && tipo.Equals("P"))
             {
                 PosicionImage++;
             }
            foreach (BusinessEntities.BEImagem imagens in ListImagem_Aux)
            {

               

                if (imagens.int_posicion == PosicionImage)
                {

                        ImageVerificacao.ImageUrl = imagens.str_pathImagem;
                        CodigoImage = imagens.int_idImagem;
                        PosicionImage = imagens.int_posicion;
                        return 1;
                 }
            }
             return 0;
            
        }
       
    }
}