using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFormTest.Database
{
    public class db_table
    {
        public db_table()
        {

        }

        public db_table(string n)
        {
            tableN = n;
            orders = new List<db_orders>();
        }

        public db_table(string n, List<db_orders> o)
        {
            tableN = n;
            orders = o;
        }

        public string tableN;
        public List<db_orders> orders;


    }
}
