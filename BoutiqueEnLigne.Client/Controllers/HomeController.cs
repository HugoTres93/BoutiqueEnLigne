using BoutiqueEnLigne.Client.Models;
using BoutiqueEnLigne.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoutiqueEnLigne.Client.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IExempleService _exempleService;

        #region exemple utilisation donnée venant de la partie core
        private readonly IProduitPanierServices _servicePanier;

        private readonly IProduitsServices _serviceProduits;

        private readonly IUtilisateurServices _serviceUtilisateur;

        public HomeController(IProduitPanierServices servicePanier, IProduitsServices serviceProduits, IUtilisateurServices serviceUtilisateur)
        {
            _servicePanier = servicePanier;
            _serviceProduits = serviceProduits;
            _serviceUtilisateur = serviceUtilisateur;
        }
        #endregion

        public /* async Task */ IActionResult Index()
        {
            //await _exempleService.Ajouter();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index([Bind] Ad_login ad)
    {
        int res = dbop.LoginCheck(ad);
        if (res == 1)
        {
            TempData["msg"] = "You are welcome to Admin Section";
        }
        else
        {
            TempData["msg"] = "Admin id or Password is wrong.!";
        }
        return View();
    }
}