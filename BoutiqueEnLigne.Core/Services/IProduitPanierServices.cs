using BoutiqueEnLigne.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public interface IProduitPanierServices
    {
        void Delete(int idProd, int idUser);
        List<ProduitPanier> GetAll();
        ProduitPanier GetById(int idProd, int idUser);
        void Insert(ProduitPanier produitPanier);
        void Update(ProduitPanier produitPanier);
    }
}
