using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets the possible categories
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }

        /// <summary>
        /// Gets all the entrees on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees 
        {
            get
            {
                yield return new AngryChicken();
                yield return new CowpokeChili();
                yield return new DakotaDoubleBurger();
                yield return new PecosPulledPork();
                yield return new RustlersRibs();
                yield return new TexasTripleBurger();
                yield return new TrailBurger();
            } 
        }

        /// <summary>
        /// Gets all the sides on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Sides 
        { 
            get 
            {
                yield return new BakedBeans();
                yield return new ChiliCheeseFries();
                yield return new CornDodgers();
                yield return new PanDeCampo();
            } 
        }

        /// <summary>
        /// Gets all the drinks on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks 
        {
            get 
            {
                yield return new CowboyCoffee();
                yield return new JerkedSoda();
                yield return new TexasTea();
                yield return new Water();
            }
        }

        /// <summary>
        /// Gets all the items on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> CompleteMenu
        {
            get
            {
                yield return new AngryChicken();
                yield return new CowpokeChili();
                yield return new DakotaDoubleBurger();
                yield return new PecosPulledPork();
                yield return new RustlersRibs();
                yield return new TexasTripleBurger();
                yield return new TrailBurger();

                yield return new BakedBeans();
                yield return new ChiliCheeseFries();
                yield return new CornDodgers();
                yield return new PanDeCampo();

                yield return new CowboyCoffee();
                yield return new JerkedSoda();
                yield return new TexasTea();
                yield return new Water();
            }
        }

        /// <summary>
        /// Searches the database for matching items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)


        {
            List<IOrderItem> results = new List<IOrderItem>();

            // If there isn't any search terms, return all items
            if (terms == null) return CompleteMenu;

            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in CompleteMenu)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="categories">The categories to include</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return items;

            // Filter the supplied collection of items
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem i in items)
            {
                if (i.Category != null && categories.Contains(i.Category))
                {
                    results.Add(i);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of items 
        /// to those with calories falling within 
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in items)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;

        }
        /// Filters the provided collection of items 
        /// to those with Rotten Tomatoes ratings falling within 
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        /*public static IEnumerable<Movie> FilterByRottenTomatoesRating(IEnumerable<Movie> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<Movie>();

            // only a maximum specified
            if (min == null)
            {
                foreach (Movie movie in items)
                {
                    if (movie.RottenTomatoesRating <= max) results.Add(movie);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (Movie movie in items)
                {
                    if (movie.RottenTomatoesRating >= min) results.Add(movie);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (Movie movie in items)
            {
                if (movie.RottenTomatoesRating >= min && movie.RottenTomatoesRating <= max)
                {
                    results.Add(movie);
                }
            }
            return results;

        }*/
    }
}
