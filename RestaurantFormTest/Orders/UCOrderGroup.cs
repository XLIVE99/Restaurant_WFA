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
    public partial class UCOrderGroup : UserControl
    {
        public UCOrderGroup()
        {
            InitializeComponent();
        }

        public delegate void OnButtonClick(int orderI);
        public OnButtonClick onButtonClick;
        int orderIndex;

        public UCOrderGroup(string gName, int orderId)
        {
            InitializeComponent();

            button1.Text = gName;
            orderIndex = orderId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onButtonClick?.Invoke(orderIndex);
        }
    }
}
