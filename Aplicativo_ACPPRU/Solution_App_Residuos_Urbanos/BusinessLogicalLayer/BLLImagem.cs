using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLogicalLayer
{
    public class BLLImagem
    {
        DALImagem dalImagem = new DALImagem();

        public List<BEImagem> ObterImagens()
        {
            return dalImagem.ObterImagens();

        }
    }
}
