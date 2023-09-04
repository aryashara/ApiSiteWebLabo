using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSiteWeb.Bll;
using ApiSiteWeb.Bll.Entities;
using Dal = ApiSiteWeb.Bll.Entities;
using DalTache = ApiSiteWeb.Dal.Entities.Tache;

namespace ApiSiteWeb.Bll.Mappers
{
    public static  class Mappers
    {
        internal static DalTache ToDal(this Tache entity)
        {
            return new DalTache() { Id = entity.Id, Titre = entity.Titre, Finalise = entity.Finalise };
        }
        internal static Tache ToBll(this DalTache entity)
        {
            return new Tache(entity.Id, entity.Titre, entity.Finalise);
        }
        internal static Dal.Entities.AdminDal ToDal(this AdminBll entity)
        {
            return new Dal.Entities.AdminDal()
            {
                ID = entity.ID,
                NAMEAdmin = entity.NAMEAdmin,
                PASSWORD = entity.PASSWORD,
            };
        }
        internal static Dal.Entities.UtilisateurDal ToDal(this UtilisateurBll entity)
        {
            return new Dal.Entities.UtilisateurDal()
            {
                ID = entity.ID,
                NAME = entity.NAME,
                FIRSTNAME = entity.FIRSTNAME,
                Email = entity.Email,
                PASSWORD = entity.PASSWORD,
            };
        }
        internal static Dal.Entities.ContactFormulaireDal ToDal(this ContactFormulaireBll entity)
        {
            return new Dal.Entities.ContactFormulaireDal()
            {
                ID = entity.ID,
                Nom = entity.Nom,
                AdresseEmail = entity.AdresseEmail,
                Objet = entity.Objet,
                Message = entity.Message,
                DateEnvoi = entity.DateEnvoi,
            };
        }
        internal static Dal.Entities.LikeDal ToDal(this LikeBll entity)
        {
            return new Dal.Entities.LikeDal()
            {
                ID = entity.ID,
                UtilisateurID = entity.UtilisateurID,
                ProjetID = entity.ProjetID,
            };
        }
        internal static Dal.Entities.MessageForumDal ToDal(this MessageForumBll entity)
        {
            return new Dal.Entities.MessageForumDal()
            {
                ID = entity.ID,
                Sujet = entity.Sujet,
                Message = entity.Message,
                DatePublication = entity.DatePublication,
                UtilisateurID = entity.UtilisateurID,
            };
        }
        internal static Dal.Entities.ProjetDal ToDal(this ProjetBll entity)
        {
            return new Dal.Entities.ProjetDal()
            {
                ID = entity.ID,
                Title = entity.Title,
                Description = entity.Description,
                CreationDate = entity.CreationDate,
                MediaLink = entity.MediaLink,
            };
        }
    //finDalEntity


         internal static AdminBll ToBll(this Dal.Entities.AdminDal entity)
        {
            return new AdminBll()
            {
                ID = entity.ID,
                NAMEAdmin = entity.NAMEAdmin,
                
            };
        }
        internal static UtilisateurBll ToBll(this Dal.Entities.UtilisateurDal entity)
        {
            return new UtilisateurBll()
            {
                ID = entity.ID,
                NAME = entity.NAME,
                FIRSTNAME = entity.FIRSTNAME,
                Email = entity.Email,
               
            };
        }
        internal static ContactFormulaireBll ToBll(this Dal.Entities.ContactFormulaireDal entity)
        {
            return new ContactFormulaireBll()
            {
                ID = entity.ID,
                Nom = entity.Nom,
                AdresseEmail = entity.AdresseEmail,
                Objet = entity.Objet,
                Message = entity.Message,
                DateEnvoi = entity.DateEnvoi,
            };
        }
        internal static LikeBll ToBll(this Dal.Entities.LikeDal entity)
        {
            return new LikeBll()
            {
                ID = entity.ID,
                UtilisateurID = entity.UtilisateurID,
                ProjetID = entity.ProjetID,
            };
        }
        internal static MessageForumBll ToBll(this Dal.Entities.MessageForumDal entity)
        {
            return new MessageForumBll()
            {
                ID = entity.ID,
                Sujet = entity.Sujet,
                Message = entity.Message,
                DatePublication = entity.DatePublication,
                UtilisateurID = entity.UtilisateurID,
            };
        }
        internal static ProjetBll TBll(this Dal.Entities.ProjetDal entity)
        {
            return new ProjetBll()
            {
                ID = entity.ID,
                Title = entity.Title,
                Description = entity.Description,
                CreationDate = entity.CreationDate,
                MediaLink = entity.MediaLink,
            };
        }
    }
}