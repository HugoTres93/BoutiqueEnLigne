using BoutiqueEnLigne.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Core.Services
{
    public interface IProduitsServices
    {
        void Delete(int id);
        List<Produits> GetAll();
        Produits GetById(int id);
        void Insert(Produits produits);
        void Update(Produits produits);
    }
}
