using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W04a.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Required]
        public int ProvinceId { get; set; }
        
        [Required]
        [MinLength(2), MaxLength(30)]
        public string CityName { get; set; }
        
        [Required]
        public int Population { get; set; }
        public Province Province { get; set; }
    }
}