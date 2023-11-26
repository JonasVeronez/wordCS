using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVihm.Models
{
    public class ModifierWordDocModel
    {

        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public DateTime DataAtendimento { get => DateTime.Now;  }

         
    }
}
