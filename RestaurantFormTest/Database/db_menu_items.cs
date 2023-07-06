using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFormTest.Database
{
    public class db_menu_items
    {
        public db_menu_items()
        {

        }

        public db_menu_items(string n, float p)
        {
            itemName = n;
            itemPrice = p;
        }

        public string itemName;
        public float itemPrice;
    }
}
