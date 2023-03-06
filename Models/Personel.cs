using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webproject.Models
{
     public class Personel 
    {
        [Key]
        public int Pıd { get; set; }
        public String adı { get; set; }
        public String soyadı { get; set; }
        public String mail { get; set; }
        public String Pass { get; set; }
        public String tarih { get; set; }


    }
}
