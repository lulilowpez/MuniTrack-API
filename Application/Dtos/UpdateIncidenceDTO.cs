using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Enum;

namespace Application.Dtos
{
    public class UpdateOperatorDTO
    {
        public string Description { get; set; }
        public IncidenceState State { get; set; } = IncidenceState.Started;
        

    }
}
