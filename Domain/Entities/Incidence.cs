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
    public class Incidence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;       
        public IncidenceType IncidenceType { get; set; } 
        public string Description { get; set; }
        public IncidenceState State { get; set; } = IncidenceState.Started;
        public Department Department { get; set; }

    }
}
