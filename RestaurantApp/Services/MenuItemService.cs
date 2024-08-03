using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class MenuItemService
    {
        private readonly static IEnumerable<MenuItems> _items = new 
            List<MenuItems>()
            {
                new MenuItems
                {
                    Name = "Butter Chicken",
                    Image = "butterchicken.png",
                    Price = 10
                },
                new MenuItems
                {
                    Name = "Assorted Peppersoup",
                    Image = "assortedpeppersoup.jpeg",
                    Price = 10
                },
                new MenuItems
                {
                    Name = "Catfish Peppersoup",
                    Image = "catfishpeppersoup.jpeg",
                    Price = 12
                },
                new MenuItems
                {
                    Name = "Jellofrice and Plantain",
                    Image = "jellofriceandplantain.jpeg",
                    Price = 10
                },
                new MenuItems
                {
                    Name = "Fried Rice",
                    Image = "friedrice.jpeg",
                    Price = 8
                }
            };
        
        public IEnumerable<MenuItems> GetAllMenuItems() => _items;

        public IEnumerable<MenuItems> GetOnSaleMenuItems(int count = 4) => _items.OrderBy(p => Guid.NewGuid()).Take(count);

        public IEnumerable<MenuItems> GetMenuItems(string searchTerm) => string.IsNullOrWhiteSpace(searchTerm)? _items
            : _items.Where(p => p.Name.Contains(searchTerm,StringComparison.OrdinalIgnoreCase));
    }
}
