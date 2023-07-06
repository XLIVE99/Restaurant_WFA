using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantFormTest.Database;
using RestaurantFormTest.CustomDialogs;

namespace RestaurantFormTest.Orders
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        int tableId = 0;
        int groupId;

        int pageId = 0;

        public OrdersForm(int t, string tableName)
        {
            InitializeComponent();

            label_table_name.Text = tableName;
            tableId = t;
        }

        private void GetBackPage(object senders, EventArgs e)
        {
            pageId = Math.Max(0, pageId - 1);
            LoadPage(pageId);

            button_back.Visible = pageId > 0;
        }

        private void LoadPage(int page)
        {
            ClearMenuLayout();

            switch (page)
            {
                case 0:
                    for (int i = 0; i < database.instance.menus.Count; i++)
                    {
                        UCOrderGroup orderG = new UCOrderGroup(database.instance.menus[i].groupName, i);
                        orderG.Parent = menu_layout;
                        orderG.onButtonClick += GoGroupPage;
                    }
                    break;
                case 1:
                    db_menu selectedMenu = database.instance.menus[groupId];
                    for (int i = 0; i < selectedMenu.items.Length; i++)
                    {
                        UCOrderMultiple orderG = new UCOrderMultiple(selectedMenu.items[i].itemName, i);
                        orderG.Parent = menu_layout;
                        orderG.onButtonClick += AddItem;
                    }
                    break;
                default:
                    break;
            }
            button_back.Visible = page > 0;
            pageId = page;
        }

        private void AddItem(int itemId, int quantity)
        {
            bool inControl = false;

            db_orders[] curOrders = database.instance.tables[tableId].orders.ToArray();
            for(int i = 0; i < curOrders.Length; i++)
            {
                if(curOrders[i].catIndex == groupId && curOrders[i].itemIndex == itemId)
                {
                    database.instance.tables[tableId].orders[i].quantity += quantity;
                    database.instance.SaveTables();
                    inControl = true;
                    break;
                }
            }
            if(!inControl)
            {
                database.instance.tables[tableId].orders.Add(new db_orders(groupId, itemId, quantity));
                database.instance.SaveTables();

                AddItemToControl(itemId, quantity);
            }
            else
            {
                FillItems();
            }
        }

        private void FillItems()
        {
            listView_order.Items.Clear();
            label_price.Text = "0";

            db_orders[] curOrders = database.instance.tables[tableId].orders.ToArray();
            for (int i = 0; i < curOrders.Length; i++)
            {
                AddItemToControl(curOrders[i]);
            }
        }

        private void RemoveOrder(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = listView_order.SelectedIndices;
            if (indices.Count <= 0)
                return;
            int selectedIndex = indices[0];
            db_orders selectedOrder = database.instance.tables[tableId].orders[selectedIndex];
            database.instance.tables[tableId].orders.RemoveAt(selectedIndex);
            database.instance.SaveTables();
            FillItems();
        }

        private void RemoveAllOrder(object sender, EventArgs e)
        {
            database.instance.tables[tableId].orders.Clear();
            database.instance.SaveTables();
            listView_order.Items.Clear();
            label_price.Text = "0";
        }

        private void EditOrder(object sender, EventArgs e)
        {
            var intDialog = new IntDialog("Edit order", "Change quantity", "Quantity", "Change", EditOrder);
            intDialog.ShowDialog();
        }

        private void EditOrder(int q)
        {
            ListView.SelectedIndexCollection indices = listView_order.SelectedIndices;
            if (indices.Count <= 0)
                return;
            int selectedIndex = indices[0];
            database.instance.tables[tableId].orders[selectedIndex].quantity = q;
            database.instance.SaveTables();
            FillItems();
        }

        private void AddItemToControl(db_orders order)
        {
            AddItemToControl(order.catIndex, order.itemIndex, order.quantity);
        }

        private void AddItemToControl(int groupId, int itemId, int q)
        {
            db_menu_items menuItem = database.instance.menus[groupId].items[itemId];
            ListViewItem newItem = new ListViewItem(menuItem.itemName);
            newItem.SubItems.Add(menuItem.itemPrice.ToString());
            newItem.SubItems.Add(q.ToString());

            listView_order.Items.Add(newItem);

            float price = float.Parse(label_price.Text);
            price += menuItem.itemPrice * q;
            label_price.Text = price.ToString();
        }

        private void AddItemToControl(int itemId, int q)
        {
            db_menu_items menuItem = database.instance.menus[groupId].items[itemId];
            ListViewItem newItem = new ListViewItem(menuItem.itemName);
            newItem.SubItems.Add(menuItem.itemPrice.ToString());
            newItem.SubItems.Add(q.ToString());

            listView_order.Items.Add(newItem);

            float price = float.Parse(label_price.Text);
            price += menuItem.itemPrice * q;
            label_price.Text = price.ToString();
        }

        private void GoGroupPage(int selectedGroup)
        {
            ClearMenuLayout();
            groupId = selectedGroup;
            LoadPage(1);
        }

        void ClearMenuLayout()
        {
            menu_layout.Controls.Clear();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadPage(0);

            listView_order.Columns.Add("Item name", 130);
            listView_order.Columns.Add("Price", 70);
            listView_order.Columns.Add("Quantity", 80);

            db_orders[] orders = database.instance.tables[tableId].orders.ToArray();
            for(int i = 0; i < orders.Length; i++)
            {
                AddItemToControl(orders[i]);
            }
        }

        private void textBox_pay_TextChanged(object sender, EventArgs e)
        {
            float price = float.Parse(label_price.Text);
            float paid = 0f;
            if (float.TryParse(textBox_pay.Text, out paid))
            {
                float change = paid - price;
                label_change.Text = change.ToString("0.00");
            }
            else
                label_change.Text = "0";
        }
    }
}
