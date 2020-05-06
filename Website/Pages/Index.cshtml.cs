using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Category { get; set; }

        /// <summary>
        /// The minimum Cal Rating
        /// </summary>  
        [BindProperty(SupportsGet = true)]
        public uint? CalMin { get; set; }

        /// <summary>
        /// The maximum Cal Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CalMax { get; set; }

        /// <summary>
        /// The minimum Rotten Tomatoes Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum Rotten Tomatoes Rating
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }


        public void OnGet()
        {
            Items = Menu.CompleteMenu;

            if (SearchTerms != null)
                Items = Menu.CompleteMenu.Where(movie => movie.ToString() != null &&
                movie.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));

            if (Category != null && Category.Length != 0)
                Items = Items.Where(movie => movie.Category != null &&
                Category.Contains(movie.Category));

            if (CalMin != null || CalMax != null)
            {
                if (CalMin == null)
                    Items = Items.Where(movie => movie.Calories <= CalMax);
                else if (CalMax == null)
                    Items = Items.Where(movie => movie.Calories >= CalMin);
                else
                    Items = Items.Where(movie => movie.Calories >= CalMin && movie.Calories <= CalMax);
            }

            if (PriceMin != null || PriceMax != null)
            {
                if (PriceMin == null)
                    Items = Items.Where(movie => movie.Price <= PriceMax);
                else if (PriceMax == null)
                    Items = Items.Where(movie => movie.Price >= PriceMin);
                else
                    Items = Items.Where(movie => movie.Price >= PriceMin && movie.Price <= PriceMax);
            }
        }
    }
}
