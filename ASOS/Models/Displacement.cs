using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class Displacement
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Fornecedor { get; set; }
        public List<DisplacementOrder> OrdensDeslocamento { get; set; }
        public DateTime DataDeslocamento { get; set; }
        public float Kilometragem { get; set; }
        public decimal CustoKm { get; set; }
        public decimal CustoTotal { get; set; }
    }
}
