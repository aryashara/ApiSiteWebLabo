using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Pour Entity Framework Core
using System.DatabaseProjectApiSiteWeb;
using ApiSiteWeb.Models;


namespace ApiSiteWeb.Controllers
{
   
[Route("api/[controller]")]
[ApiController]
public class UtilisateurController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UtilisateurController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Action pour récupérer la liste des utilisateurs
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Utilisateur>>> GetUtilisateurs()
    {
        return await _context.Utilisateurs.ToListAsync();
    }

    // Action pour créer un nouvel utilisateur
    [HttpPost]
    public async Task<ActionResult<Utilisateur>> PostUtilisateur(Utilisateur utilisateur)
    {
        _context.Utilisateurs.Add(utilisateur);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUtilisateurs", new { id = utilisateur.ID }, utilisateur);
    }

    // Autres actions pour mettre à jour, supprimer ou récupérer un utilisateur spécifique
}

    }
