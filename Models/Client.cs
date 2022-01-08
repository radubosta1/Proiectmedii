using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceAuto1.Models
{
    public class Client
    {
        public int ID { get; set; }
        
        [Display(Name = " Client Nume")]
        public string Nume { get; set; }
        [Display(Name = " Client Prenume")]
        public string Prenume { get; set; }
        [Display(Name = " Client Mail")]
        public string Mail { get; set; }
        public int Telefon { get; set; }
        [Display(Name = " Client Adresa")]
        public string Adresa { get; set; }
        
        public ICollection<Review> Review { get; set; }

    }
}
