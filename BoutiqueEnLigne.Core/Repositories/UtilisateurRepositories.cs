using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    public class UtilisateurRepositories : IUtilisateurRepositories
    {
        private MyContext _context;

        public UtilisateurRepositories(MyContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            Utilisateur u = _context.Utilisateurs.Find(id);
            if (u != null)
            {
                _context.Utilisateurs.Remove(u);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Utilisateur introuvable");
            }
        }

        public List<Utilisateur> GetAll()
        {
            return _context.Utilisateurs.AsNoTracking().ToList();
        }

        public Utilisateur GetById(int id)
        {
            Utilisateur u = _context.Utilisateurs.Find(id);
            if (u != null)
            {
                return u;
            }
            else
            {
                throw new Exception("Utilisateur introuvable");
            }
        }

        public void Insert(Utilisateur utilisateur)
        {
            _context.Add(utilisateur);
            _context.SaveChanges();
        }

        public void Update(Utilisateur utilisateur)
        {
            Utilisateur UtilisateurDb = _context.Utilisateurs.Find(utilisateur.Id);
            if (UtilisateurDb != null)
            {
                UtilisateurDb.Nom = utilisateur.Nom;
                UtilisateurDb.Prenom = utilisateur.Prenom;
                UtilisateurDb.Mail = utilisateur.Mail;
                UtilisateurDb.Password = utilisateur.Password;
                UtilisateurDb.Panier = utilisateur.Panier;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Utilisateur introuvable");
            }
        }
    }
}
