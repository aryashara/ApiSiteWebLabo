using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSiteWeb.Dal.Entities
{
    public class ContactFormulaireBll
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string AdresseEmail { get; set; }
        public string Objet { get; set; }
        public string Message {get; set; }
        public DateTime DateEnvoi { get; set; }
    }
