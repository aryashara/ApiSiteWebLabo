using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSiteWeb.ApiSiteWeb.Models
{
    public class Like
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public int ProjetID { get; set; }
    }
}