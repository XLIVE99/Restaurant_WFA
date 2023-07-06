using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFormTest.Menu
{
    public class Consumable
    {
        public Consumable()
        {

        }

        public Consumable(string n, float p)
        {
            cName = n;
            cPrice = p;
        }

        public string cName;
        public float cPrice;
    }
}
