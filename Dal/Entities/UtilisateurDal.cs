using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSiteWeb.Dal.Entities
{
    public class UtilisateurDal
    {
          public int ID { get; set; }
        public string NAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string Email { get; set; }
        public string PASSWORD { get; set; }
    }
}