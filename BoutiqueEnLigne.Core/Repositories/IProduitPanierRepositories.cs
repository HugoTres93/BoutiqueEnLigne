using BoutiqueEnLigne.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Repositories
{
    internal interface IProduitPanierRepositories
    {
        void Delete(int id);
        List<Produits> GetAll();
        Produits GetById(int id);
        void Insert(ProduitPanierRepositories produitPanier);
        void Update(ProduitPanierRepositories produitPanier);
    }
}
