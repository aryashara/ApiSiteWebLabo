using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSiteWeb.Dal.Entities
{
    public class MessageForumDal
    {
          public int ID { get; set; }
        public string Sujet { get; set; }
        public string Message { get; set; }
        public DateTime DatePublication { get; set; }
        public int UtilisateurID { get; set; }
    }
}