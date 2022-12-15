using BoutiqueEnLigne.Admin.Pages;
using BoutiqueEnLigne.Core.Model;
using BoutiqueEnLigne.Core.Repositories;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BoutiqueEnLigne.Admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Utilisateur> EvtsLstUtilisateur { get; set; }
        public ObservableCollection<Produit> EvtsLst { get; set; }

        private MyContext db;

        private IUtilisateurServices eventServiceUtilisateur;
        private IProduitsServices eventService;


        public MainWindow()
        {
            // DB
            var options = new DbContextOptionsBuilder<MyContext>();
            options.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB; database=Boutique_En_Ligne;integrated security=True;MultipleActiveResultSets=True;");
            db = new MyContext(options.Options);

            // Utilisateur
            eventServiceUtilisateur = new UtilisateurServices(new UtilisateurRepositories(db));
            List<Utilisateur> listEventsUtilisateur = eventServiceUtilisateur.GetAll(); //Récuperation des events (BDD)
            EvtsLstUtilisateur = new ObservableCollection<Utilisateur>(listEventsUtilisateur);

            // Produit
            eventService = new ProduitsService(new ProduitRepositories(db));
            List<Produit> listEvents = eventService.GetAll(); //Récuperation des events (BDD)
            EvtsLst = new ObservableCollection<Produit>(listEvents);
            InitializeComponent();
        }

        // Afficher Utilisateur
        private void gereUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            GridProduit.Visibility= Visibility.Collapsed;
            GridUtilisateur.Visibility = Visibility.Visible;
        }

        // Afficher Produit
        private void gereProduit_Click(object sender, RoutedEventArgs e)
        {            
            GridUtilisateur.Visibility = Visibility.Collapsed;
            GridProduit.Visibility = Visibility.Visible;
        }


        // Partie Utilisateur
        private void AjouterUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur evt = new Utilisateur { Nom = Txt_UtilisateurNom.Text, Prenom = Txt_Prenom.Text, Mail = Txt_Mail.Text, Password = Txt_Password.Text };
            eventServiceUtilisateur.Insert(evt);

            EvtsLstUtilisateur.Add(evt);
        }

        private void ModifierUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur? evt = lstView2.SelectedItem as Utilisateur;

            if (evt != null)
            {
                evt.Nom = Txt_UtilisateurNom.Text;
                evt.Prenom = Txt_Prenom.Text;
                evt.Mail = Txt_Mail.Text;
                evt.Password = Txt_Password.Text;
                eventServiceUtilisateur.Update(evt);

                EvtsLstUtilisateur.RemoveAt(lstView2.SelectedIndex);
                EvtsLstUtilisateur.Add(evt);
            }
        }

        private void SupprimerUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur? evt = lstView2.SelectedItem as Utilisateur;
            if (evt != null)
            {
                eventServiceUtilisateur.Delete(evt.Id);
                EvtsLstUtilisateur.RemoveAt(lstView2.SelectedIndex);
            }
        }


        // Partie Produit
        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Produit evt = new Produit { Nom = Txt_Nom.Text, Description = Txt_Description.Text, Image = Txt_Image.Text, Prix = Convert.ToInt32(Txt_Prix.Text) };
            eventService.Insert(evt);

            EvtsLst.Add(evt);
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            Produit? evt = lstView1.SelectedItem as Produit;

            if (evt != null)
            {
                evt.Nom = Txt_Nom.Text;
                evt.Description = Txt_Description.Text;
                evt.Image = Txt_Image.Text;
                evt.Prix = Convert.ToInt32(Txt_Prix.Text);
                eventService.Update(evt);

                EvtsLst.RemoveAt(lstView1.SelectedIndex);
                EvtsLst.Add(evt);
            }
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            Produit? evt = lstView1.SelectedItem as Produit;
            if (evt != null)
            {
                eventService.Delete(evt.Id);
                EvtsLst.RemoveAt(lstView1.SelectedIndex);
            }
        }
    }
}
