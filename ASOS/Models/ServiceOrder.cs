using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class ServiceOrder
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public DateTime UpdateAt { get; set; }
        public Equipament Equipamento { get; set; }
        public int EquipamentoID { get; set; }
        public List<BuyOrder> OrdensCompra { get; set; }
        public List<DisplacementOrder> OrdensDeslocamento { get; set; }
        public string Status { get; set; }
        public string Motivo { get; set; }
        public string Acoes { get; set; }
        public string Observacoes { get; set; }
        public string Tipo { get; set; }
        public string[] Fechamentos { get; set; }
    }
}
