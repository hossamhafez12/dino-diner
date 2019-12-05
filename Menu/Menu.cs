using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// This is a available Items property with just a getter
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>
                {
                    new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ(),
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water(),
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return availableMenuItems;
            }
        }
        /// <summary>
        /// This is a available entrees property with just a getter
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availableEntree = new List<IMenuItem>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ()
                };
                return availableEntree;
            }
        }
        /// <summary>
        /// This is a available sides property with just a getter
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availableSides = new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return availableSides;
            }
        }
        /// <summary>
        /// This is a available drinks property with just a getter
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availableDrinks = new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return availableDrinks;
            }
        }
        public List<string> possibleIngridents
        {
            get
            {
                List<string> possible = new List<string>();
                {
                    possible.Add("Bun");
                    possible.Add("Peppers");
                    possible.Add("Onions");
                    possible.Add("Chicken Nugget");
                    possible.Add("Peanut Butter");
                    possible.Add("Jelly");
                    possible.Add("Chicken");
                    possible.Add("Pickle");
                    possible.Add("Ketchup");
                    possible.Add("Mustard");
                    possible.Add("Tomato");
                    possible.Add("Mayo");
                    possible.Add("Lettuce");
                    possible.Add("Tortilla");
                    possible.Add("Chicken Breast");
                    possible.Add("Ceasar Dressing");
                    possible.Add("Parmesan Cheese");
                    possible.Add("Steakburger Pattie");
                    possible.Add("Wing Sauce");
                    possible.Add("Potato");
                    possible.Add("Salt");
                    possible.Add("Vegetable oil");
                    possible.Add("Macroni Noodles");
                    possible.Add("Cheese Product");
                    possible.Add("Pork Sausage");
                    possible.Add("Breading");
                }
                return possible;
            }
        }
        /// <summary>
        /// This is a available combos property with just a getter
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availableCombos = new List<IMenuItem>
                {
                    new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap()),
                    new CretaceousCombo(new PrehistoricPBJ()), 
                };
                return availableCombos;
            }
        }
        public Drink Sodasaurus { get; set; } = new Sodasaurus();
        public Side Fryceritops { get; set; } = new Fryceritops();
        /// <summary>
        /// This is a method to overide the items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder st = new StringBuilder();
            foreach (IMenuItem s in AvailableMenuItems)
            {
                st.Append(s.ToString());
                st.Append("\n");
            }
            return st.ToString();
        }
        public List<IMenuItem> Search(List<IMenuItem> items, string searchString)
        {
            List<IMenuItem> res = new List<IMenuItem>();

            foreach (IMenuItem entr in AvailableMenuItems)
            {
                if (entr.ToString().Contains(searchString))
                {
                    res.Add(entr);
                }
            }
            return res;
        }
        public List<IMenuItem> ApplyFilter(List<IMenuItem> searchRes, List<string> menuCatogri)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in searchRes)
            {
                if (item is Entree && menuCatogri.Contains("Entree"))
                {
                    result.Add(item);
                }
                else if (item is CretaceousCombo && menuCatogri.Contains("Combo"))
                {
                    result.Add(item);
                }
                else if (item is Side && menuCatogri.Contains("Side"))
                {
                    result.Add(item);
                }
                else if (item is Drink && menuCatogri.Contains("Drink"))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> movies, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem items in AvailableMenuItems)
            {
                if (items.Price != 0 && minPrice >= items.Price)
                {
                    results.Add(items);
                }
            }
            return results;
        }
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> movies, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem items in AvailableMenuItems)
            {
                if (items.Price != 0 && maxPrice <= items.Price)
                {
                    results.Add(items);
                }
            }
            return results;
        }
    }
}