using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Enum;

namespace Domain.Entities
{
    public class Operator
    {
        [Key]
        [Required]
        public int NLegajo { get; set; }
        public int DNI { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
     
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Phone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "El email no es válido")]
        public string Email { get; set; }
        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Position { get; set; }
        public int Deleted { get; set; } = 0;
        public List<Citizen> Citizens { get; set; } = new List<Citizen>();
        public List<Incidence> Incidences { get; set; } = new List<Incidence>();

    }
}
