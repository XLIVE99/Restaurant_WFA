using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantFormTest.Orders
{
    public partial class UCOrderMultiple : UserControl
    {
        public UCOrderMultiple()
        {
            InitializeComponent();
        }

        public delegate void OnButtonClick(int orderI, int quantity);
        public OnButtonClick onButtonClick;
        int itemId;

        public UCOrderMultiple(string itemN, int itemI)
        {
            InitializeComponent();

            label_item.Text = itemN;
            itemId = itemI;
        }

        private void done_Click(object sender, EventArgs e)
        {
            onButtonClick?.Invoke(itemId, (int)item_quantity.Value);
            item_quantity.Value = 1;
        }
    }
}
