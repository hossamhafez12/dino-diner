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
        public HashSet<string> possibleIngredients
        {
            get
            {
                HashSet<string> pos = new HashSet<string>();
                {
                    foreach (IMenuItem item in AvailableMenuItems)
                    {
                        foreach (string s in item.Ingredients)
                        {
                            pos.Add(s);
                        }
                    }
                }
                return pos;
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
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem entr in AvailableMenuItems)
            {
                if (entr.ToString().Contains(searchString))
                {
                    result.Add(entr);
                }
            }
            return result;
        }
        public List<IMenuItem> ApplyFilter(List<IMenuItem> searchRes, List<string> menuCatogory)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in searchRes)
            {
                if (item is Entree && menuCatogory.Contains("Entree"))
                {
                    result.Add(item);
                }
                else if (item is CretaceousCombo && menuCatogory.Contains("Combo"))
                {
                    result.Add(item);
                }
                else if (item is Side && menuCatogory.Contains("Side"))
                {
                    result.Add(item);
                }
                else if (item is Drink && menuCatogory.Contains("Drink"))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> theItems, float minPrice, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem items in theItems)
            {
                if (items.Price != 0 && minPrice <= items.Price && maxPrice >= items.Price)
                {
                    results.Add(items);
                }
            }
            return results;
        }
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> item1, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem items in item1)
            {
                bool f = true;
                foreach (string s in ingredients)
                {
                    if (items.Ingredients.Contains(s))
                    {
                        f = false;
                        break;
                    }

                }
                if (f) results.Add(items);
            }
            return results;
        }
    }
}