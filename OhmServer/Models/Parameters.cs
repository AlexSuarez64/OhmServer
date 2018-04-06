using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OhmServer.Models
{
    public class Parameters
    {
        [Required]
        public string ColorA { get; set; }
        [Required]
        public string ColorB { get; set; }
        [Required]
        public string Multiplier { get; set; }
        public string Percent { get; set; }
    }
}
