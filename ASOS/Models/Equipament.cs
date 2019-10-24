using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class Equipament
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Fabricante { get; set; }
        public List<ServiceOrder> OrdensServico { get; set; }
    }
}
