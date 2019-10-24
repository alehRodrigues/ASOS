using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class DisplacementOrder
    {
        public int DeslocamentoId { get; set; }
        public Displacement Deslocamento { get; set; }

        public int OrdemServicoId { get; set; }
        public ServiceOrder OrdemServico { get; set; }
    }
}
