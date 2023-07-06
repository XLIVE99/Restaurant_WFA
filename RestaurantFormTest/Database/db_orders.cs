using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFormTest.Database
{
    //[System.Serializable]
    public class db_orders
    {
        public db_orders()
        {
            catIndex = 0;
            itemIndex = 0;
            quantity = 0;
        }

        public db_orders(int cat, int item, int q)
        {
            catIndex = cat;
            itemIndex = item;
            quantity = q;
        }

        public int catIndex;
        public int itemIndex;
        public int quantity;
    }
}
