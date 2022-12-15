using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Repositories;
using BoutiqueEnLigne.Core.Services;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BoutiqueEnLigne.Admin.Pages
{
    /// <summary>
    /// Logique d'interaction pour Utilisateurs.xaml
    /// </summary>
    public partial class Utilisateurs : Window
    {
        public ObservableCollection<Utilisateur> EvtsLst { get; set; }
        private MyContext db;
        private IUtilisateurServices eventService;

        public Utilisateurs()
        {
            db = new MyContext();
            eventService = new UtilisateurServices(new UtilisateurRepositories(db));
            List<Utilisateur> listEvents = eventService.GetAll(); //Récuperation des events (BDD)
            EvtsLst = new ObservableCollection<Utilisateur>(listEvents);
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur evt = new Utilisateur { Nom = Txt_Nom, Prenom = Txt_Prenom, Mail = Txt_Mail, Password = Txt_Password};
            eventService.Insert(evt);
            EvtsLst.Add(evt);
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur evt = new Utilisateur { Nom = Txt_Nom, Prenom = Txt_Prenom, Mail = Txt_Mail, Password = Txt_Password };
            eventService.Update(evt);
            EvtsLst.Add(evt);
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur evt = new Utilisateur { Nom = Txt_Nom };
            eventService.Delete(evt);
            EvtsLst.Add(evt);
        }
    }
}
