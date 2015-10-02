using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W04a.Models
{
    public class Province
    {
        public int ProvinceId { get; set; }

        [Required]
        [MinLength(2), MaxLength(30)]
        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }
    }
}