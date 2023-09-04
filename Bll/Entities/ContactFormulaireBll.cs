using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiSiteWeb.Bll.Entities
{
    public class ContactFormulaireBll
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string AdresseEmail { get; set; }
        public string Objet { get; set; }
        public string Message { get; set; }
        public DateTime DateEnvoi { get; set; }
    }
}
