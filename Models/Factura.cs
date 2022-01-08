using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceAuto1.Models
{
    public class Factura
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        [Display(Name = "Factura Descriere")]
        public string Descriere { get; set; }
        
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Valoare { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}
