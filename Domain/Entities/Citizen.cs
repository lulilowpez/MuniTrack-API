using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Domain.Enum;

namespace Domain.Entities
{
    public class Operator
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int NLegajo { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public MailAddress Email { get; set; }
        public operatorType Position { get; set; }

    }
}
