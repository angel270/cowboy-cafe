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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles texas triple button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTriple_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new TexasTripleBurger();
            var screen = new TexasTripleCustomization();
            screen.DataContext = item;

            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles dakota double button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDouble_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new DakotaDoubleBurger();
            var screen = new DakotaDoubleCustomization();
            screen.DataContext = item;

            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles trail burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new TrailBurger();
            var screen = new TrailBurgerCustomization();
            screen.DataContext = item;

            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles pecos pulled pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new PecosPulledPork();
            var screen = new PecosPulledPorkCustomization();
            screen.DataContext = item;

            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles rustlers ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new RustlersRibs();
            var screen = new RustlersRibsCustomization();
            screen.DataContext = item;

            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles cowpoke chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            
            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles angry chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new AngryChicken();
            var screen = new AngryChickenCustomization();
            screen.DataContext = item;

            if (DataContext is Order data)
                data.Add(item);
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Handles chili cheese fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Handles pan de campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new PanDeCampo());
        }
        /// <summary>
        /// Handles corn dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new CornDodgers());
        }
        /// <summary>
        /// Handles baked beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new BakedBeans());
        }
        /// <summary>
        /// Handles jerked soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new JerkedSoda());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
               data.Add(new TexasTea());
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new CowboyCoffee());
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
                data.Add(new Water());
        }
    }
}
