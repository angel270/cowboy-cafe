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
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered categories
        /// </summary>
        public string[] Category { get; set; }

        /// <summary>
        /// The minimum Cal Rating
        /// </summary>  
        public uint? CalMin { get; set; }

        /// <summary>
        /// The maximum Cal Rating
        /// </summary>
        public uint? CalMax { get; set; }

        /// <summary>
        /// The minimum Rotten Tomatoes Rating
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum Rotten Tomatoes Rating
        /// </summary>
        public double? PriceMax { get; set; }


        public void OnGet(uint? CalMin, uint? CalMax, double? PriceMin, double? PriceMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            Category = Request.Query["Category"];

            Items = Menu.CompleteMenu;
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, Category);
            Items = Menu.FilterByCalories(Items, CalMin, CalMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
