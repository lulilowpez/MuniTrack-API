using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Domain.Enum;

namespace Domain.Entities
{
    public class Citizen
    {
        [Key]
        public int DNI { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Adress { get; set; }
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "El email no es válido")]
        public string Email { get; set; }
        public int Deleted { get; set; } = 0;
        public List<Incidence> Incidences { get; set; } = new List<Incidence>();
        
    }

    }
