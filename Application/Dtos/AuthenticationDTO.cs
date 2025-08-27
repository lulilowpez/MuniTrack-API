using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class AuthenticationDTO
    {
        [Required]
        public int NLegajo { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
