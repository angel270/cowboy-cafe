using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void AddTexasTriple_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new TexasTripleBurger());
        }

        private void AddDakotaDouble_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new TrailBurger());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new PecosPulledPork());
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new RustlersRibs());
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new CowpokeChili());
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new AngryChicken());
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new ChiliCheeseFries());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new PanDeCampo());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new CornDodgers());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new BakedBeans());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new JerkedSoda());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new TexasTea());
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new CowboyCoffee());
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            ItemsOrdered.Items.Add(new Water());
        }
    }
}
