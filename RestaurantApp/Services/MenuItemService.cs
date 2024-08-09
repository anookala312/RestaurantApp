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
                    Price = 10,
                    Description = "Savor the perfect pairing of our rich, velvety Butter Chicken and our freshly baked Naan. Tender chicken marinated in aromatic spices is simmered in a creamy tomato sauce, while our garlic-infused Naan offers the ideal vessel to soak up every delicious bite. A classic Indian combination that will leave you craving more."
                },
                new MenuItems
                {
                    Name = "Assorted Peppersoup",
                    Image = "assortedpeppersoup.jpeg",
                    Price = 10,
                    Description ="The assorted pepper soup is a spicy and aromatic soup made with a variety of meats, often including goat, beef, or fish. It is seasoned with a mix of traditional Nigerian spices and herbs, such as calabash nutmeg, scent leaves, and uziza seeds. The soup is known for its rich, flavorful broth, which is both spicy and savory. It is commonly enjoyed as a hearty meal, particularly in cooler weather or as a remedy for colds and flu, and is often served with a side of fufu, yam, or rice."
                },
                new MenuItems
                {
                    Name = "Catfish Peppersoup",
                    Image = "catfishpeppersoup.jpeg",
                    Price = 12,
                    Description = "Catfish pepper soup is a flavorful and spicy Nigerian dish made with tender pieces of catfish simmered in a spicy broth. The soup is seasoned with a blend of traditional spices and herbs, such as calabash nutmeg, uziza seeds, and scent leaves, giving it a distinctive and aromatic flavor. The broth is often enriched with onions, pepper, and other seasonings to enhance its depth. Catfish pepper soup is typically enjoyed as a comforting meal, especially during cooler weather or as a remedy for colds. It is commonly served with a side of boiled plantains, yams, or fufu."
                },
                new MenuItems
                {
                    Name = "Jellofrice and Plantain",
                    Image = "jellofriceandplantain.jpeg",
                    Price = 10,
                    Description ="Jellof rice with plantain is a vibrant and flavorful West African dish. Jellof rice is a one-pot rice dish cooked in a rich, tomato-based sauce, seasoned with onions, peppers, and a blend of spices like thyme and bay leaves. The rice absorbs the savory and slightly spicy sauce, resulting in a colorful and aromatic dish."
                },
                new MenuItems
                {
                    Name = "Fried Rice",
                    Image = "friedrice.jpeg",
                    Price = 8,
                    Description = "Fried rice is a popular and versatile dish made from pre-cooked rice that is stir-fried with a variety of ingredients. Typically, it includes vegetables such as carrots, peas, and bell peppers, along with proteins like chicken, shrimp, or beef. The rice is seasoned with soy sauce, garlic, ginger, and sometimes a touch of sesame oil for added flavor. Often garnished with green onions or cilantro, fried rice is known for its savory, slightly smoky taste and satisfying texture, making it a beloved dish in many cuisines around the world."
                },
                new MenuItems
                {
                    Name ="Okro soup with fufu",
                    Image = "okrosoupwithfufu.jpeg",
                    Price = 8,
                    Description = "Okro soup with fufu is a beloved West African dish known for its rich flavors and satisfying texture. Okro soup is made from okra, which is cooked into a thick, hearty stew with a variety of meats, fish, or seafood. The okra imparts a unique slimy texture that helps to thicken the soup, while ingredients like onions, peppers, and spices enhance its flavor."
                },
                new MenuItems
                {
                    Name ="Rice with peas",
                    Image = "ricewithpeas.jpeg",
                    Price = 8,
                    Description = "Rice with peas is a classic dish often enjoyed in Caribbean and Latin American cuisine. Despite its name, the dish typically features rice cooked with kidney beans or pigeon peas, rather than actual green peas. The rice and peas are simmered together with aromatic ingredients like coconut milk, garlic, onions, thyme, and scallions, which infuse the dish with a rich, creamy, and slightly nutty flavor. The result is a fragrant and savory side dish that pairs wonderfully with a variety of main courses, such as jerk chicken or grilled fish."
                },
                new MenuItems
                {
                    Name ="Egusi soup with pounded yam",
                    Image = "egusisoupwithpoundedyam.jpeg",
                    Price = 8,
                    Description = "Egusi soup with pounded yam is a cherished African dish that combines two distinct and flavorful components. Egusi soup is a rich and hearty stew made from ground melon seeds, which are cooked with a variety of meats (like goat, beef, or fish), vegetables, and traditional spices. The soup is known for its thick, savory consistency and complex flavor profile, often enhanced with ingredients like spinach or bitter leaf.\r\n"
                },
                new MenuItems
                {
                    Name ="Chicken Biryani",
                    Image = "chicken_biryani.jpeg",
                    Price = 10,
                    Description = "A fragrant and flavorful layered rice dish with tender chicken pieces, aromatic spices, and saffron. The chicken is marinated in a yogurt and spice mixture before being cooked with the rice, which is infused with the flavors of the spices. The dish is often garnished with fresh cilantro and served with a side of raita."
                },
                new MenuItems
                {
                    Name ="Chicken Tikka Masala",
                    Image = "chicken_tikka_masala.jpeg",
                    Price = 8,
                    Description = "A creamy and flavorful tomato-based curry with tender chicken pieces. The chicken is marinated in a yogurt and spice mixture before being cooked in a tandoor oven. The curry is then simmered in a tomato-based sauce with cream and spices. The dish is often garnished with fresh cilantro and served with fluffy naan bread."
                },
                new MenuItems
                {
                    Name ="Dal Makhani",
                    Image = "dal_makhni.jpeg",
                    Price = 8,
                    Description = "A rich and flavorful black lentil stew. The lentils are cooked with a variety of spices, including cumin, coriander, and garam masala. The dish is often garnished with fresh cilantro and served with fluffy basmati rice."
                },
                new MenuItems
                {
                    Name ="Chicken Vindaloo",
                    Image = "chicken_vindaloo.jpeg",
                    Price = 8,
                    Description = "A fiery and spicy curry with tender chicken pieces, potatoes, and a vibrant red sauce. The chicken is marinated in a yogurt and spice mixture before being cooked in a tandoor oven. The curry is then simmered in a tomato-based sauce with chilies and spices. The dish is often garnished with fresh cilantro and served with a side of cooling raita."
                },
                new MenuItems
                {
                    Name ="Chai",
                    Image = "chai.jpeg",
                    Price = 2,
                    Description = "A warm and comforting spiced tea made with milk, sugar, and black tea leaves. The tea is often flavored with cardamom, ginger, and cinnamon."
                },
                new MenuItems
                {
                    Name ="Roti",
                    Image = "roti.jpeg",
                    Price = 1,
                    Description = "A warm and fluffy flatbread made from whole wheat flour. Roti is a staple food in India and is often served with curries and other dishes. It is perfect for scooping up flavorful sauces and soaking up every last drop of deliciousness."
                },
                new MenuItems
                {
                    Name ="Mutton Curry",
                    Image = "mutton_curry.jpeg",
                    Price = 8,
                    Description = "A rich and flavorful curry made with tender mutton pieces, aromatic spices, and a creamy tomato-based sauce. The mutton is slow-cooked until it is melt-in-your-mouth tender, and the spices infuse the curry with a complex and satisfying flavor. Mutton curry is often served with fluffy basmati rice or naan bread."
                },
                new MenuItems
                {
                    Name ="Naan",
                    Image = "naan.jpeg",
                    Price = 1,
                    Description = "A soft and chewy flatbread made from all-purpose flour. Naan is often cooked in a tandoor oven, giving it a slightly smoky flavor. It is perfect for scooping up flavorful sauces and soaking up every last drop of deliciousness. Naan can also be stuffed with various fillings, such as garlic, cheese, or potatoes."
                },
                new MenuItems
                {
                    Name ="Mutton Biryani",
                    Image = "mutton_biryani.jpeg",
                    Price = 10,
                    Description = "A fragrant and flavorful layered rice dish with tender mutton pieces, aromatic spices, and saffron. The mutton is marinated in a yogurt and spice mixture before being cooked with the rice, which is infused with the flavors of the spices. The dish is often garnished with fresh cilantro and served with a side of raita."
                }

            };
        
        public IEnumerable<MenuItems> GetAllMenuItems() => _items;

        public IEnumerable<MenuItems> GetPopularMenuItems(int count = 4) => _items.OrderBy(p => Guid.NewGuid()).Take(count);

        public IEnumerable<MenuItems> SearchMenuItems(string searchTerm) => string.IsNullOrWhiteSpace(searchTerm)? _items
            : _items.Where(p => p.Name.Contains(searchTerm,StringComparison.OrdinalIgnoreCase));
    }
}
