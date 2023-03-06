using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webproject.Models
{
    public class YaziTuru
    {
        [Key]
        public int Yazıid { get; set; }
        public String adi { get; set; }

    }
}
