using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class BuyOrder
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataChegada { get; set; }
        public string Setor { get; set; }
        public string Solicitante { get; set; }
        public ServiceOrder OrdemServico { get; set; }
        public int OrdemServicoID { get; set; }
        public string Fornecedor { get; set; }
        public string ContatoFornecedor { get; set; }
        public decimal ValorEsperado { get; set; }
        public decimal ValorReal { get; set; }
        public string[] Pecas { get; set; }
        public bool Autorizado { get; set; }
        public string MotivoCompra { get; set; }
    }
}
