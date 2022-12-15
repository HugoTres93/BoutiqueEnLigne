using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Services;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
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
            List<Utilisateur> listEvents = eventService.GetAll(); //Récuperation des events (BDD)
            EvtsLst = new ObservableCollection<Utilisateur>(listEvents);
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
