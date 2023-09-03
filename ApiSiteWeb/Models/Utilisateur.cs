using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSiteWeb.DatabaseProjectApiSiteWeb;

namespace ApiSiteWeb.ApiSiteWeb.Models
{
    public class Utilisateur
    {
        public int ID {get; set; }
        public string NAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
    }
}