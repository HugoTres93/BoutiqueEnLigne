using BoutiqueEnLigne.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public interface IProduitServices
    {
        void Delete(int id);
        List<Produit> GetAll();
        Produit GetById(int id);
        void Insert(Produit produits);
        void Update(Produit produits);
    }
}
