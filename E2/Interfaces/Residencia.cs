using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Interfaces
{
    public interface IResidencia
    {
        string TipoConstrucao { get; set; }
        double ValorCoberto { get; set; }

        public void ExibirInformacoes();
    }
}
