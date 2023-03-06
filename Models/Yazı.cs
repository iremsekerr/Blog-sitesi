using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webproject.Models
{
    
    
        public class Yazı
        {
            [Key]
            public int Yid { get; set; }
            public String YaziAdi { get; set; }
            public String resmi { get; set; }
            public String aciklama { get; set; }

            [ForeignKey("YazıTuru")]
            public int Yazıid { get; set; }
            public YaziTuru YazıTuru { get; set; }

        }
    
}
