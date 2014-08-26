using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLogicalLayer
{
    public class BLLCoordenada
    {

        DALCoordenada dalLocalizacao = new DALCoordenada();

        public List<BECoordenada> ObterCorrdenadas()
        {
            return dalLocalizacao.ObterCorrdenadas();

        }
    }
}
