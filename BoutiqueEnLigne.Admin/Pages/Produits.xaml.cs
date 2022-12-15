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
using System.Windows.Shapes;

namespace BoutiqueEnLigne.Admin.Pages
{
    /// <summary>
    /// Logique d'interaction pour Produits.xaml
    /// </summary>
    public partial class Produits : Window
    {
        public ObservableCollection<Produit> EvtsLst { get; set; }
        private MyContext db;
        private IProduitsServices eventService;

        public Produits()
        {
            var options = new DbContextOptionsBuilder<MyContext>();
            options.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB; database=Boutique_En_Ligne;integrated security=True;MultipleActiveResultSets=True;");
            db = new MyContext(options.Options);

            eventService = new ProduitsService(new ProduitRepositories(db));
            List<Produit> listEvents = eventService.GetAll(); //Récuperation des events (BDD)
            EvtsLst = new ObservableCollection<Produit>(listEvents);
            InitializeComponent();
        }

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
