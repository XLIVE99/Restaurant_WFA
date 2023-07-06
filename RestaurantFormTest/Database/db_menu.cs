using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantFormTest.Menu;

namespace RestaurantFormTest.Database
{
    public class db_menu
    {
        public db_menu()
        {

        }

        public db_menu(string n)
        {
            groupName = n;
        }

        public db_menu(string n, List<Consumable> cs)
        {
            groupName = n;
            items = new db_menu_items[cs.Count];
            for(int i = 0; i < cs.Count; i++)
            {
                items[i] = new db_menu_items(cs[i].cName, cs[i].cPrice);
            }
        }

        public string groupName;
        public db_menu_items[] items;

        public void UpdateConsumables(List<Consumable> cs)
        {
            items = new db_menu_items[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                items[i] = new db_menu_items(cs[i].cName, cs[i].cPrice);
                Console.WriteLine("Items added: " + cs[i].cName);
            }
        }
    }
}
