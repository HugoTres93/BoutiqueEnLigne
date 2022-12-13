using BoutiqueEnLigne.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BoutiqueEnLigne.Repositories
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Produits> Produits { get; set; }
        public DbSet<Panier> Panier { get; set; }

    }
}