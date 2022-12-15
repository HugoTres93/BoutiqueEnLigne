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
            var options = new DbContextOptionsBuilder<MyContext>();
            options.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB; database=Boutique_En_Ligne;integrated security=True;MultipleActiveResultSets=True;");
            db = new MyContext(options.Options);

            eventService = new UtilisateurServices(new UtilisateurRepositories(db));
            List<Utilisateur> listEvents = eventService.GetAll(); //Récuperation des events (BDD)
            EvtsLst = new ObservableCollection<Utilisateur>(listEvents);
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur evt = new Utilisateur { Nom = Txt_Nom.Text, Prenom = Txt_Prenom.Text, Mail = Txt_Mail.Text, Password = Txt_Password.Text};
            eventService.Insert(evt);

            EvtsLst.Add(evt);
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur? evt = lstView1.SelectedItem as Utilisateur;

            if (evt != null)
            {
                evt.Nom = Txt_Nom.Text;
                evt.Prenom = Txt_Prenom.Text;
                evt.Mail = Txt_Mail.Text;
                evt.Password = Txt_Password.Text;
                eventService.Update(evt);

                EvtsLst.RemoveAt(lstView1.SelectedIndex);
                EvtsLst.Add(evt);
            }
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            
            Utilisateur? evt = lstView1.SelectedItem  as Utilisateur;
            if (evt != null)
            {
                eventService.Delete(evt.Id);
                EvtsLst.RemoveAt(lstView1.SelectedIndex);
            }
        }
    }
}
