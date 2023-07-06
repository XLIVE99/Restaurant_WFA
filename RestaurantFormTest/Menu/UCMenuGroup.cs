using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantFormTest.CustomDialogs;
using RestaurantFormTest.Database;

namespace RestaurantFormTest.Menu
{
    public partial class UCMenuGroup : UserControl
    {
        public UCMenuGroup()
        {
            InitializeComponent();
        }

        public string groupName;
        public List<Consumable> consumables = new List<Consumable>();

        int dataIndex;
        bool isFilled = false;

        public UCMenuGroup(string g, int dI)
        {
            InitializeComponent();

            groupName = g;
            menu_group.Text = g;
            dataIndex = dI;
        }

        public UCMenuGroup(string g, int dI, db_menu_items[] items)
        {
            InitializeComponent();

            groupName = g;
            menu_group.Text = g;
            dataIndex = dI;

            if(items != null)
            {
                for(int i = 0; i < items.Length; i++)
                {
                    consumables.Add(new Consumable(items[i].itemName, items[i].itemPrice));
                }
            }
            FillConsumables(false);
        }

        public void ChangeIndex(int data)
        {
            dataIndex = data;
        }

        private void DeleteGroup(object sender, EventArgs e)
        {
            MenuForm mForm = Parent.FindForm() as MenuForm;

            database.instance.menus.RemoveAt(dataIndex);
            database.instance.SaveMenus();
            Parent.Controls.RemoveAt(dataIndex);

            mForm.GroupDeleted();
        }

        private void ChangeGroupName(object sender, EventArgs e)
        {
            var stringDialog = new StringDialog("Change group name", "Group name", "name", "Change", ChangeGroupName);
            stringDialog.ShowDialog();
        }

        private void ChangeGroupName(string s)
        {
            menu_group.Text = s;
            groupName = s;

            database.instance.menus[dataIndex].groupName = s;
            database.instance.SaveMenus();
        }

        private void EditSelectedConsumable(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = menu_list.SelectedItems;
            if (items.Count <= 0)
                return;

            int dataIndex = consumables.FindIndex((c) => c.cName == items[0].Text);

            var floatAndStringDialog = new IntOrFloatAndStringDialog("Edit consumable", "Name", "Price", "Change",
                consumables[dataIndex].cName, consumables[dataIndex].cPrice, EditSelectedConsumable);
            floatAndStringDialog.ShowDialog();
        }

        private void EditSelectedConsumable(string cName, float cPrice)
        {
            ListView.SelectedListViewItemCollection items = menu_list.SelectedItems;
            int dataIndex = consumables.FindIndex((c) => c.cName == items[0].Text);

            consumables[dataIndex].cName = cName;
            consumables[dataIndex].cPrice = cPrice;
            FillConsumables();
            SearchConsumable();
        }

        private void DeleteConsumable(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = menu_list.SelectedIndices;
            if (indices.Count <= 0)
                return;
            int selectedIndex = indices[0];
            consumables.RemoveAt(selectedIndex);
            FillConsumables();
        }

        private bool HasConsumable(string cs)
        {
            db_menu_items[] items = database.instance.menus[dataIndex].items;
            if(items != null)
            {
                for(int i = 0; i < items.Length; i++)
                {
                    if (items[i].itemName.Equals(cs))
                        return true;
                }
            }
            return false;
        }

        private void SearchConsumable(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_search.Text))
                SearchConsumable(textBox_search.Text);
            else if(!isFilled)
                FillConsumables();
        }

        private void SearchConsumable()
        {
            if (!String.IsNullOrWhiteSpace(textBox_search.Text))
                SearchConsumable(textBox_search.Text);
            else if (!isFilled)
                FillConsumables();
        }

        private void FillConsumables(bool save = true)
        {
            menu_list.Items.Clear();

            for (int i = 0; i < consumables.Count; i++)
            {
                ListViewItem newConsumable = new ListViewItem(consumables[i].cName);
                newConsumable.SubItems.Add(consumables[i].cPrice.ToString());

                menu_list.Items.Add(newConsumable);
            }

            if(save)
            {
                database.instance.menus[dataIndex].UpdateConsumables(consumables);
                database.instance.SaveMenus();
            }

            isFilled = true;
        }

        private void SearchConsumable(string s)
        {
            menu_list.Items.Clear();

            for (int i = 0; i < consumables.Count; i++)
            {
                if(consumables[i].cName.ToLower().StartsWith(s.ToLower()))
                {
                    ListViewItem newConsumable = new ListViewItem(consumables[i].cName);
                    newConsumable.SubItems.Add(consumables[i].cPrice.ToString());

                    menu_list.Items.Add(newConsumable);
                }
            }

            isFilled = false;
        }

        public void AddConsumableTest(object sender, EventArgs e)
        {
            var floatAndStringForm = new IntOrFloatAndStringDialog("New consumable", "Consumable name", "Consumable price", "Add", AddConsumable);
            floatAndStringForm.ShowDialog();
        }

        public void AddConsumable(string conName, float price)
        {
            if(HasConsumable(conName))
            {
                var failDialog = new FailDialog("Consumable already exist");
                failDialog.ShowDialog();
            }
            else
            {
                consumables.Add(new Consumable(conName, price));
                FillConsumables();
            }
        }

        private void UCMenuGroup_Load(object sender, EventArgs e)
        {
            menu_list.Columns.Add("Name", 180);
            menu_list.Columns.Add("Price", 100);
        }
    }
}
