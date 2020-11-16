using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<IOrderItem> Itmes { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }
        public void OnGet()
        {
            string terms = Request.Query["SearchTerms"];
            SearchTerms = terms;
            Items = BleakwindBuffet.Data.Menu.Menu.Search(SearchTerms);
        }
    }
}
