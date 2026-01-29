using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class ItemsModel : PageModel
    {
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Job { get; set; }
            public string FavoriteColor { get; set; }
        }

        private static readonly List<Item> _allItems = new List<Item>
        {
            new Item { Id = 1, Name = "Cy Ganderton", Job = "Quality Control Specialist", FavoriteColor = "Blue" },
            new Item { Id = 2, Name = "Hart Hagerty", Job = "Desktop Support Technician", FavoriteColor = "Purple" },
            new Item { Id = 3, Name = "Brice Swyre", Job = "Tax Accountant", FavoriteColor = "Red" },
            new Item { Id = 4, Name = "Marabel Shipley", Job = "Quality Control Specialist", FavoriteColor = "Green" },
            new Item { Id = 5, Name = "Claudius Grendon", Job = "Desktop Support Technician", FavoriteColor = "Yellow" },
            new Item { Id = 6, Name = "Kristel Caroll", Job = "Tax Accountant", FavoriteColor = "Orange" },
            new Item { Id = 7, Name = "Dionne Dymock", Job = "Quality Control Specialist", FavoriteColor = "Pink" },
            new Item { Id = 8, Name = "Etheline Eades", Job = "Desktop Support Technician", FavoriteColor = "Gray" },
            new Item { Id = 9, Name = "Faydra Fretwell", Job = "Tax Accountant", FavoriteColor = "Cyan" },
            new Item { Id = 10, Name = "Gerrard Gaskell", Job = "Quality Control Specialist", FavoriteColor = "Brown" },
            new Item { Id = 11, Name = "Hillary Hagger", Job = "Desktop Support Technician", FavoriteColor = "Magenta" },
            new Item { Id = 12, Name = "Ione Iley", Job = "Tax Accountant", FavoriteColor = "Teal" }
        };

        public List<Item> Items { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterJob { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;

        public int TotalPages { get; set; }
        public const int PageSize = 5;

        public List<string> Jobs { get; set; }

        public void OnGet()
        {
            Jobs = _allItems.Select(i => i.Job).Distinct().ToList();

            var query = _allItems.AsQueryable();

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                query = query.Where(i => i.Name.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(FilterJob))
            {
                query = query.Where(i => i.Job == FilterJob);
            }

            int count = query.Count();
            TotalPages = (int)System.Math.Ceiling(count / (double)PageSize);
            
            if (PageIndex < 1) PageIndex = 1;
            if (PageIndex > TotalPages && TotalPages > 0) PageIndex = TotalPages;

            Items = query.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }
    }
}
